
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace cfg.test
{
    public enum ETestEmptyEnum2
    {
        SMALL_THAN_256 = 255,
        X_256 = 256,
        X_257 = 257,
    }

    public static class ETestEmptyEnum2_Metadata
    {
        public static readonly Luban.EditorEnumItemInfo SMALL_THAN_256 = new Luban.EditorEnumItemInfo("SMALL_THAN_256", "", 255, "");
        public static readonly Luban.EditorEnumItemInfo X_256 = new Luban.EditorEnumItemInfo("X_256", "", 256, "");
        public static readonly Luban.EditorEnumItemInfo X_257 = new Luban.EditorEnumItemInfo("X_257", "", 257, "");

        private static readonly System.Collections.Generic.List<Luban.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Luban.EditorEnumItemInfo>
        {
            SMALL_THAN_256,
            X_256,
            X_257,
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

