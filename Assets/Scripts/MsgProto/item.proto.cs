//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: item.proto
// Note: requires additional types generated from: prototype.proto
// Note: requires additional types generated from: itemtype.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendItemList")]
  public partial class SendItemList : global::ProtoBuf.IExtensible
  {
    public SendItemList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.ITEM_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.ITEM_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.ItemInfo> _list = new global::System.Collections.Generic.List<Cmd.ItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.ItemInfo> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateItemList")]
  public partial class UpdateItemList : global::ProtoBuf.IExtensible
  {
    public UpdateItemList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.UPDATE_ITEM_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.UPDATE_ITEM_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.ItemInfo> _list = new global::System.Collections.Generic.List<Cmd.ItemInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.ItemInfo> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RemoveItemList")]
  public partial class RemoveItemList : global::ProtoBuf.IExtensible
  {
    public RemoveItemList() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.REMOVE_ITEM_LIST_S;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.REMOVE_ITEM_LIST_S)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _list = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(2, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<ulong> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SellItemReq")]
  public partial class SellItemReq : global::ProtoBuf.IExtensible
  {
    public SellItemReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.SELL_ITEM_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.SELL_ITEM_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _itemid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private uint _num;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SellItemRet")]
  public partial class SellItemRet : global::ProtoBuf.IExtensible
  {
    public SellItemRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.SELL_ITEM_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.SELL_ITEM_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UseItemReq")]
  public partial class UseItemReq : global::ProtoBuf.IExtensible
  {
    public UseItemReq() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.USE_ITEM_CS;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.USE_ITEM_CS)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _itemid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UseItemRet")]
  public partial class UseItemRet : global::ProtoBuf.IExtensible
  {
    public UseItemRet() {}
    
    private Cmd.EMessageID _id = Cmd.EMessageID.USE_ITEM_SC;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EMessageID.USE_ITEM_SC)]
    public Cmd.EMessageID id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<Cmd.ItemNotiType> _item = new global::System.Collections.Generic.List<Cmd.ItemNotiType>();
    [global::ProtoBuf.ProtoMember(2, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Cmd.ItemNotiType> item
    {
      get { return _item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}