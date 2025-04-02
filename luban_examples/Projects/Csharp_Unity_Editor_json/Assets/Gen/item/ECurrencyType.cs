
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace cfg.item
{
    public enum ECurrencyType
    {
        /// <summary>
        /// 钻石
        /// </summary>
        DIAMOND = 1,
        /// <summary>
        /// 金币
        /// </summary>
        GOLD = 2,
        /// <summary>
        /// 银币
        /// </summary>
        SILVER = 3,
        /// <summary>
        /// 经验
        /// </summary>
        EXP = 4,
        /// <summary>
        /// 能量点
        /// </summary>
        POWER_POINT = 5,
    }

    public static class ECurrencyType_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo DIAMOND = new Luban.EditorEnumItemInfo("DIAMOND", "钻石", 1, "钻石");
        public static readonly Luban.EditorEnumItemInfo GOLD = new Luban.EditorEnumItemInfo("GOLD", "金币", 2, "金币");
        public static readonly Luban.EditorEnumItemInfo SILVER = new Luban.EditorEnumItemInfo("SILVER", "银币", 3, "银币");
        public static readonly Luban.EditorEnumItemInfo EXP = new Luban.EditorEnumItemInfo("EXP", "经验", 4, "经验");
        public static readonly Luban.EditorEnumItemInfo POWER_POINT = new Luban.EditorEnumItemInfo("POWER_POINT", "能量点", 5, "能量点");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            DIAMOND,
            GOLD,
            SILVER,
            EXP,
            POWER_POINT,
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

