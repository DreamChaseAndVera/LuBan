
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
public sealed partial class TestSet : Luban.BeanBase
{
    public TestSet(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        X0 = _buf.GetProperty("x0").GetString();
        { var __json0 = _buf.GetProperty("x1"); X1 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  X1.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("x2"); X2 = new System.Collections.Generic.List<long>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { long __v0;  __v0 = __e0.GetInt64();  X2.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("x3"); X3 = new System.Collections.Generic.List<string>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { string __v0;  __v0 = __e0.GetString();  X3.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("x4"); X4 = new System.Collections.Generic.List<test.DemoEnum>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoEnum __v0;  __v0 = (test.DemoEnum)__e0.GetInt32();  X4.Add(__v0); }   }
    }

    public static TestSet DeserializeTestSet(JsonElement _buf)
    {
        return new test.TestSet(_buf);
    }

    public readonly int Id;
    public readonly string X0;
    public readonly System.Collections.Generic.List<int> X1;
    public readonly System.Collections.Generic.List<long> X2;
    public readonly System.Collections.Generic.List<string> X3;
    public readonly System.Collections.Generic.List<test.DemoEnum> X4;
   
    public const int __ID__ = -543221516;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x0:" + X0 + ","
        + "x1:" + Luban.StringUtil.CollectionToString(X1) + ","
        + "x2:" + Luban.StringUtil.CollectionToString(X2) + ","
        + "x3:" + Luban.StringUtil.CollectionToString(X3) + ","
        + "x4:" + Luban.StringUtil.CollectionToString(X4) + ","
        + "}";
    }
}

}

