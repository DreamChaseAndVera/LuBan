
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class H1 extends AbstractBean {
    public H1(JsonObject _buf) { 
        y2 = cfg.test.H2.deserialize(_buf.get("y2").getAsJsonObject());
        y3 = _buf.get("y3").getAsInt();
    }

    public static H1 deserialize(JsonObject _buf) {
            return new cfg.test.H1(_buf);
    }

    public final cfg.test.H2 y2;
    public final int y3;

    public static final int __ID__ = -1422503995;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "y2:" + y2 + ","
        + "y3:" + y3 + ","
        + "}";
    }
}

