
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


public final class TbCompositeJsonTable3 {
    private final cfg.test.CompositeJsonTable3 _data;

    public final cfg.test.CompositeJsonTable3 data() { return _data; }

    public TbCompositeJsonTable3(JsonElement _buf) {
        int n = _buf.getAsJsonArray().size();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = cfg.test.CompositeJsonTable3.deserialize(_buf.getAsJsonArray().get(0).getAsJsonObject().getAsJsonObject());
    }


     public int getA() { return _data.a; }
     public int getB() { return _data.b; }

}
