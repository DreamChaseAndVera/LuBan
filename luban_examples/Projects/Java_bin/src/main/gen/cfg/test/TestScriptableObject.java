
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TestScriptableObject extends AbstractBean {
    public TestScriptableObject(ByteBuf _buf) { 
        id = _buf.readInt();
        desc = _buf.readString();
        rate = _buf.readFloat();
        num = _buf.readInt();
        v2 = cfg.vec2.deserialize(_buf);
        v3 = cfg.vec3.deserialize(_buf);
        v4 = cfg.vec4.deserialize(_buf);
    }

    public static TestScriptableObject deserialize(ByteBuf _buf) {
            return new cfg.test.TestScriptableObject(_buf);
    }

    public final int id;
    public final String desc;
    public final float rate;
    public final int num;
    public final cfg.vec2 v2;
    public final cfg.vec3 v3;
    public final cfg.vec4 v4;

    public static final int __ID__ = -1896814350;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "desc:" + desc + ","
        + "rate:" + rate + ","
        + "num:" + num + ","
        + "v2:" + v2 + ","
        + "v3:" + v3 + ","
        + "v4:" + v4 + ","
        + "}";
    }
}

