//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: hero.proto
// Note: requires additional types generated from: prototype.proto
// Note: requires additional types generated from: herotype.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendHeroList")]
  public partial class SendHeroList : global::ProtoBuf.IExtensible
  {
    public SendHeroList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.HeroInfo> _list = new global::System.Collections.Generic.List<Cmd.HeroInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.HeroInfo> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateHeroList")]
  public partial class UpdateHeroList : global::ProtoBuf.IExtensible
  {
    public UpdateHeroList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.UPDATE_HERO_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.UPDATE_HERO_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.HeroInfo> _list = new global::System.Collections.Generic.List<Cmd.HeroInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.HeroInfo> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveHeroList")]
  public partial class RemoveHeroList : global::ProtoBuf.IExtensible
  {
    public RemoveHeroList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.REMOVE_HERO_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.REMOVE_HERO_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _list = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Item2HeroExpReq")]
  public partial class Item2HeroExpReq : global::ProtoBuf.IExtensible
  {
    public Item2HeroExpReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_ITEM_2_EXP_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_ITEM_2_EXP_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _itemid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private uint _itemnum = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"itemnum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint itemnum
    {
      get { return _itemnum; }
      set { _itemnum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Item2HeroExpRet")]
  public partial class Item2HeroExpRet : global::ProtoBuf.IExtensible
  {
    public Item2HeroExpRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_ITEM_2_EXP_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_ITEM_2_EXP_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private uint _exp = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroStageUpReq")]
  public partial class HeroStageUpReq : global::ProtoBuf.IExtensible
  {
    public HeroStageUpReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_STAGE_UP_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_STAGE_UP_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroStageUpRet")]
  public partial class HeroStageUpRet : global::ProtoBuf.IExtensible
  {
    public HeroStageUpRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_STAGE_UP_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_STAGE_UP_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _stage = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint stage
    {
      get { return _stage; }
      set { _stage = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroQualityUpReq")]
  public partial class HeroQualityUpReq : global::ProtoBuf.IExtensible
  {
    public HeroQualityUpReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_QUALITY_UP_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_QUALITY_UP_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroQualityUpRet")]
  public partial class HeroQualityUpRet : global::ProtoBuf.IExtensible
  {
    public HeroQualityUpRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_QUALITY_UP_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_QUALITY_UP_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _quality = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quality
    {
      get { return _quality; }
      set { _quality = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroStarUpReq")]
  public partial class HeroStarUpReq : global::ProtoBuf.IExtensible
  {
    public HeroStarUpReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_STAR_UP_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_STAR_UP_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeroStarUpRet")]
  public partial class HeroStarUpRet : global::ProtoBuf.IExtensible
  {
    public HeroStarUpRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.HERO_STAR_UP_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.HERO_STAR_UP_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _heroid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"heroid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint heroid
    {
      get { return _heroid; }
      set { _heroid = value; }
    }
    private uint _star = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
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