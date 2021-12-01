// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs6_demo_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.ACS6DemoContract {

  /// <summary>Holder for reflection information generated from acs6_demo_contract.proto</summary>
  internal static partial class Acs6DemoContractReflection {

    #region Descriptor
    /// <summary>File descriptor for acs6_demo_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Acs6DemoContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhhY3M2X2RlbW9fY29udHJhY3QucHJvdG8aCmFjczYucHJvdG8aG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoSYWVsZi9vcHRpb25zLnByb3RvIkgK",
            "C1JlcXVlc3RTbG90EhQKDHJvdW5kX251bWJlchgBIAEoEhINCgVvcmRlchgC",
            "IAEoERIUCgxibG9ja19oZWlnaHQYAyABKBIynQEKEEFDUzZEZW1vQ29udHJh",
            "Y3QSPgoKSW5pdGlhbGl6ZRIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eSIAGkmyzPYBNUFFbGYuQ29udHJhY3RzLkFD",
            "UzZEZW1vQ29udHJhY3QuQUNTNkRlbW9Db250cmFjdFN0YXRlysr2AQphY3M2",
            "LnByb3RvQiKqAh9BRWxmLkNvbnRyYWN0cy5BQ1M2RGVtb0NvbnRyYWN0YgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Standards.ACS6.Acs6Reflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS6DemoContract.RequestSlot), global::AElf.Contracts.ACS6DemoContract.RequestSlot.Parser, new[]{ "RoundNumber", "Order", "BlockHeight" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class RequestSlot : pb::IMessage<RequestSlot> {
    private static readonly pb::MessageParser<RequestSlot> _parser = new pb::MessageParser<RequestSlot>(() => new RequestSlot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestSlot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS6DemoContract.Acs6DemoContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestSlot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestSlot(RequestSlot other) : this() {
      roundNumber_ = other.roundNumber_;
      order_ = other.order_;
      blockHeight_ = other.blockHeight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestSlot Clone() {
      return new RequestSlot(this);
    }

    /// <summary>Field number for the "round_number" field.</summary>
    public const int RoundNumberFieldNumber = 1;
    private long roundNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoundNumber {
      get { return roundNumber_; }
      set {
        roundNumber_ = value;
      }
    }

    /// <summary>Field number for the "order" field.</summary>
    public const int OrderFieldNumber = 2;
    private int order_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Order {
      get { return order_; }
      set {
        order_ = value;
      }
    }

    /// <summary>Field number for the "block_height" field.</summary>
    public const int BlockHeightFieldNumber = 3;
    private long blockHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BlockHeight {
      get { return blockHeight_; }
      set {
        blockHeight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestSlot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestSlot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoundNumber != other.RoundNumber) return false;
      if (Order != other.Order) return false;
      if (BlockHeight != other.BlockHeight) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoundNumber != 0L) hash ^= RoundNumber.GetHashCode();
      if (Order != 0) hash ^= Order.GetHashCode();
      if (BlockHeight != 0L) hash ^= BlockHeight.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoundNumber != 0L) {
        output.WriteRawTag(8);
        output.WriteSInt64(RoundNumber);
      }
      if (Order != 0) {
        output.WriteRawTag(16);
        output.WriteSInt32(Order);
      }
      if (BlockHeight != 0L) {
        output.WriteRawTag(24);
        output.WriteSInt64(BlockHeight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoundNumber != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(RoundNumber);
      }
      if (Order != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Order);
      }
      if (BlockHeight != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(BlockHeight);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestSlot other) {
      if (other == null) {
        return;
      }
      if (other.RoundNumber != 0L) {
        RoundNumber = other.RoundNumber;
      }
      if (other.Order != 0) {
        Order = other.Order;
      }
      if (other.BlockHeight != 0L) {
        BlockHeight = other.BlockHeight;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RoundNumber = input.ReadSInt64();
            break;
          }
          case 16: {
            Order = input.ReadSInt32();
            break;
          }
          case 24: {
            BlockHeight = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
