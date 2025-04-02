
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public abstract class Decorator extends cfg.ai.Node {
    public Decorator(ByteBuf _buf) { 
        super(_buf);
        flowAbortMode = _buf.readInt();
    }

    public static Decorator deserialize(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.ai.UeLoop.__ID__: return new cfg.ai.UeLoop(_buf);
            case cfg.ai.UeCooldown.__ID__: return new cfg.ai.UeCooldown(_buf);
            case cfg.ai.UeTimeLimit.__ID__: return new cfg.ai.UeTimeLimit(_buf);
            case cfg.ai.UeBlackboard.__ID__: return new cfg.ai.UeBlackboard(_buf);
            case cfg.ai.UeForceSuccess.__ID__: return new cfg.ai.UeForceSuccess(_buf);
            case cfg.ai.IsAtLocation.__ID__: return new cfg.ai.IsAtLocation(_buf);
            case cfg.ai.DistanceLessThan.__ID__: return new cfg.ai.DistanceLessThan(_buf);
            default: throw new SerializationException();
        }
    }

    public final int flowAbortMode;


    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "}";
    }
}

