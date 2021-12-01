// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs10.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS10 {

  #region Events
  internal partial class DonationReceived : aelf::IEvent<DonationReceived>
  {
    public global::System.Collections.Generic.IEnumerable<DonationReceived> GetIndexed()
    {
      return new List<DonationReceived>
      {
      };
    }

    public DonationReceived GetNonIndexed()
    {
      return new DonationReceived
      {
        From = From,
        PoolContract = PoolContract,
        Symbol = Symbol,
        Amount = Amount,
      };
    }
  }

  #endregion
  internal static partial class DividendPoolContractContainer
  {
    static readonly string __ServiceName = "acs10.DividendPoolContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS10.DonateInput> __Marshaller_acs10_DonateInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS10.DonateInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS10.ReleaseInput> __Marshaller_acs10_ReleaseInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS10.ReleaseInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS10.SymbolList> __Marshaller_acs10_SymbolList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS10.SymbolList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS10.Dividends> __Marshaller_acs10_Dividends = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS10.Dividends.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS10.DonateInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Donate = new aelf::Method<global::AElf.Standards.ACS10.DonateInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Donate",
        __Marshaller_acs10_DonateInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS10.ReleaseInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Release = new aelf::Method<global::AElf.Standards.ACS10.ReleaseInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Release",
        __Marshaller_acs10_ReleaseInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS10.SymbolList, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetSymbolList = new aelf::Method<global::AElf.Standards.ACS10.SymbolList, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetSymbolList",
        __Marshaller_acs10_SymbolList,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.SymbolList> __Method_GetSymbolList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.SymbolList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSymbolList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs10_SymbolList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.Dividends> __Method_GetUndistributedDividends = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.Dividends>(
        aelf::MethodType.View,
        __ServiceName,
        "GetUndistributedDividends",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs10_Dividends);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS10.Dividends> __Method_GetDividends = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS10.Dividends>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDividends",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_acs10_Dividends);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS10.Acs10Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS10.Acs10Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class DividendPoolContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Standards.ACS10.DonateInput, global::Google.Protobuf.WellKnownTypes.Empty> Donate
      {
        get { return __factory.Create(__Method_Donate); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS10.ReleaseInput, global::Google.Protobuf.WellKnownTypes.Empty> Release
      {
        get { return __factory.Create(__Method_Release); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS10.SymbolList, global::Google.Protobuf.WellKnownTypes.Empty> SetSymbolList
      {
        get { return __factory.Create(__Method_SetSymbolList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.SymbolList> GetSymbolList
      {
        get { return __factory.Create(__Method_GetSymbolList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS10.Dividends> GetUndistributedDividends
      {
        get { return __factory.Create(__Method_GetUndistributedDividends); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int64Value, global::AElf.Standards.ACS10.Dividends> GetDividends
      {
        get { return __factory.Create(__Method_GetDividends); }
      }

    }
  }
}
#endregion

