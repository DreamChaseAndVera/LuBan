
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
public sealed partial class TestSet : Luban.BeanBase
{
    public TestSet(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X0 = _buf.ReadString();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X1 = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); X1.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X2 = new System.Collections.Generic.List<long>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { long _e0;  _e0 = _buf.ReadLong(); X2.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X3 = new System.Collections.Generic.List<string>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { string _e0;  _e0 = _buf.ReadString(); X3.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);X4 = new System.Collections.Generic.List<test.DemoEnum>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.DemoEnum _e0;  _e0 = (test.DemoEnum)_buf.ReadInt(); X4.Add(_e0);}}
    }

    public static TestSet DeserializeTestSet(ByteBuf _buf)
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

