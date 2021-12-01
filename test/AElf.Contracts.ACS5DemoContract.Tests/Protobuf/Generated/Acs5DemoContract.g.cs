// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs5_demo_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.ACS5DemoContract {

  /// <summary>Holder for reflection information generated from acs5_demo_contract.proto</summary>
  internal static partial class Acs5DemoContractReflection {

    #region Descriptor
    /// <summary>File descriptor for acs5_demo_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Acs5DemoContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhhY3M1X2RlbW9fY29udHJhY3QucHJvdG8aCmFjczUucHJvdG8aEmFlbGYv",
            "b3B0aW9ucy5wcm90bxoPYWVsZi9jb3JlLnByb3RvGhtnb29nbGUvcHJvdG9i",
            "dWYvZW1wdHkucHJvdG8iLwoPSW5pdGlhbGl6ZUlucHV0EhwKBWFkbWluGAEg",
            "ASgLMg0uYWVsZi5BZGRyZXNzMtABChBBQ1M1RGVtb0NvbnRyYWN0EjgKCklu",
            "aXRpYWxpemUSEC5Jbml0aWFsaXplSW5wdXQaFi5nb29nbGUucHJvdG9idWYu",
            "RW1wdHkiABI3CgNGb28SFi5nb29nbGUucHJvdG9idWYuRW1wdHkaFi5nb29n",
            "bGUucHJvdG9idWYuRW1wdHkiABpJssz2ATVBRWxmLkNvbnRyYWN0cy5BQ1M1",
            "RGVtb0NvbnRyYWN0LkFDUzVEZW1vQ29udHJhY3RTdGF0ZcrK9gEKYWNzNS5w",
            "cm90b0IiqgIfQUVsZi5Db250cmFjdHMuQUNTNURlbW9Db250cmFjdGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Standards.ACS5.Acs5Reflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::AElf.Types.CoreReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.ACS5DemoContract.InitializeInput), global::AElf.Contracts.ACS5DemoContract.InitializeInput.Parser, new[]{ "Admin" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class InitializeInput : pb::IMessage<InitializeInput> {
    private static readonly pb::MessageParser<InitializeInput> _parser = new pb::MessageParser<InitializeInput>(() => new InitializeInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializeInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.ACS5DemoContract.Acs5DemoContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput(InitializeInput other) : this() {
      admin_ = other.admin_ != null ? other.admin_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput Clone() {
      return new InitializeInput(this);
    }

    /// <summary>Field number for the "admin" field.</summary>
    public const int AdminFieldNumber = 1;
    private global::AElf.Types.Address admin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address Admin {
      get { return admin_; }
      set {
        admin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializeInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializeInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Admin, other.Admin)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (admin_ != null) hash ^= Admin.GetHashCode();
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
      if (admin_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Admin);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (admin_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Admin);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializeInput other) {
      if (other == null) {
        return;
      }
      if (other.admin_ != null) {
        if (admin_ == null) {
          Admin = new global::AElf.Types.Address();
        }
        Admin.MergeFrom(other.Admin);
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
            if (admin_ == null) {
              Admin = new global::AElf.Types.Address();
            }
            input.ReadMessage(Admin);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
