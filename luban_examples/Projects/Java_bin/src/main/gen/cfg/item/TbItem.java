
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;

import luban.*;


/**
 * 道具表
 */
public final class TbItem {
    private final java.util.HashMap<Integer, cfg.item.Item> _dataMap;
    private final java.util.ArrayList<cfg.item.Item> _dataList;
    
    public TbItem(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.item.Item>();
        _dataList = new java.util.ArrayList<cfg.item.Item>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.item.Item _v;
            _v = cfg.item.Item.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.item.Item> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.item.Item> getDataList() { return _dataList; }

    public cfg.item.Item get(int key) { return _dataMap.get(key); }

}
