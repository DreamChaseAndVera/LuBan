
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class KeepFaceTarget extends cfg.ai.Service {
    public KeepFaceTarget(ByteBuf _buf) { 
        super(_buf);
        targetActorKey = _buf.readString();
    }

    public static KeepFaceTarget deserialize(ByteBuf _buf) {
            return new cfg.ai.KeepFaceTarget(_buf);
    }

    public final String targetActorKey;

    public static final int __ID__ = 1195270745;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "targetActorKey:" + targetActorKey + ","
        + "}";
    }
}

