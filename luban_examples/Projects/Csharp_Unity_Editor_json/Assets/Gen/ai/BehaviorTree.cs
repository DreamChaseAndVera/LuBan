
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

public sealed class BehaviorTree :  Luban.EditorBeanBase 
{
    public BehaviorTree()
    {
            name = "";
            desc = "";
            blackboardId = "";
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
            var _fieldJson = _json["blackboard_id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  blackboardId = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["root"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  root = ai.ComposeNode.LoadJsonComposeNode(_fieldJson);
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

            if (blackboardId == null) { throw new System.ArgumentNullException(); }
            _json["blackboard_id"] = new JSONString(blackboardId);
        }
        {

            if (root == null) { throw new System.ArgumentNullException(); }
            { var __bjson0 = new JSONObject(); _json["root"] = __bjson0; ai.ComposeNode.SaveJsonComposeNode(root, __bjson0); }
        }
    }

    public static BehaviorTree LoadJsonBehaviorTree(SimpleJSON.JSONNode _json)
    {
        BehaviorTree obj = new ai.BehaviorTree();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBehaviorTree(BehaviorTree _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;

    public string name;

    public string desc;

    public string blackboardId;

    public ai.ComposeNode root;

}

}

