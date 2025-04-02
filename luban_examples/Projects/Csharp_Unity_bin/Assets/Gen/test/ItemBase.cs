
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public abstract partial class ItemBase : Luban.BeanBase
{
    public ItemBase(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
    }

    public static ItemBase DeserializeItemBase(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case test.Item.__ID__: return new test.Item(_buf);
            case test.Equipment.__ID__: return new test.Equipment(_buf);
            case test.Decorator.__ID__: return new test.Decorator(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly int Id;
    public readonly string Name;
    public readonly string Desc;
   

    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "}";
    }
}

}

