
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class DefineFromExcel2 : Luban.BeanBase
{
    public DefineFromExcel2(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X8 = _buf.ReadInt();
        X10 = _buf.ReadString();
        X13 = (test.DemoEnum)_buf.ReadInt();
        X132 = (test.DemoFlag)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        X15 = test.Shape.DeserializeShape(_buf);
        V2 = vec2.Deserializevec2(_buf);
        T1 = _buf.ReadLong();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); K1[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K2 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); K2[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     K8.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.DemoE2 _e0;  _e0 = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K10 = new System.Collections.Generic.List<System.Numerics.Vector3>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { System.Numerics.Vector3 _e0;  _e0 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_buf)); K10.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K11 = new System.Collections.Generic.List<vec4>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { vec4 _e0;  _e0 = vec4.Deserializevec4(_buf); K11.Add(_e0);}}
        if(_buf.ReadBool()){ V11 = ExternalTypeUtil.NewVector3(vec3.Deserializevec3(_buf)); } else { V11 = null; }
    }

    public static DefineFromExcel2 DeserializeDefineFromExcel2(ByteBuf _buf)
    {
        return new test.DefineFromExcel2(_buf);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 字段x1
    /// </summary>
    public readonly bool X1;
    public readonly long X5;
    public readonly float X6;
    public readonly int X8;
    public readonly string X10;
    public readonly test.DemoEnum X13;
    public readonly test.DemoFlag X132;
    public readonly test.DemoDynamic X14;
    public readonly test.Shape X15;
    public readonly vec2 V2;
    public readonly long T1;
    public readonly int[] K1;
    public readonly int[] K2;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly System.Collections.Generic.List<System.Numerics.Vector3> K10;
    public readonly System.Collections.Generic.List<vec4> K11;
    public readonly System.Numerics.Vector3? V11;
   
    public const int __ID__ = 688816828;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X14?.ResolveRef(tables);
        X15?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + X1 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "x8:" + X8 + ","
        + "x10:" + X10 + ","
        + "x13:" + X13 + ","
        + "x132:" + X132 + ","
        + "x14:" + X14 + ","
        + "x15:" + X15 + ","
        + "v2:" + V2 + ","
        + "t1:" + T1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(K2) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "k10:" + Luban.StringUtil.CollectionToString(K10) + ","
        + "k11:" + Luban.StringUtil.CollectionToString(K11) + ","
        + "v11:" + V11 + ","
        + "}";
    }
}

}

