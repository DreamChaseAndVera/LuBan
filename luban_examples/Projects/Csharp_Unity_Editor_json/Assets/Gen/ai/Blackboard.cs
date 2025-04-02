
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

public sealed class Blackboard :  Luban.EditorBeanBase 
{
    public Blackboard()
    {
            name = "";
            desc = "";
            parentName = "";
            keys = new System.Collections.Generic.List<ai.BlackboardKey>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
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
            var _fieldJson = _json["parent_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  parentName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["keys"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } keys = new System.Collections.Generic.List<ai.BlackboardKey>(); foreach(JSONNode __e0 in _fieldJson.Children) { ai.BlackboardKey __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.BlackboardKey.LoadJsonBlackboardKey(__e0);  keys.Add(__v0); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {

            if (name == null) { throw new System.ArgumentNullException(); }
            _json["name"] = new JSONString(name);
        }
        {

            if (desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(desc);
        }
        {

            if (parentName == null) { throw new System.ArgumentNullException(); }
            _json["parent_name"] = new JSONString(parentName);
        }
        {

            if (keys == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["keys"] = __cjson0; foreach(var _e0 in keys) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; ai.BlackboardKey.SaveJsonBlackboardKey(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
    }

    public static Blackboard LoadJsonBlackboard(SimpleJSON.JSONNode _json)
    {
        Blackboard obj = new ai.Blackboard();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBlackboard(Blackboard _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string name;

    public string desc;

    public string parentName;

    public System.Collections.Generic.List<ai.BlackboardKey> keys;

}

}

