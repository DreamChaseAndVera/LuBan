
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
public sealed partial class H1 : Luban.BeanBase
{
    public H1(JsonElement _buf) 
    {
        Y2 = test.H2.DeserializeH2(_buf.GetProperty("y2"));
        Y3 = _buf.GetProperty("y3").GetInt32();
    }

    public static H1 DeserializeH1(JsonElement _buf)
    {
        return new test.H1(_buf);
    }

    public readonly test.H2 Y2;
    public readonly int Y3;
   
    public const int __ID__ = -1422503995;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        Y2?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "y2:" + Y2 + ","
        + "y3:" + Y3 + ","
        + "}";
    }
}

}

