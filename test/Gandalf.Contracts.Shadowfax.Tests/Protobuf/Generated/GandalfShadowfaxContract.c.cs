// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gandalf_shadowfax_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace Gandalf.Contracts.Shadowfax {

  #region Events
  internal partial class AddPublicOffering : aelf::IEvent<AddPublicOffering>
  {
    public global::System.Collections.Generic.IEnumerable<AddPublicOffering> GetIndexed()
    {
      return new List<AddPublicOffering>
      {
      };
    }

    public AddPublicOffering GetNonIndexed()
    {
      return new AddPublicOffering
      {
        OfferingTokenSymbol = OfferingTokenSymbol,
        OfferingTokenAmount = OfferingTokenAmount,
        WantTokenSymbol = WantTokenSymbol,
        WantTokenAmount = WantTokenAmount,
        Publisher = Publisher,
        StartTime = StartTime,
        EndTime = EndTime,
        PublicId = PublicId,
      };
    }
  }

  internal partial class ChangeAscription : aelf::IEvent<ChangeAscription>
  {
    public global::System.Collections.Generic.IEnumerable<ChangeAscription> GetIndexed()
    {
      return new List<ChangeAscription>
      {
      };
    }

    public ChangeAscription GetNonIndexed()
    {
      return new ChangeAscription
      {
        TokenSymbol = TokenSymbol,
        OldPublisher = OldPublisher,
        NewPublisher = NewPublisher,
      };
    }
  }

  internal partial class Withdraw : aelf::IEvent<Withdraw>
  {
    public global::System.Collections.Generic.IEnumerable<Withdraw> GetIndexed()
    {
      return new List<Withdraw>
      {
      };
    }

    public Withdraw GetNonIndexed()
    {
      return new Withdraw
      {
        PubilicId = PubilicId,
        To = To,
        WantToken = WantToken,
        OfferingToken = OfferingToken,
      };
    }
  }

  internal partial class Invest : aelf::IEvent<Invest>
  {
    public global::System.Collections.Generic.IEnumerable<Invest> GetIndexed()
    {
      return new List<Invest>
      {
      };
    }

    public Invest GetNonIndexed()
    {
      return new Invest
      {
        PublicId = PublicId,
        Investor = Investor,
        TokenSymbol = TokenSymbol,
        Income = Income,
        Spend = Spend,
        Channel = Channel,
      };
    }
  }

  internal partial class Harvest : aelf::IEvent<Harvest>
  {
    public global::System.Collections.Generic.IEnumerable<Harvest> GetIndexed()
    {
      return new List<Harvest>
      {
      };
    }

    public Harvest GetNonIndexed()
    {
      return new Harvest
      {
        PublicId = PublicId,
        To = To,
        Amount = Amount,
      };
    }
  }

  #endregion
  internal static partial class ShadowfaxContractContainer
  {
    static readonly string __ServiceName = "ShadowfaxContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.AddPublicOfferingInput> __Marshaller_AddPublicOfferingInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.AddPublicOfferingInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.ChangeAscriptionInput> __Marshaller_ChangeAscriptionInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.ChangeAscriptionInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.InvestInput> __Marshaller_InvestInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.InvestInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.ResetTimeSpanInput> __Marshaller_ResetTimeSpanInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.ResetTimeSpanInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.ResetTimeSpanOutput> __Marshaller_ResetTimeSpanOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.ResetTimeSpanOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.PublicOfferingOutput> __Marshaller_PublicOfferingOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.PublicOfferingOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.UserInfoInput> __Marshaller_UserInfoInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.UserInfoInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.UserInfo> __Marshaller_UserInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.UserInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Gandalf.Contracts.Shadowfax.Token> __Marshaller_Token = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gandalf.Contracts.Shadowfax.Token.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.AddPublicOfferingInput, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_AddPublicOffering = new aelf::Method<global::Gandalf.Contracts.Shadowfax.AddPublicOfferingInput, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddPublicOffering",
        __Marshaller_AddPublicOfferingInput,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.ChangeAscriptionInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeAscription = new aelf::Method<global::Gandalf.Contracts.Shadowfax.ChangeAscriptionInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeAscription",
        __Marshaller_ChangeAscriptionInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Withdraw = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Withdraw",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.InvestInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Invest = new aelf::Method<global::Gandalf.Contracts.Shadowfax.InvestInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Invest",
        __Marshaller_InvestInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Harvest = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Harvest",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.ResetTimeSpanInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ResetTimeSpan = new aelf::Method<global::Gandalf.Contracts.Shadowfax.ResetTimeSpanInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ResetTimeSpan",
        __Marshaller_ResetTimeSpanInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> __Method_GetOwner = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetOwner",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Gandalf.Contracts.Shadowfax.ResetTimeSpanOutput> __Method_GetTimespan = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Gandalf.Contracts.Shadowfax.ResetTimeSpanOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTimespan",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ResetTimeSpanOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Gandalf.Contracts.Shadowfax.PublicOfferingOutput> __Method_GetPublicOffering = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Gandalf.Contracts.Shadowfax.PublicOfferingOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPublicOffering",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_PublicOfferingOutput);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.UserInfoInput, global::Gandalf.Contracts.Shadowfax.UserInfo> __Method_GetUserInfo = new aelf::Method<global::Gandalf.Contracts.Shadowfax.UserInfoInput, global::Gandalf.Contracts.Shadowfax.UserInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetUserInfo",
        __Marshaller_UserInfoInput,
        __Marshaller_UserInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetPublicOfferingLength = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPublicOfferingLength",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::Gandalf.Contracts.Shadowfax.Token, global::AElf.Types.Address> __Method_GetTokenOwnership = new aelf::Method<global::Gandalf.Contracts.Shadowfax.Token, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTokenOwnership",
        __Marshaller_Token,
        __Marshaller_aelf_Address);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Gandalf.Contracts.Shadowfax.GandalfShadowfaxContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::Gandalf.Contracts.Shadowfax.GandalfShadowfaxContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ShadowfaxContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> Initialize
      {
        get { return __factory.Create(__Method_Initialize); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.AddPublicOfferingInput, global::Google.Protobuf.WellKnownTypes.Int64Value> AddPublicOffering
      {
        get { return __factory.Create(__Method_AddPublicOffering); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.ChangeAscriptionInput, global::Google.Protobuf.WellKnownTypes.Empty> ChangeAscription
      {
        get { return __factory.Create(__Method_ChangeAscription); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> Withdraw
      {
        get { return __factory.Create(__Method_Withdraw); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.InvestInput, global::Google.Protobuf.WellKnownTypes.Empty> Invest
      {
        get { return __factory.Create(__Method_Invest); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Empty> Harvest
      {
        get { return __factory.Create(__Method_Harvest); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.ResetTimeSpanInput, global::Google.Protobuf.WellKnownTypes.Empty> ResetTimeSpan
      {
        get { return __factory.Create(__Method_ResetTimeSpan); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> GetOwner
      {
        get { return __factory.Create(__Method_GetOwner); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Gandalf.Contracts.Shadowfax.ResetTimeSpanOutput> GetTimespan
      {
        get { return __factory.Create(__Method_GetTimespan); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Gandalf.Contracts.Shadowfax.PublicOfferingOutput> GetPublicOffering
      {
        get { return __factory.Create(__Method_GetPublicOffering); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.UserInfoInput, global::Gandalf.Contracts.Shadowfax.UserInfo> GetUserInfo
      {
        get { return __factory.Create(__Method_GetUserInfo); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> GetPublicOfferingLength
      {
        get { return __factory.Create(__Method_GetPublicOfferingLength); }
      }

      public aelf::IMethodStub<global::Gandalf.Contracts.Shadowfax.Token, global::AElf.Types.Address> GetTokenOwnership
      {
        get { return __factory.Create(__Method_GetTokenOwnership); }
      }

    }
  }
}
#endregion
