
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class SimpleParallel extends cfg.ai.ComposeNode {
    public SimpleParallel(ByteBuf _buf) { 
        super(_buf);
        finishMode = _buf.readInt();
        mainTask = cfg.ai.Task.deserialize(_buf);
        backgroundNode = cfg.ai.FlowNode.deserialize(_buf);
    }

    public static SimpleParallel deserialize(ByteBuf _buf) {
            return new cfg.ai.SimpleParallel(_buf);
    }

    public final int finishMode;
    public final cfg.ai.Task mainTask;
    public final cfg.ai.FlowNode backgroundNode;

    public static final int __ID__ = -1952582529;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "finishMode:" + finishMode + ","
        + "mainTask:" + mainTask + ","
        + "backgroundNode:" + backgroundNode + ","
        + "}";
    }
}

