
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

namespace cfg.ai
{

public sealed class DistanceLessThan :  ai.Decorator 
{
    public DistanceLessThan()
    {
            actor1Key = "";
            actor2Key = "";
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
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  nodeName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["flow_abort_mode"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { flowAbortMode = (ai.EFlowAbortMode)System.Enum.Parse(typeof(ai.EFlowAbortMode), _fieldJson); } else if(_fieldJson.IsNumber) { flowAbortMode = (ai.EFlowAbortMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["actor1_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  actor1Key = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["actor2_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  actor2Key = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["distance"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  distance = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["reverse_result"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  reverseResult = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (nodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(nodeName);
        }
        {
            _json["flow_abort_mode"] = new JSONNumber((int)flowAbortMode);
        }
        {

            if (actor1Key == null) { throw new System.ArgumentNullException(); }
            _json["actor1_key"] = new JSONString(actor1Key);
        }
        {

            if (actor2Key == null) { throw new System.ArgumentNullException(); }
            _json["actor2_key"] = new JSONString(actor2Key);
        }
        {
            _json["distance"] = new JSONNumber(distance);
        }
        {
            _json["reverse_result"] = new JSONBool(reverseResult);
        }
    }

    public static DistanceLessThan LoadJsonDistanceLessThan(SimpleJSON.JSONNode _json)
    {
        DistanceLessThan obj = new ai.DistanceLessThan();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDistanceLessThan(DistanceLessThan _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string actor1Key;

    public string actor2Key;

    public float distance;

    public bool reverseResult;

}

}

