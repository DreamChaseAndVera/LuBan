
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.test
{
public sealed partial class TestGlobal : Luban.BeanBase
{
    public TestGlobal(JsonElement _buf) 
    {
        UnlockEquip = _buf.GetProperty("unlock_equip").GetInt32();
        UnlockHero = _buf.GetProperty("unlock_hero").GetInt32();
    }

    public static TestGlobal DeserializeTestGlobal(JsonElement _buf)
    {
        return new test.TestGlobal(_buf);
    }

    public readonly int UnlockEquip;
    public readonly int UnlockHero;
   
    public const int __ID__ = -12548655;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "unlockEquip:" + UnlockEquip + ","
        + "unlockHero:" + UnlockHero + ","
        + "}";
    }
}

}

