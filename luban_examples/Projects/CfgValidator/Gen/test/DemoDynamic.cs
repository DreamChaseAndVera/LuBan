
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
public abstract partial class DemoDynamic : Luban.BeanBase
{
    public DemoDynamic(JsonElement _buf) 
    {
        X1 = _buf.GetProperty("x1").GetInt32();
    }

    public static DemoDynamic DeserializeDemoDynamic(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "DemoD2": return new test.DemoD2(_buf);
            case "DemoE1": return new test.DemoE1(_buf);
            case "test.login.RoleInfo": return new test.login.RoleInfo(_buf);
            case "DemoD5": return new test.DemoD5(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly int X1;
   

    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "x1:" + X1 + ","
        + "}";
    }
}

}

