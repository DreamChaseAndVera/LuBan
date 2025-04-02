
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

public sealed class DemoPrimitiveTypesTable :  Luban.EditorBeanBase 
{
    public DemoPrimitiveTypesTable()
    {
            s1 = "";
            s2 = "";
            v2 = new vec2();
            v3 = new vec3();
            v4 = new vec4();
            t1 = "1970-01-01 00:00:00";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  x1 = _fieldJson;
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
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x7 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s2 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["v2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v2 = vec2.LoadJsonvec2(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["v3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v3 = vec3.LoadJsonvec3(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["v4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v4 = vec4.LoadJsonvec4(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["t1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  t1 = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["x1"] = new JSONBool(x1);
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
            _json["x7"] = new JSONNumber(x7);
        }
        {

            if (s1 == null) { throw new System.ArgumentNullException(); }
            _json["s1"] = new JSONString(s1);
        }
        {

            if (s2 == null) { throw new System.ArgumentNullException(); }
            _json["s2"] = new JSONString(s2);
        }
        {
            { var __bjson0 = new JSONObject(); _json["v2"] = __bjson0; vec2.SaveJsonvec2(v2, __bjson0); }
        }
        {
            { var __bjson0 = new JSONObject(); _json["v3"] = __bjson0; vec3.SaveJsonvec3(v3, __bjson0); }
        }
        {
            { var __bjson0 = new JSONObject(); _json["v4"] = __bjson0; vec4.SaveJsonvec4(v4, __bjson0); }
        }
        {
            _json["t1"] = new JSONString(t1);
        }
    }

    public static DemoPrimitiveTypesTable LoadJsonDemoPrimitiveTypesTable(SimpleJSON.JSONNode _json)
    {
        DemoPrimitiveTypesTable obj = new test.DemoPrimitiveTypesTable();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDemoPrimitiveTypesTable(DemoPrimitiveTypesTable _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public bool x1;

    public byte x2;

    public short x3;

    public int x4;

    public long x5;

    public float x6;

    public double x7;

    public string s1;

    public string s2;

    public vec2 v2;

    public vec3 v3;

    public vec4 v4;

    public string t1;

}

}

