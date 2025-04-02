
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;

namespace cfg.test
{

public sealed class ExcelFromJsonMultiRow :  Luban.EditorBeanBase 
{
    public ExcelFromJsonMultiRow()
    {
            items = new System.Collections.Generic.List<test.TestRow>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["items"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } items = new System.Collections.Generic.List<test.TestRow>(); foreach(JSONNode __e0 in _fieldJson.Children) { test.TestRow __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.TestRow.LoadJsonTestRow(__e0);  items.Add(__v0); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            _json["x"] = new JSONNumber(x);
        }
        {

            if (items == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["items"] = __cjson0; foreach(var _e0 in items) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; test.TestRow.SaveJsonTestRow(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
    }

    public static ExcelFromJsonMultiRow LoadJsonExcelFromJsonMultiRow(SimpleJSON.JSONNode _json)
    {
        ExcelFromJsonMultiRow obj = new test.ExcelFromJsonMultiRow();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonExcelFromJsonMultiRow(ExcelFromJsonMultiRow _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;

    public int x;

    public System.Collections.Generic.List<test.TestRow> items;

}

}

