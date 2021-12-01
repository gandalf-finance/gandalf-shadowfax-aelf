// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs5_demo_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.ACS5DemoContract {

  #region Events
  #endregion
  public static partial class ACS5DemoContractContainer
  {
    static readonly string __ServiceName = "ACS5DemoContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Standards.ACS5.SetMethodCallingThresholdInput> __Marshaller_acs5_SetMethodCallingThresholdInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS5.SetMethodCallingThresholdInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS5.MethodCallingThreshold> __Marshaller_acs5_MethodCallingThreshold = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS5.MethodCallingThreshold.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.ACS5DemoContract.InitializeInput> __Marshaller_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.ACS5DemoContract.InitializeInput.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Standards.ACS5.SetMethodCallingThresholdInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMethodCallingThreshold = new aelf::Method<global::AElf.Standards.ACS5.SetMethodCallingThresholdInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMethodCallingThreshold",
        __Marshaller_acs5_SetMethodCallingThresholdInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Standards.ACS5.MethodCallingThreshold> __Method_GetMethodCallingThreshold = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Standards.ACS5.MethodCallingThreshold>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodCallingThreshold",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_acs5_MethodCallingThreshold);

    static readonly aelf::Method<global::AElf.Contracts.ACS5DemoContract.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Contracts.ACS5DemoContract.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Foo = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Foo",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.ACS5DemoContract.Acs5DemoContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS5.Acs5Reflection.Descriptor.Services[0],
          global::AElf.Contracts.ACS5DemoContract.Acs5DemoContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    /// <summary>Base class for the contract of ACS5DemoContract</summary>
    public abstract partial class ACS5DemoContractBase : AElf.Sdk.CSharp.CSharpSmartContract<AElf.Contracts.ACS5DemoContract.ACS5DemoContractState>
    {
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetMethodCallingThreshold(global::AElf.Standards.ACS5.SetMethodCallingThresholdInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Standards.ACS5.MethodCallingThreshold GetMethodCallingThreshold(global::Google.Protobuf.WellKnownTypes.StringValue input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Initialize(global::AElf.Contracts.ACS5DemoContract.InitializeInput input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Foo(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

    }

    public static aelf::ServerServiceDefinition BindService(ACS5DemoContractBase serviceImpl)
    {
      return aelf::ServerServiceDefinition.CreateBuilder()
          .AddDescriptors(Descriptors)
          .AddMethod(__Method_SetMethodCallingThreshold, serviceImpl.SetMethodCallingThreshold)
          .AddMethod(__Method_GetMethodCallingThreshold, serviceImpl.GetMethodCallingThreshold)
          .AddMethod(__Method_Initialize, serviceImpl.Initialize)
          .AddMethod(__Method_Foo, serviceImpl.Foo).Build();
    }

  }
}
#endregion

