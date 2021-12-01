// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs0.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS0 {

  #region Events
  internal partial class ContractProposed : aelf::IEvent<ContractProposed>
  {
    public global::System.Collections.Generic.IEnumerable<ContractProposed> GetIndexed()
    {
      return new List<ContractProposed>
      {
      };
    }

    public ContractProposed GetNonIndexed()
    {
      return new ContractProposed
      {
        ProposedContractInputHash = ProposedContractInputHash,
      };
    }
  }

  internal partial class ContractDeployed : aelf::IEvent<ContractDeployed>
  {
    public global::System.Collections.Generic.IEnumerable<ContractDeployed> GetIndexed()
    {
      return new List<ContractDeployed>
      {
      new ContractDeployed
      {
        Author = Author
      },
      new ContractDeployed
      {
        CodeHash = CodeHash
      },
      };
    }

    public ContractDeployed GetNonIndexed()
    {
      return new ContractDeployed
      {
        Address = Address,
        Version = Version,
        Name = Name,
      };
    }
  }

  internal partial class CodeCheckRequired : aelf::IEvent<CodeCheckRequired>
  {
    public global::System.Collections.Generic.IEnumerable<CodeCheckRequired> GetIndexed()
    {
      return new List<CodeCheckRequired>
      {
      };
    }

    public CodeCheckRequired GetNonIndexed()
    {
      return new CodeCheckRequired
      {
        Code = Code,
        ProposedContractInputHash = ProposedContractInputHash,
        Category = Category,
        IsSystemContract = IsSystemContract,
      };
    }
  }

  internal partial class CodeUpdated : aelf::IEvent<CodeUpdated>
  {
    public global::System.Collections.Generic.IEnumerable<CodeUpdated> GetIndexed()
    {
      return new List<CodeUpdated>
      {
      new CodeUpdated
      {
        Address = Address
      },
      };
    }

    public CodeUpdated GetNonIndexed()
    {
      return new CodeUpdated
      {
        OldCodeHash = OldCodeHash,
        NewCodeHash = NewCodeHash,
        Version = Version,
      };
    }
  }

  internal partial class AuthorChanged : aelf::IEvent<AuthorChanged>
  {
    public global::System.Collections.Generic.IEnumerable<AuthorChanged> GetIndexed()
    {
      return new List<AuthorChanged>
      {
      new AuthorChanged
      {
        Address = Address
      },
      };
    }

    public AuthorChanged GetNonIndexed()
    {
      return new AuthorChanged
      {
        OldAuthor = OldAuthor,
        NewAuthor = NewAuthor,
      };
    }
  }

  #endregion
  internal static partial class ACS0Container
  {
    static readonly string __ServiceName = "acs0.ACS0";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.SystemContractDeploymentInput> __Marshaller_acs0_SystemContractDeploymentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.SystemContractDeploymentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ContractDeploymentInput> __Marshaller_acs0_ContractDeploymentInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ContractDeploymentInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ContractUpdateInput> __Marshaller_acs0_ContractUpdateInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ContractUpdateInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ContractCodeCheckInput> __Marshaller_acs0_ContractCodeCheckInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ContractCodeCheckInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ReleaseContractInput> __Marshaller_acs0_ReleaseContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ReleaseContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ValidateSystemContractAddressInput> __Marshaller_acs0_ValidateSystemContractAddressInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ValidateSystemContractAddressInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS0.ContractInfo> __Marshaller_acs0_ContractInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS0.ContractInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.SmartContractRegistration> __Marshaller_aelf_SmartContractRegistration = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.SmartContractRegistration.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS0.SystemContractDeploymentInput, global::AElf.Types.Address> __Method_DeploySystemSmartContract = new aelf::Method<global::AElf.Standards.ACS0.SystemContractDeploymentInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeploySystemSmartContract",
        __Marshaller_acs0_SystemContractDeploymentInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Address> __Method_DeploySmartContract = new aelf::Method<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "DeploySmartContract",
        __Marshaller_acs0_ContractDeploymentInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Address> __Method_UpdateSmartContract = new aelf::Method<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateSmartContract",
        __Marshaller_acs0_ContractUpdateInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Hash> __Method_ProposeNewContract = new aelf::Method<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeNewContract",
        __Marshaller_acs0_ContractDeploymentInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ContractCodeCheckInput, global::AElf.Types.Hash> __Method_ProposeContractCodeCheck = new aelf::Method<global::AElf.Standards.ACS0.ContractCodeCheckInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeContractCodeCheck",
        __Marshaller_acs0_ContractCodeCheckInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Hash> __Method_ProposeUpdateContract = new aelf::Method<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "ProposeUpdateContract",
        __Marshaller_acs0_ContractUpdateInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseApprovedContract = new aelf::Method<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseApprovedContract",
        __Marshaller_acs0_ReleaseContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ReleaseCodeCheckedContract = new aelf::Method<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ReleaseCodeCheckedContract",
        __Marshaller_acs0_ReleaseContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Standards.ACS0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ValidateSystemContractAddress = new aelf::Method<global::AElf.Standards.ACS0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ValidateSystemContractAddress",
        __Marshaller_acs0_ValidateSystemContractAddressInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetContractProposerRequiredState = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetContractProposerRequiredState",
        __Marshaller_google_protobuf_BoolValue,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_CurrentContractSerialNumber = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "CurrentContractSerialNumber",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Standards.ACS0.ContractInfo> __Method_GetContractInfo = new aelf::Method<global::AElf.Types.Address, global::AElf.Standards.ACS0.ContractInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractInfo",
        __Marshaller_aelf_Address,
        __Marshaller_acs0_ContractInfo);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.Address> __Method_GetContractAuthor = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractAuthor",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.Hash> __Method_GetContractHash = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.Hash>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractHash",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address> __Method_GetContractAddressByName = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractAddressByName",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration> __Method_GetSmartContractRegistrationByAddress = new aelf::Method<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSmartContractRegistrationByAddress",
        __Marshaller_aelf_Address,
        __Marshaller_aelf_SmartContractRegistration);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration> __Method_GetSmartContractRegistrationByCodeHash = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSmartContractRegistrationByCodeHash",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_SmartContractRegistration);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Standards.ACS0.Acs0Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS0.Acs0Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ACS0Stub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Standards.ACS0.SystemContractDeploymentInput, global::AElf.Types.Address> DeploySystemSmartContract
      {
        get { return __factory.Create(__Method_DeploySystemSmartContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Address> DeploySmartContract
      {
        get { return __factory.Create(__Method_DeploySmartContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Address> UpdateSmartContract
      {
        get { return __factory.Create(__Method_UpdateSmartContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ContractDeploymentInput, global::AElf.Types.Hash> ProposeNewContract
      {
        get { return __factory.Create(__Method_ProposeNewContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ContractCodeCheckInput, global::AElf.Types.Hash> ProposeContractCodeCheck
      {
        get { return __factory.Create(__Method_ProposeContractCodeCheck); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ContractUpdateInput, global::AElf.Types.Hash> ProposeUpdateContract
      {
        get { return __factory.Create(__Method_ProposeUpdateContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseApprovedContract
      {
        get { return __factory.Create(__Method_ReleaseApprovedContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ReleaseContractInput, global::Google.Protobuf.WellKnownTypes.Empty> ReleaseCodeCheckedContract
      {
        get { return __factory.Create(__Method_ReleaseCodeCheckedContract); }
      }

      public aelf::IMethodStub<global::AElf.Standards.ACS0.ValidateSystemContractAddressInput, global::Google.Protobuf.WellKnownTypes.Empty> ValidateSystemContractAddress
      {
        get { return __factory.Create(__Method_ValidateSystemContractAddress); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BoolValue, global::Google.Protobuf.WellKnownTypes.Empty> SetContractProposerRequiredState
      {
        get { return __factory.Create(__Method_SetContractProposerRequiredState); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> CurrentContractSerialNumber
      {
        get { return __factory.Create(__Method_CurrentContractSerialNumber); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Standards.ACS0.ContractInfo> GetContractInfo
      {
        get { return __factory.Create(__Method_GetContractInfo); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Types.Address> GetContractAuthor
      {
        get { return __factory.Create(__Method_GetContractAuthor); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Types.Hash> GetContractHash
      {
        get { return __factory.Create(__Method_GetContractHash); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::AElf.Types.Address> GetContractAddressByName
      {
        get { return __factory.Create(__Method_GetContractAddressByName); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Types.SmartContractRegistration> GetSmartContractRegistrationByAddress
      {
        get { return __factory.Create(__Method_GetSmartContractRegistrationByAddress); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::AElf.Types.SmartContractRegistration> GetSmartContractRegistrationByCodeHash
      {
        get { return __factory.Create(__Method_GetSmartContractRegistrationByCodeHash); }
      }

    }
  }
}
#endregion

