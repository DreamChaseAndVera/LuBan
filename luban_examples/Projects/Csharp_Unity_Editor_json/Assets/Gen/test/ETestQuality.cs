
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace cfg.test
{
    public enum ETestQuality
    {
        /// <summary>
        /// 最高品质
        /// </summary>
        A = 1,
        /// <summary>
        /// 黑色的
        /// </summary>
        B = 2,
        /// <summary>
        /// 蓝色的
        /// </summary>
        C = 3,
        /// <summary>
        /// 最差品质
        /// </summary>
        D = 4,
    }

    public static class ETestQuality_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo A = new Luban.EditorEnumItemInfo("A", "白", 1, "最高品质");
        public static readonly Luban.EditorEnumItemInfo B = new Luban.EditorEnumItemInfo("B", "黑", 2, "黑色的");
        public static readonly Luban.EditorEnumItemInfo C = new Luban.EditorEnumItemInfo("C", "蓝", 3, "蓝色的");
        public static readonly Luban.EditorEnumItemInfo D = new Luban.EditorEnumItemInfo("D", "红", 4, "最差品质");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            A,
            B,
            C,
            D,
        };

        public static System.Collections.Generic.List<Luban.EditorEnumItemInfo> GetItems() => __items;

        public static Luban.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Luban.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Luban.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }

} 

