
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TestRef extends AbstractBean {
    public TestRef(ByteBuf _buf) { 
        id = _buf.readInt();
        x1 = _buf.readInt();
        x12 = _buf.readInt();
        x2 = _buf.readInt();
        x3 = _buf.readInt();
        x4 = _buf.readInt();
        {int __n0 = Math.min(_buf.readSize(), _buf.size());a1 = new int[__n0];for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { int __e0;__e0 = _buf.readInt(); a1[__i0] = __e0;}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());a2 = new int[__n0];for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { int __e0;__e0 = _buf.readInt(); a2[__i0] = __e0;}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());b1 = new java.util.ArrayList<Integer>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __e0;  __e0 = _buf.readInt(); b1.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());b2 = new java.util.ArrayList<Integer>(__n0);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __e0;  __e0 = _buf.readInt(); b2.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());c1 = new java.util.HashSet<Integer>(__n0 * 3 / 2);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __e0;  __e0 = _buf.readInt(); c1.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());c2 = new java.util.HashSet<Integer>(__n0 * 3 / 2);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __e0;  __e0 = _buf.readInt(); c2.add(__e0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());d1 = new java.util.HashMap<Integer, Integer>(__n0 * 3 / 2);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __k0;  __k0 = _buf.readInt(); Integer __v0;  __v0 = _buf.readInt();     d1.put(__k0, __v0);}}
        {int __n0 = Math.min(_buf.readSize(), _buf.size());d2 = new java.util.HashMap<Integer, Integer>(__n0 * 3 / 2);for(int __i0 = 0 ; __i0 < __n0 ; __i0++) { Integer __k0;  __k0 = _buf.readInt(); Integer __v0;  __v0 = _buf.readInt();     d2.put(__k0, __v0);}}
        e1 = _buf.readInt();
        e2 = _buf.readLong();
        e3 = _buf.readString();
        f1 = _buf.readInt();
        f2 = _buf.readLong();
        f3 = _buf.readString();
        s1 = cfg.test.RefDynamicBase.deserialize(_buf);
    }

    public static TestRef deserialize(ByteBuf _buf) {
            return new cfg.test.TestRef(_buf);
    }

    public final int id;
    public final int x1;
    public final int x12;
    public final int x2;
    public final int x3;
    public final int x4;
    public final int[] a1;
    public final int[] a2;
    public final java.util.ArrayList<Integer> b1;
    public final java.util.ArrayList<Integer> b2;
    public final java.util.HashSet<Integer> c1;
    public final java.util.HashSet<Integer> c2;
    public final java.util.HashMap<Integer, Integer> d1;
    public final java.util.HashMap<Integer, Integer> d2;
    public final int e1;
    public final long e2;
    public final String e3;
    public final int f1;
    public final long f2;
    public final String f3;
    public final cfg.test.RefDynamicBase s1;

    public static final int __ID__ = -543222491;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x12:" + x12 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "a1:" + a1 + ","
        + "a2:" + a2 + ","
        + "b1:" + b1 + ","
        + "b2:" + b2 + ","
        + "c1:" + c1 + ","
        + "c2:" + c2 + ","
        + "d1:" + d1 + ","
        + "d2:" + d2 + ","
        + "e1:" + e1 + ","
        + "e2:" + e2 + ","
        + "e3:" + e3 + ","
        + "f1:" + f1 + ","
        + "f2:" + f2 + ","
        + "f3:" + f3 + ","
        + "s1:" + s1 + ","
        + "}";
    }
}

