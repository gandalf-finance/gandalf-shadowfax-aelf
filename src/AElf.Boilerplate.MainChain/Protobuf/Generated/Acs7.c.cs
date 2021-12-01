// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs7.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS7 {

  #region Events
  internal partial class SideChainBlockDataIndexed : aelf::IEvent<SideChainBlockDataIndexed>
  {
    public global::System.Collections.Generic.IEnumerable<SideChainBlockDataIndexed> GetIndexed()
    {
      return new List<SideChainBlockDataIndexed>
      {
      };
    }

    public SideChainBlockDataIndexed GetNonIndexed()
    {
      return new SideChainBlockDataIndexed
      {
      };
    }
  }

  internal partial class CrossChainIndexingDataProposedEvent : aelf::IEvent<CrossChainIndexingDataProposedEvent>
  {
    public global::System.Collections.Generic.IEnumerable<CrossChainIndexingDataProposedEvent> GetIndexed()
    {
      return new List<CrossChainIndexingDataProposedEvent>
      {
      };
    }

    public CrossChainIndexingDataProposedEvent GetNonIndexed()
    {
      return new CrossChainIndexingDataProposedEvent
      {
        ProposedCrossChainData = ProposedCrossChainData,
        ProposalId = ProposalId,
      };
    }
  }

  #endregion
  internal static partial class ACS7Container
  {
    static readonly string __ServiceName = "acs7.ACS7";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CrossChainBlockData> __Marshaller_acs7_CrossChainBlockData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CrossChainBlockData.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput> __Marshaller_acs7_ReleaseCrossChainIndexingProposalInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.SideChainCreationRequest> __Marshaller_acs7_SideChainCreationRequest = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.SideChainCreationRequest.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput> __Marshaller_acs7_ReleaseSideChainCreationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ReleaseSideChainCreationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CreateSideChainInput> __Marshaller_acs7_CreateSideChainInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CreateSideChainInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.RechargeInput> __Marshaller_acs7_RechargeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.RechargeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.AdjustIndexingFeeInput> __Marshaller_acs7_AdjustIndexingFeeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.AdjustIndexingFeeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.VerifyTransactionInput> __Marshaller_acs7_VerifyTransactionInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.VerifyTransactionInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Marshaller_acs7_ChainIdAndHeightDict = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ChainIdAndHeightDict.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.SideChainIndexingInformationList> __Marshaller_acs7_SideChainIndexingInformationList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.SideChainIndexingInformationList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.IndexedSideChainBlockData> __Marshaller_acs7_IndexedSideChainBlockData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.IndexedSideChainBlockData.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.CrossChainMerkleProofContext> __Marshaller_acs7_CrossChainMerkleProofContext = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.CrossChainMerkleProofContext.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS7.ChainInitializationData> __Marshaller_acs7_ChainInitializationData = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS7.ChainInitializationData.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ProposeCrossChainIndexing = new aelf::Method<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeCrossChainIndexing",
        __Marshaller_acs7_CrossChainBlockData,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseCrossChainIndexingProposal = new aelf::Method<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseCrossChainIndexingProposal",
        __Marshaller_acs7_ReleaseCrossChainIndexingProposalInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RequestSideChainCreation = new aelf::Method<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RequestSideChainCreation",
        __Marshaller_acs7_SideChainCreationRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseSideChainCreation = new aelf::Method<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseSideChainCreation",
        __Marshaller_acs7_ReleaseSideChainCreationInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_CreateSideChain = new aelf::Method<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateSideChain",
        __Marshaller_acs7_CreateSideChainInput,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Recharge = new aelf::Method<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Recharge",
        __Marshaller_acs7_RechargeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_DisposeSideChain = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "DisposeSideChain",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AdjustIndexingFeePrice = new aelf::Method<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AdjustIndexingFeePrice",
        __Marshaller_acs7_AdjustIndexingFeeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_VerifyTransaction = new aelf::Method<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "VerifyTransaction",
        __Marshaller_acs7_VerifyTransactionInput,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Method_GetSideChainIdAndHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIdAndHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_ChainIdAndHeightDict);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList> __Method_GetSideChainIndexingInformationList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingInformationList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_SideChainIndexingInformationList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> __Method_GetAllChainsIdAndHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict>(
        aelf::MethodType.View,
        __ServiceName,
        "GetAllChainsIdAndHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs7_ChainIdAndHeightDict);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData> __Method_GetIndexedSideChainBlockDataByHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData>(
        aelf::MethodType.View,
        __ServiceName,
        "GetIndexedSideChainBlockDataByHeight",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_acs7_IndexedSideChainBlockData);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext> __Method_GetBoundParentChainHeightAndMerklePathByHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext>(
        aelf::MethodType.View,
        __ServiceName,
        "GetBoundParentChainHeightAndMerklePathByHeight",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_acs7_CrossChainMerkleProofContext);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData> __Method_GetChainInitializationData = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData>(
        aelf::MethodType.View,
        __ServiceName,
        "GetChainInitializationData",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_acs7_ChainInitializationData);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS7.Acs7Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS7.Acs7Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ACS7Stub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Standards.ACS7.CrossChainBlockData, global::Google.Protobuf.WellKnownTypes.Empty> ProposeCrossChainIndexing
      {
        get { return __factory.Create(__Method_ProposeCrossChainIndexing); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.ReleaseCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseCrossChainIndexingProposal
      {
        get { return __factory.Create(__Method_ReleaseCrossChainIndexingProposal); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.SideChainCreationRequest, global::Google.Protobuf.WellKnownTypes.Empty> RequestSideChainCreation
      {
        get { return __factory.Create(__Method_RequestSideChainCreation); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.ReleaseSideChainCreationInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseSideChainCreation
      {
        get { return __factory.Create(__Method_ReleaseSideChainCreation); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.CreateSideChainInput, global::Google.Protobuf.WellKnownTypes.Int32Value> CreateSideChain
      {
        get { return __factory.Create(__Method_CreateSideChain); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.RechargeInput, global::Google.Protobuf.WellKnownTypes.Empty> Recharge
      {
        get { return __factory.Create(__Method_Recharge); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int32Value> DisposeSideChain
      {
        get { return __factory.Create(__Method_DisposeSideChain); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.AdjustIndexingFeeInput, global::Google.Protobuf.WellKnownTypes.Empty> AdjustIndexingFeePrice
      {
        get { return __factory.Create(__Method_AdjustIndexingFeePrice); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS7.VerifyTransactionInput, global::Google.Protobuf.WellKnownTypes.BoolValue> VerifyTransaction
      {
        get { return __factory.Create(__Method_VerifyTransaction); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> GetSideChainIdAndHeight
      {
        get { return __factory.Create(__Method_GetSideChainIdAndHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.SideChainIndexingInformationList> GetSideChainIndexingInformationList
      {
        get { return __factory.Create(__Method_GetSideChainIndexingInformationList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS7.ChainIdAndHeightDict> GetAllChainsIdAndHeight
      {
        get { return __factory.Create(__Method_GetAllChainsIdAndHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.IndexedSideChainBlockData> GetIndexedSideChainBlockDataByHeight
      {
        get { return __factory.Create(__Method_GetIndexedSideChainBlockDataByHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS7.CrossChainMerkleProofContext> GetBoundParentChainHeightAndMerklePathByHeight
      {
        get { return __factory.Create(__Method_GetBoundParentChainHeightAndMerklePathByHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Standards.ACS7.ChainInitializationData> GetChainInitializationData
      {
        get { return __factory.Create(__Method_GetChainInitializationData); }
      }

    }
  }
}
#endregion

