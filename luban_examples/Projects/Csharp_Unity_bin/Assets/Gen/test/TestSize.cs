
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
public sealed partial class TestSize : Luban.BeanBase
{
    public TestSize(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X1 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); X1[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X2 = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); X2.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X3 = new System.Collections.Generic.HashSet<int>(/*n0 * 3 / 2*/);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); X3.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X4 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     X4.Add(_k0, _v0);}}
    }

    public static TestSize DeserializeTestSize(ByteBuf _buf)
    {
        return new test.TestSize(_buf);
    }

    public readonly int Id;
    public readonly int[] X1;
    public readonly System.Collections.Generic.List<int> X2;
    public readonly System.Collections.Generic.HashSet<int> X3;
    public readonly System.Collections.Generic.Dictionary<int, int> X4;
   
    public const int __ID__ = 340006319;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + Luban.StringUtil.CollectionToString(X1) + ","
        + "x2:" + Luban.StringUtil.CollectionToString(X2) + ","
        + "x3:" + Luban.StringUtil.CollectionToString(X3) + ","
        + "x4:" + Luban.StringUtil.CollectionToString(X4) + ","
        + "}";
    }
}

}

