// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs2.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS2 {

  #region Events
  #endregion
  internal static partial class ACS2BaseContainer
  {
    static readonly string __ServiceName = "acs2.ACS2Base";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Types.Transaction> __Marshaller_aelf_Transaction = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Transaction.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS2.ResourceInfo> __Marshaller_acs2_ResourceInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS2.ResourceInfo.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Types.Transaction, global::AElf.Standards.ACS2.ResourceInfo> __Method_GetResourceInfo = new aelf::Method<global::AElf.Types.Transaction, global::AElf.Standards.ACS2.ResourceInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetResourceInfo",
        __Marshaller_aelf_Transaction,
        __Marshaller_acs2_ResourceInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS2.Acs2Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS2.Acs2Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ACS2BaseReferenceState : global::AElf.Sdk.CSharp.State.ContractReferenceState
    {
      internal global::AElf.Sdk.CSharp.State.MethodReference<global::AElf.Types.Transaction, global::AElf.Standards.ACS2.ResourceInfo> GetResourceInfo { get; set; }
    }
  }
}
#endregion

