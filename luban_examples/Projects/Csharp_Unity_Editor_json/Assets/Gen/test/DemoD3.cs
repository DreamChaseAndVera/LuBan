
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

public abstract class DemoD3 :  test.DemoDynamic 
{
    public DemoD3()
    {
    }


    public static DemoD3 LoadJsonDemoD3(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        DemoD3 obj;
        switch (type)
        {
            case "test.DemoE1":   
            case "DemoE1":obj = new test.DemoE1(); break;
            case "test.login.RoleInfo":obj = new test.login.RoleInfo(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDemoD3(DemoD3 _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int x3;

}

}

