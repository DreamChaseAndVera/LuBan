// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AiIsNotSet : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static AiIsNotSet GetRootAsAiIsNotSet(ByteBuffer _bb) { return GetRootAsAiIsNotSet(_bb, new AiIsNotSet()); }
  public static AiIsNotSet GetRootAsAiIsNotSet(ByteBuffer _bb, AiIsNotSet obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AiIsNotSet __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartAiIsNotSet(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<cfg.AiIsNotSet> EndAiIsNotSet(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.AiIsNotSet>(o);
  }
}


static public class AiIsNotSetVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
