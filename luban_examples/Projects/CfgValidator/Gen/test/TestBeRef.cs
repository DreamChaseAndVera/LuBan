
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
public sealed partial class TestBeRef : Luban.BeanBase
{
    public TestBeRef(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Count = _buf.GetProperty("count").GetInt32();
    }

    public static TestBeRef DeserializeTestBeRef(JsonElement _buf)
    {
        return new test.TestBeRef(_buf);
    }

    public readonly int Id;
    public readonly int Count;
   
    public const int __ID__ = 1934403938;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "count:" + Count + ","
        + "}";
    }
}

}

