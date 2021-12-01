// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hello_world_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.HelloWorldContract {

  /// <summary>Holder for reflection information generated from hello_world_contract.proto</summary>
  public static partial class HelloWorldContractReflection {

    #region Descriptor
    /// <summary>File descriptor for hello_world_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HelloWorldContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpoZWxsb193b3JsZF9jb250cmFjdC5wcm90bxoPYWVsZi9jb3JlLnByb3Rv",
            "GhJhZWxmL29wdGlvbnMucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5w",
            "cm90byIcCgtIZWxsb1JldHVybhINCgVWYWx1ZRgBIAEoCTKFAQoSSGVsbG9X",
            "b3JsZENvbnRyYWN0Ei8KBUhlbGxvEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "GgwuSGVsbG9SZXR1cm4iABo+ssz2ATlBRWxmLkNvbnRyYWN0cy5IZWxsb1dv",
            "cmxkQ29udHJhY3QuSGVsbG9Xb3JsZENvbnRyYWN0U3RhdGVCJKoCIUFFbGYu",
            "Q29udHJhY3RzLkhlbGxvV29ybGRDb250cmFjdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.HelloWorldContract.HelloReturn), global::AElf.Contracts.HelloWorldContract.HelloReturn.Parser, new[]{ "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// a custom message, used as the return type of the Hello action
  /// </summary>
  public sealed partial class HelloReturn : pb::IMessage<HelloReturn> {
    private static readonly pb::MessageParser<HelloReturn> _parser = new pb::MessageParser<HelloReturn>(() => new HelloReturn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HelloReturn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.HelloWorldContract.HelloWorldContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReturn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReturn(HelloReturn other) : this() {
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HelloReturn Clone() {
      return new HelloReturn(this);
    }

    /// <summary>Field number for the "Value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HelloReturn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HelloReturn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HelloReturn other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
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
          case 10: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
