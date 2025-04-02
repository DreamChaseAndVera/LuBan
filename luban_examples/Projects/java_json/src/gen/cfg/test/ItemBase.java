
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public abstract class ItemBase extends AbstractBean {
    public ItemBase(JsonObject _buf) { 
        id = _buf.get("id").getAsInt();
        name = _buf.get("name").getAsString();
        desc = _buf.get("desc").getAsString();
    }

    public static ItemBase deserialize(JsonObject _buf) {
        switch (_buf.get("$type").getAsString()) {
            case "Item": return new cfg.test.Item(_buf);
            case "Equipment": return new cfg.test.Equipment(_buf);
            case "Decorator": return new cfg.test.Decorator(_buf);
            default: throw new SerializationException();
        }
    }

    public final int id;
    public final String name;
    public final String desc;


    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "}";
    }
}

