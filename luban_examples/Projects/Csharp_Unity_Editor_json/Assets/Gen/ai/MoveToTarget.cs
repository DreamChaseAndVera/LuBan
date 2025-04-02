
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

public sealed class MoveToTarget :  ai.Task 
{
    public MoveToTarget()
    {
            targetActorKey = "";
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
            var _fieldJson = _json["decorators"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } decorators = new System.Collections.Generic.List<ai.Decorator>(); foreach(JSONNode __e0 in _fieldJson.Children) { ai.Decorator __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.Decorator.LoadJsonDecorator(__e0);  decorators.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["services"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } services = new System.Collections.Generic.List<ai.Service>(); foreach(JSONNode __e0 in _fieldJson.Children) { ai.Service __v0;  if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.Service.LoadJsonService(__e0);  services.Add(__v0); }  
            }
        }
        
        { 
            var _fieldJson = _json["ignore_restart_self"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  ignoreRestartSelf = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["target_actor_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  targetActorKey = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["acceptable_radius"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  acceptableRadius = _fieldJson;
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

            if (decorators == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["decorators"] = __cjson0; foreach(var _e0 in decorators) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; ai.Decorator.SaveJsonDecorator(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
        {

            if (services == null) { throw new System.ArgumentNullException(); }
            { var __cjson0 = new JSONArray(); _json["services"] = __cjson0; foreach(var _e0 in services) { JSONNode __v0; { var __bjson1 = new JSONObject();  __v0 = __bjson1; ai.Service.SaveJsonService(_e0, __bjson1); } __cjson0.Add(__v0); } }
        }
        {
            _json["ignore_restart_self"] = new JSONBool(ignoreRestartSelf);
        }
        {

            if (targetActorKey == null) { throw new System.ArgumentNullException(); }
            _json["target_actor_key"] = new JSONString(targetActorKey);
        }
        {
            _json["acceptable_radius"] = new JSONNumber(acceptableRadius);
        }
    }

    public static MoveToTarget LoadJsonMoveToTarget(SimpleJSON.JSONNode _json)
    {
        MoveToTarget obj = new ai.MoveToTarget();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMoveToTarget(MoveToTarget _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string targetActorKey;

    public float acceptableRadius;

}

}

