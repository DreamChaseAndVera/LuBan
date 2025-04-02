
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

public sealed class FloatRange :  Luban.EditorBeanBase 
{
    public FloatRange()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["min"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  min = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["max"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  max = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["min"] = new JSONNumber(min);
        }
        {
            _json["max"] = new JSONNumber(max);
        }
    }

    public static FloatRange LoadJsonFloatRange(SimpleJSON.JSONNode _json)
    {
        FloatRange obj = new common.FloatRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonFloatRange(FloatRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public float min;

    public float max;

}

}

