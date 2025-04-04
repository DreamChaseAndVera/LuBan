﻿using Luban.Defs;
using Luban.RawDefs;
using Luban.Utils;
using System.Text.RegularExpressions;

namespace Luban.Schema.Builtin;

[TableImporter("gameframex")]
public class GameFrameXTableImporter : ITableImporter
{
    private static readonly NLog.Logger s_logger = NLog.LogManager.GetCurrentClassLogger();

    public List<RawTable> LoadImportTables()
    {
        string dataDir = GenerationContext.GlobalConf.InputDataDir;
        var groups = GenerationContext.GlobalConf.Groups;
        var targets = GenerationContext.GlobalConf.Targets;
        var excludePaths = GenerationContext.ExcludePaths;
        s_logger.Info("exclude sss paths: " + string.Join(",", excludePaths)+" targetName: "+ GenerationContext.TargetName);
        var exportTarget = targets.Find(m => m.Name == GenerationContext.TargetName);

        string fileNamePatternStr = EnvManager.Current.GetOptionOrDefault("tableImporter", "filePattern", false, "([a-zA-Z0-9]-.+)");
        string tableNamespaceFormatStr = EnvManager.Current.GetOptionOrDefault("tableImporter", "tableNamespaceFormat", false, "{0}");
        string tableNameFormatStr = EnvManager.Current.GetOptionOrDefault("tableImporter", "tableNameFormat", false, "Tb{0}");
        string valueTypeNameFormatStr = EnvManager.Current.GetOptionOrDefault("tableImporter", "valueTypeNameFormat", false, "{0}");
        var fileNamePattern = new Regex(fileNamePatternStr);
        var excelExts = new HashSet<string> { "xlsx", "xls", "xlsm", "csv" };

        var tables = new List<RawTable>();
        foreach (string file in Directory.GetFiles(dataDir, "*", SearchOption.AllDirectories))
        {
            if (FileUtil.IsIgnoreFile(dataDir, file))
            {
                continue;
            }

            // 检查文件是否在排除路径中
            string relativePath = file.Substring(dataDir.Length + 1).TrimStart('\\').TrimStart('/');
            if (excludePaths?.Any(excludePath => relativePath.StartsWith(excludePath, StringComparison.OrdinalIgnoreCase)) == true)
            {
                continue;
            }

            string fileName = Path.GetFileName(file);
            string ext = Path.GetExtension(fileName).TrimStart('.');
            if (!excelExts.Contains(ext))
            {
                continue;
            }

            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
            var match = fileNamePattern.Match(fileNameWithoutExt);
            if (!match.Success || match.Groups.Count <= 1)
            {
                continue;
            }

            string namespaceFromRelativePath = Path.GetDirectoryName(relativePath).Replace('/', '.').Replace('\\', '.');

            string rawTableFullName = match.Groups[1].Value;
            var split = rawTableFullName.Split(['-', '_',], StringSplitOptions.RemoveEmptyEntries);
            if (split.Length > 1)
            {
                if (GenerationContext.TargetName == "server" && split[0].ToLower() == "c")
                {
                    continue;
                }
                if (GenerationContext.TargetName == "client" && split[0].ToLower() == "s")
                {
                    continue;
                }
                // 代表有首字母的排序, 不管后面有多少都只要第二个切片
                // 获取中间的值
                rawTableFullName = split[1];
            }

            if (split.Length > 2)
            {
                string groupName = split[2].Trim().ToLower();
                if (!string.IsNullOrEmpty(groupName) && !IsContainsZhCn(groupName))
                {
                    // 判断是否在组中
                    bool isExistGroup = groups.Any(group => group.Names.Contains(groupName));

                    if (isExistGroup)
                    {
                        // 判断是否导出
                        bool isExport = exportTarget.Groups.Any(targetGroupName => targetGroupName.Equals(groupName, StringComparison.OrdinalIgnoreCase));

                        if (!isExport)
                        {
                            continue;
                        }
                    }
                }
            }

            if (IsContainsZhCn(rawTableFullName))
            {
                throw new Exception($"不支持中文表名:[{rawTableFullName}] 文件名:[{fileName}] 表名称定义规范为: 排序编号-导出表名-中文标识名称");
            }

            string rawTableNamespace = TypeUtil.GetNamespace(rawTableFullName);
            string rawTableName = TypeUtil.GetName(rawTableFullName);
            string tableNamespace = TypeUtil.MakeFullName(namespaceFromRelativePath, string.Format(tableNamespaceFormatStr, rawTableNamespace));
            string tableName = string.Format(tableNameFormatStr, rawTableName);
            string valueTypeFullName = TypeUtil.MakeFullName(tableNamespace, string.Format(valueTypeNameFormatStr, rawTableName));
            
            bool isExist = false;
            foreach (var rawTable in tables)
            {
                if (rawTable.Namespace == tableNamespace && rawTable.Name == tableName)
                {
                    rawTable.InputFiles.Add(relativePath);
                    isExist = true;
                    break;
                }
            }

            if (isExist)
            {
                continue;
            }
            s_logger.Info("生成配置表 : " + rawTableFullName+ " 配置表当前路径: "+ relativePath);
            var table = new RawTable()
            {
                Namespace = tableNamespace,
                Name = tableName,
                Index = "",
                ValueType = valueTypeFullName,
                ReadSchemaFromFile = true,
                Mode = TableMode.MAP,
                Comment = "",
                Groups = new List<string> { },
                InputFiles = new List<string> { relativePath },
                OutputFile = "",
            };
            s_logger.Debug("import table file:{@}", table);
            tables.Add(table);
        }

        return tables;
    }

    /// <summary>
    /// 匹配中文正则表达式
    /// </summary>
    private static readonly Regex CnReg = new Regex(@"[\u4e00-\u9fa5]");

    /// <summary>
    /// 判断是否有中文
    /// </summary>
    /// <param name="self">原始字符串</param>
    /// <returns></returns>
    private static bool IsContainsZhCn(string self)
    {
        return CnReg.IsMatch(self);
    }
}
