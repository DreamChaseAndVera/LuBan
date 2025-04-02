
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Linq;


namespace cfg.common
{
    public partial class TbGlobalConfig
    {
        private readonly System.Func<string, int, int, ByteBuf> _byteBufLoader;
        private readonly string _fileName;
        private Tables _tables;

        private readonly common.GlobalConfig _data;
     
        public TbGlobalConfig(ByteBuf _buf, string fileName, System.Func<string, int, int, ByteBuf> byteBufLoader)
        {
            int n = _buf.ReadSize();
            if (n != 1) throw new SerializationException("table mode=one, but size != 1");
            int offset = _buf.ReadInt();
            int length = _buf.ReadInt();
            ByteBuf dataBuf = byteBufLoader(fileName, offset, length);
            _data = common.GlobalConfig.DeserializeGlobalConfig(dataBuf);
        }


        /// <summary>
        /// 背包容量
        /// </summary>
         public int X1 => _data.X1;
         public int X2 => _data.X2;
         public int X3 => _data.X3;
         public int X4 => _data.X4;
         public int X5 => _data.X5;
         public int X6 => _data.X6;
         public System.Collections.Generic.List<int> X7 => _data.X7;
    
        public void ResolveRef(Tables tables)
        {
            _data.ResolveRef(tables);
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }

}
