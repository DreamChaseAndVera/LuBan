
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class UeWait extends cfg.ai.Task {
    public UeWait(ByteBuf _buf) { 
        super(_buf);
        waitTime = _buf.readFloat();
        randomDeviation = _buf.readFloat();
    }

    public static UeWait deserialize(ByteBuf _buf) {
            return new cfg.ai.UeWait(_buf);
    }

    public final float waitTime;
    public final float randomDeviation;

    public static final int __ID__ = -512994101;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "ignoreRestartSelf:" + ignoreRestartSelf + ","
        + "waitTime:" + waitTime + ","
        + "randomDeviation:" + randomDeviation + ","
        + "}";
    }
}

