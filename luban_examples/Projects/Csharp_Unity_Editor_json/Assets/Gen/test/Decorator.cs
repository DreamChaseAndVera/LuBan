
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

public sealed class Decorator :  test.ItemBase 
{
    public Decorator()
    {
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
            var _fieldJson = _json["name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  name = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["duration"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  duration = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (name == null) { throw new System.ArgumentNullException(); }
            _json["name"] = new JSONString(name);
        }
        {

            if (desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(desc);
        }
        {
            _json["duration"] = new JSONNumber(duration);
        }
    }

    public static Decorator LoadJsonDecorator(SimpleJSON.JSONNode _json)
    {
        Decorator obj = new test.Decorator();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDecorator(Decorator _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int duration;

}

}

