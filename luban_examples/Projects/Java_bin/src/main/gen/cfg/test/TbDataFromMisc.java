
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbDataFromMisc {
    private final java.util.HashMap<Integer, cfg.test.DemoType2> _dataMap;
    private final java.util.ArrayList<cfg.test.DemoType2> _dataList;
    
    public TbDataFromMisc(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DemoType2>();
        _dataList = new java.util.ArrayList<cfg.test.DemoType2>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.DemoType2 _v;
            _v = cfg.test.DemoType2.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.x4, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DemoType2> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DemoType2> getDataList() { return _dataList; }

    public cfg.test.DemoType2 get(int key) { return _dataMap.get(key); }

}
