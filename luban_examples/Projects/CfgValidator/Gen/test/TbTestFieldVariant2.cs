
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.test
{
public partial class TbTestFieldVariant2
{
    private readonly System.Collections.Generic.Dictionary<int, test.TestFieldVariant2> _dataMap;
    private readonly System.Collections.Generic.List<test.TestFieldVariant2> _dataList;
    
    public TbTestFieldVariant2(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.TestFieldVariant2>();
        _dataList = new System.Collections.Generic.List<test.TestFieldVariant2>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            test.TestFieldVariant2 _v;
            _v = test.TestFieldVariant2.DeserializeTestFieldVariant2(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.TestFieldVariant2> DataMap => _dataMap;
    public System.Collections.Generic.List<test.TestFieldVariant2> DataList => _dataList;

    public test.TestFieldVariant2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestFieldVariant2 Get(int key) => _dataMap[key];
    public test.TestFieldVariant2 this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

