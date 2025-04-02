
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
public abstract partial class Decorator : ai.Node
{
    public Decorator(ByteBuf _buf)  : base(_buf) 
    {
        FlowAbortMode = (ai.EFlowAbortMode)_buf.ReadInt();
    }

    public static Decorator DeserializeDecorator(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.UeLoop.__ID__: return new ai.UeLoop(_buf);
            case ai.UeCooldown.__ID__: return new ai.UeCooldown(_buf);
            case ai.UeTimeLimit.__ID__: return new ai.UeTimeLimit(_buf);
            case ai.UeBlackboard.__ID__: return new ai.UeBlackboard(_buf);
            case ai.UeForceSuccess.__ID__: return new ai.UeForceSuccess(_buf);
            case ai.IsAtLocation.__ID__: return new ai.IsAtLocation(_buf);
            case ai.DistanceLessThan.__ID__: return new ai.DistanceLessThan(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly ai.EFlowAbortMode FlowAbortMode;
   

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
}

}

