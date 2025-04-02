
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.ai
{
public sealed partial class Sequence : ai.ComposeNode
{
    public Sequence(ByteBuf _buf)  : base(_buf) 
    {
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Children = new System.Collections.Generic.List<ai.FlowNode>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { ai.FlowNode _e0;  _e0 = ai.FlowNode.DeserializeFlowNode(_buf); Children.Add(_e0);}}
    }

    public static Sequence DeserializeSequence(ByteBuf _buf)
    {
        return new ai.Sequence(_buf);
    }

    public readonly System.Collections.Generic.List<ai.FlowNode> Children;
   
    public const int __ID__ = -1789006105;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        foreach (var _e in Children) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "children:" + Luban.StringUtil.CollectionToString(Children) + ","
        + "}";
    }
}

}

