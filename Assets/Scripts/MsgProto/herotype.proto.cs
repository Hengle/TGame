//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: herotype.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroInfo")]
  public partial class HeroInfo : global::ProtoBuf.IExtensible
  {
    public HeroInfo() {}
    
    private ulong _thisid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"thisid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong thisid
    {
      get { return _thisid; }
      set { _thisid = value; }
    }
    private uint _heroid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private uint _exp;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private uint _stage;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stage
    {
      get { return _stage; }
      set { _stage = value; }
    }
    private uint _quality;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint quality
    {
      get { return _quality; }
      set { _quality = value; }
    }
    private uint _star;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint star
    {
      get { return _star; }
      set { _star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}