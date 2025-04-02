
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
public sealed partial class TestScriptableObject : Luban.BeanBase
{
    public TestScriptableObject(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Desc = _buf.GetProperty("desc").GetString();
        Rate = _buf.GetProperty("rate").GetSingle();
        Num = _buf.GetProperty("num").GetInt32();
        V2 = vec2.Deserializevec2(_buf.GetProperty("v2"));
        V3 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_buf.GetProperty("v3")));
        V4 = vec4.Deserializevec4(_buf.GetProperty("v4"));
    }

    public static TestScriptableObject DeserializeTestScriptableObject(JsonElement _buf)
    {
        return new test.TestScriptableObject(_buf);
    }

    public readonly int Id;
    public readonly string Desc;
    public readonly float Rate;
    public readonly int Num;
    public readonly vec2 V2;
    public readonly System.Numerics.Vector3 V3;
    public readonly vec4 V4;
   
    public const int __ID__ = -1896814350;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "desc:" + Desc + ","
        + "rate:" + Rate + ","
        + "num:" + Num + ","
        + "v2:" + V2 + ","
        + "v3:" + V3 + ","
        + "v4:" + V4 + ","
        + "}";
    }
}

}

