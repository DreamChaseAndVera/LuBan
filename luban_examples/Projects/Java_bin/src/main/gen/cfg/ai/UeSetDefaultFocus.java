
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class UeSetDefaultFocus extends cfg.ai.Service {
    public UeSetDefaultFocus(ByteBuf _buf) { 
        super(_buf);
        keyboardKey = _buf.readString();
    }

    public static UeSetDefaultFocus deserialize(ByteBuf _buf) {
            return new cfg.ai.UeSetDefaultFocus(_buf);
    }

    public final String keyboardKey;

    public static final int __ID__ = 1812449155;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "keyboardKey:" + keyboardKey + ","
        + "}";
    }
}

