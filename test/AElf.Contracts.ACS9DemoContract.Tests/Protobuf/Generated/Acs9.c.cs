// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs9.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS9 {

  #region Events
  #endregion
  internal static partial class ContractProfitsContractContainer
  {
    static readonly string __ServiceName = "acs9.ContractProfitsContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS9.TakeContractProfitsInput> __Marshaller_acs9_TakeContractProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS9.TakeContractProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS9.ProfitConfig> __Marshaller_acs9_ProfitConfig = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS9.ProfitConfig.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS9.ProfitsMap> __Marshaller_acs9_ProfitsMap = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS9.ProfitsMap.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS9.TakeContractProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_TakeContractProfits = new aelf::Method<global::AElf.Standards.ACS9.TakeContractProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "TakeContractProfits",
        __Marshaller_acs9_TakeContractProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitConfig> __Method_GetProfitConfig = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitConfig>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitConfig",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs9_ProfitConfig);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitsMap> __Method_GetProfitsAmount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitsMap>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitsAmount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs9_ProfitsMap);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS9.Acs9Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS9.Acs9Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ContractProfitsContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Standards.ACS9.TakeContractProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> TakeContractProfits
      {
        get { return __factory.Create(__Method_TakeContractProfits); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitConfig> GetProfitConfig
      {
        get { return __factory.Create(__Method_GetProfitConfig); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS9.ProfitsMap> GetProfitsAmount
      {
        get { return __factory.Create(__Method_GetProfitsAmount); }
      }

    }
  }
}
#endregion

