
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.l10n
{
public sealed partial class L10NDemo : Luban.BeanBase
{
    public L10NDemo(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Text = _buf.GetProperty("text").GetString();
    }

    public static L10NDemo DeserializeL10NDemo(JsonElement _buf)
    {
        return new l10n.L10NDemo(_buf);
    }

    public readonly int Id;
    public readonly string Text;
   
    public const int __ID__ = -331195887;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "text:" + Text + ","
        + "}";
    }
}

}

