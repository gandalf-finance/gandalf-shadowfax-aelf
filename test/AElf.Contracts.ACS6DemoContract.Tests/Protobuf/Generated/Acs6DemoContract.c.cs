// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs6_demo_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.ACS6DemoContract {

  #region Events
  #endregion
  internal static partial class ACS6DemoContractContainer
  {
    static readonly string __ServiceName = "ACS6DemoContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BytesValue> __Marshaller_google_protobuf_BytesValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BytesValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> __Method_GetRandomBytes = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetRandomBytes",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_google_protobuf_BytesValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.ACS6DemoContract.Acs6DemoContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS6.Acs6Reflection.Descriptor.Services[0],
          global::AElf.Contracts.ACS6DemoContract.Acs6DemoContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ACS6DemoContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> GetRandomBytes
      {
        get { return __factory.Create(__Method_GetRandomBytes); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> Initialize
      {
        get { return __factory.Create(__Method_Initialize); }
      }

    }
  }
}
#endregion

