
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.ai
{
public sealed partial class UeBlackboard : ai.Decorator
{
    public UeBlackboard(JsonElement _buf)  : base(_buf) 
    {
        NotifyObserver = (ai.ENotifyObserverMode)_buf.GetProperty("notify_observer").GetInt32();
        BlackboardKey = _buf.GetProperty("blackboard_key").GetString();
        KeyQuery = ai.KeyQueryOperator.DeserializeKeyQueryOperator(_buf.GetProperty("key_query"));
    }

    public static UeBlackboard DeserializeUeBlackboard(JsonElement _buf)
    {
        return new ai.UeBlackboard(_buf);
    }

    public readonly ai.ENotifyObserverMode NotifyObserver;
    public readonly string BlackboardKey;
    public readonly ai.KeyQueryOperator KeyQuery;
   
    public const int __ID__ = -315297507;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        KeyQuery?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "notifyObserver:" + NotifyObserver + ","
        + "blackboardKey:" + BlackboardKey + ","
        + "keyQuery:" + KeyQuery + ","
        + "}";
    }
}

}

