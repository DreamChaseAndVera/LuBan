
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

namespace cfg.common
{

public sealed class GlobalConfig :  Luban.EditorBeanBase 
{
    public GlobalConfig()
    {
            x7 = new System.Collections.Generic.List<int>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x2 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x3 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x4 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x5"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x5 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x6"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x6 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x7"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } x7 = new System.Collections.Generic.List<int>(); foreach(JSONNode __e0 in _fieldJson.Children) { int __v0;  if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0;  x7.Add(__v0); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x1"] = new JSONNumber(x1);
        }
        {
            _json["x2"] = new JSONNumber(x2);
        }
        {
            _json["x3"] = new JSONNumber(x3);
        }
        {
            _json["x4"] = new JSONNumber(x4);
        }
        {
            _json["x5"] = new JSONNumber(x5);
        }
        {
            _json["x6"] = new JSONNumber(x6);
        }
        {

            if (x7 == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["x7"] = __cjson0; foreach(var _e0 in x7) { JSONNode __v0; __v0 = new JSONNumber(_e0); __cjson0.Add(__v0); } }
        }
    }

    public static GlobalConfig LoadJsonGlobalConfig(SimpleJSON.JSONNode _json)
    {
        GlobalConfig obj = new common.GlobalConfig();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonGlobalConfig(GlobalConfig _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 背包容量
    /// </summary>
    public int x1;

    public int x2;

    public int x3;

    public int x4;

    public int x5;

    public int x6;

    public System.Collections.Generic.List<int> x7;

}

}

