
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class NotIndexList extends AbstractBean {
    public NotIndexList(ByteBuf _buf) { 
        x = _buf.readInt();
        y = _buf.readInt();
    }

    public static NotIndexList deserialize(ByteBuf _buf) {
            return new cfg.test.NotIndexList(_buf);
    }

    public final int x;
    public final int y;

    public static final int __ID__ = -50446599;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "x:" + x + ","
        + "y:" + y + ","
        + "}";
    }
}

