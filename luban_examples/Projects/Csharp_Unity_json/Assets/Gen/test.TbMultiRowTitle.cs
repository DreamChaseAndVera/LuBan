
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public partial class TbMultiRowTitle
{
    private readonly System.Collections.Generic.Dictionary<int, test.MultiRowTitle> _dataMap;
    private readonly System.Collections.Generic.List<test.MultiRowTitle> _dataList;
    
    public TbMultiRowTitle(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, test.MultiRowTitle>();
        _dataList = new System.Collections.Generic.List<test.MultiRowTitle>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            test.MultiRowTitle _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = test.MultiRowTitle.DeserializeMultiRowTitle(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, test.MultiRowTitle> DataMap => _dataMap;
    public System.Collections.Generic.List<test.MultiRowTitle> DataList => _dataList;

    public test.MultiRowTitle GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.MultiRowTitle Get(int key) => _dataMap[key];
    public test.MultiRowTitle this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

