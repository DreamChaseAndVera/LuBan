
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class Selector extends cfg.ai.ComposeNode {
    public Selector(ByteBuf _buf) { 
        super(_buf);
        {int __n0 = Math.min(_buf.readSize(), _buf.size());children = new java.util.ArrayList<cfg.ai.FlowNode>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { cfg.ai.FlowNode __e0;  __e0 = cfg.ai.FlowNode.deserialize(_buf); children.add(__e0);}}
    }

    public static Selector deserialize(ByteBuf _buf) {
            return new cfg.ai.Selector(_buf);
    }

    public final java.util.ArrayList<cfg.ai.FlowNode> children;

    public static final int __ID__ = -1946981627;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "children:" + children + ","
        + "}";
    }
}

