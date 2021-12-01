// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: token_holder_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.TokenHolder {

  #region Events
  #endregion
  internal static partial class TokenHolderContractContainer
  {
    static readonly string __ServiceName = "TokenHolder.TokenHolderContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput> __Marshaller_TokenHolder_CreateTokenHolderProfitSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput> __Marshaller_TokenHolder_AddTokenHolderBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput> __Marshaller_TokenHolder_RemoveTokenHolderBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ContributeProfitsInput> __Marshaller_TokenHolder_ContributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ContributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.DistributeProfitsInput> __Marshaller_TokenHolder_DistributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.DistributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput> __Marshaller_TokenHolder_RegisterForProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.RegisterForProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ClaimProfitsInput> __Marshaller_TokenHolder_ClaimProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ClaimProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme> __Marshaller_TokenHolder_TokenHolderProfitScheme = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.TokenHolder.ReceivedProfitsMap> __Marshaller_TokenHolder_ReceivedProfitsMap = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.TokenHolder.ReceivedProfitsMap.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateScheme = new aelf::Method<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateScheme",
        __Marshaller_TokenHolder_CreateTokenHolderProfitSchemeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddBeneficiary = new aelf::Method<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddBeneficiary",
        __Marshaller_TokenHolder_AddTokenHolderBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveBeneficiary = new aelf::Method<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveBeneficiary",
        __Marshaller_TokenHolder_RemoveTokenHolderBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ContributeProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ContributeProfits",
        __Marshaller_TokenHolder_ContributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DistributeProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DistributeProfits",
        __Marshaller_TokenHolder_DistributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RegisterForProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RegisterForProfits",
        __Marshaller_TokenHolder_RegisterForProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Withdraw = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Withdraw",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ClaimProfits = new aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ClaimProfits",
        __Marshaller_TokenHolder_ClaimProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme> __Method_GetScheme = new aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme>(
        aelf::MethodType.View,
        __ServiceName,
        "GetScheme",
        __Marshaller_aelf_Address,
        __Marshaller_TokenHolder_TokenHolderProfitScheme);

    static readonly aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::AElf.Contracts.TokenHolder.ReceivedProfitsMap> __Method_GetProfitsMap = new aelf::Method<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::AElf.Contracts.TokenHolder.ReceivedProfitsMap>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitsMap",
        __Marshaller_TokenHolder_ClaimProfitsInput,
        __Marshaller_TokenHolder_ReceivedProfitsMap);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.TokenHolder.TokenHolderContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.TokenHolder.TokenHolderContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class TokenHolderContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.CreateTokenHolderProfitSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> CreateScheme
      {
        get { return __factory.Create(__Method_CreateScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.AddTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> AddBeneficiary
      {
        get { return __factory.Create(__Method_AddBeneficiary); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.RemoveTokenHolderBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> RemoveBeneficiary
      {
        get { return __factory.Create(__Method_RemoveBeneficiary); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> ContributeProfits
      {
        get { return __factory.Create(__Method_ContributeProfits); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> DistributeProfits
      {
        get { return __factory.Create(__Method_DistributeProfits); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.RegisterForProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> RegisterForProfits
      {
        get { return __factory.Create(__Method_RegisterForProfits); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> Withdraw
      {
        get { return __factory.Create(__Method_Withdraw); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> ClaimProfits
      {
        get { return __factory.Create(__Method_ClaimProfits); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Contracts.TokenHolder.TokenHolderProfitScheme> GetScheme
      {
        get { return __factory.Create(__Method_GetScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.TokenHolder.ClaimProfitsInput, global::AElf.Contracts.TokenHolder.ReceivedProfitsMap> GetProfitsMap
      {
        get { return __factory.Create(__Method_GetProfitsMap); }
      }

    }
  }
}
#endregion

