// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bingo_game_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.BingoGameContract {

  /// <summary>Holder for reflection information generated from bingo_game_contract.proto</summary>
  internal static partial class BingoGameContractReflection {

    #region Descriptor
    /// <summary>File descriptor for bingo_game_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BingoGameContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChliaW5nb19nYW1lX2NvbnRyYWN0LnByb3RvGg9hZWxmL2NvcmUucHJvdG8a",
            "EmFlbGYvb3B0aW9ucy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
            "b3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aH2dvb2dsZS9w",
            "cm90b2J1Zi90aW1lc3RhbXAucHJvdG8igQEKEVBsYXllckluZm9ybWF0aW9u",
            "EhgKBHNlZWQYASABKAsyCi5hZWxmLkhhc2gSHwoFYm91dHMYAiADKAsyEC5C",
            "b3V0SW5mb3JtYXRpb24SMQoNcmVnaXN0ZXJfdGltZRgDIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXAimQEKD0JvdXRJbmZvcm1hdGlvbhIZChFw",
            "bGF5X2Jsb2NrX2hlaWdodBgBIAEoAxIOCgZhbW91bnQYAiABKAMSDQoFYXdh",
            "cmQYAyABKAMSEwoLaXNfY29tcGxldGUYBCABKAgSGwoHcGxheV9pZBgFIAEo",
            "CzIKLmFlbGYuSGFzaBIaChJiaW5nb19ibG9ja19oZWlnaHQYBiABKAMyvgMK",
            "EUJpbmdvR2FtZUNvbnRyYWN0EjwKCFJlZ2lzdGVyEhYuZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASQgoEUGxheRIb",
            "Lmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlGhsuZ29vZ2xlLnByb3RvYnVm",
            "LkludDY0VmFsdWUiABIxCgVCaW5nbxIKLmFlbGYuSGFzaBoaLmdvb2dsZS5w",
            "cm90b2J1Zi5Cb29sVmFsdWUiABI4CgRRdWl0EhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASOgoIR2V0QXdhcmQS",
            "Ci5hZWxmLkhhc2gaGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZSIFiIn3",
            "AQESQAoUR2V0UGxheWVySW5mb3JtYXRpb24SDS5hZWxmLkFkZHJlc3MaEi5Q",
            "bGF5ZXJJbmZvcm1hdGlvbiIFiIn3AQEaPLLM9gE3QUVsZi5Db250cmFjdHMu",
            "QmluZ29HYW1lQ29udHJhY3QuQmluZ29HYW1lQ29udHJhY3RTdGF0ZUIjqgIg",
            "QUVsZi5Db250cmFjdHMuQmluZ29HYW1lQ29udHJhY3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.BingoGameContract.PlayerInformation), global::AElf.Contracts.BingoGameContract.PlayerInformation.Parser, new[]{ "Seed", "Bouts", "RegisterTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.BingoGameContract.BoutInformation), global::AElf.Contracts.BingoGameContract.BoutInformation.Parser, new[]{ "PlayBlockHeight", "Amount", "Award", "IsComplete", "PlayId", "BingoBlockHeight" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class PlayerInformation : pb::IMessage<PlayerInformation> {
    private static readonly pb::MessageParser<PlayerInformation> _parser = new pb::MessageParser<PlayerInformation>(() => new PlayerInformation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerInformation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.BingoGameContract.BingoGameContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInformation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInformation(PlayerInformation other) : this() {
      seed_ = other.seed_ != null ? other.seed_.Clone() : null;
      bouts_ = other.bouts_.Clone();
      registerTime_ = other.registerTime_ != null ? other.registerTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerInformation Clone() {
      return new PlayerInformation(this);
    }

    /// <summary>Field number for the "seed" field.</summary>
    public const int SeedFieldNumber = 1;
    private global::AElf.Types.Hash seed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash Seed {
      get { return seed_; }
      set {
        seed_ = value;
      }
    }

    /// <summary>Field number for the "bouts" field.</summary>
    public const int BoutsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AElf.Contracts.BingoGameContract.BoutInformation> _repeated_bouts_codec
        = pb::FieldCodec.ForMessage(18, global::AElf.Contracts.BingoGameContract.BoutInformation.Parser);
    private readonly pbc::RepeatedField<global::AElf.Contracts.BingoGameContract.BoutInformation> bouts_ = new pbc::RepeatedField<global::AElf.Contracts.BingoGameContract.BoutInformation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AElf.Contracts.BingoGameContract.BoutInformation> Bouts {
      get { return bouts_; }
    }

    /// <summary>Field number for the "register_time" field.</summary>
    public const int RegisterTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp registerTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp RegisterTime {
      get { return registerTime_; }
      set {
        registerTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerInformation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerInformation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Seed, other.Seed)) return false;
      if(!bouts_.Equals(other.bouts_)) return false;
      if (!object.Equals(RegisterTime, other.RegisterTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (seed_ != null) hash ^= Seed.GetHashCode();
      hash ^= bouts_.GetHashCode();
      if (registerTime_ != null) hash ^= RegisterTime.GetHashCode();
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
      if (seed_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Seed);
      }
      bouts_.WriteTo(output, _repeated_bouts_codec);
      if (registerTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RegisterTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (seed_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Seed);
      }
      size += bouts_.CalculateSize(_repeated_bouts_codec);
      if (registerTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegisterTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerInformation other) {
      if (other == null) {
        return;
      }
      if (other.seed_ != null) {
        if (seed_ == null) {
          Seed = new global::AElf.Types.Hash();
        }
        Seed.MergeFrom(other.Seed);
      }
      bouts_.Add(other.bouts_);
      if (other.registerTime_ != null) {
        if (registerTime_ == null) {
          RegisterTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        RegisterTime.MergeFrom(other.RegisterTime);
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
            if (seed_ == null) {
              Seed = new global::AElf.Types.Hash();
            }
            input.ReadMessage(Seed);
            break;
          }
          case 18: {
            bouts_.AddEntriesFrom(input, _repeated_bouts_codec);
            break;
          }
          case 26: {
            if (registerTime_ == null) {
              RegisterTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(RegisterTime);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class BoutInformation : pb::IMessage<BoutInformation> {
    private static readonly pb::MessageParser<BoutInformation> _parser = new pb::MessageParser<BoutInformation>(() => new BoutInformation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoutInformation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.BingoGameContract.BingoGameContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoutInformation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoutInformation(BoutInformation other) : this() {
      playBlockHeight_ = other.playBlockHeight_;
      amount_ = other.amount_;
      award_ = other.award_;
      isComplete_ = other.isComplete_;
      playId_ = other.playId_ != null ? other.playId_.Clone() : null;
      bingoBlockHeight_ = other.bingoBlockHeight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoutInformation Clone() {
      return new BoutInformation(this);
    }

    /// <summary>Field number for the "play_block_height" field.</summary>
    public const int PlayBlockHeightFieldNumber = 1;
    private long playBlockHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PlayBlockHeight {
      get { return playBlockHeight_; }
      set {
        playBlockHeight_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "award" field.</summary>
    public const int AwardFieldNumber = 3;
    private long award_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Award {
      get { return award_; }
      set {
        award_ = value;
      }
    }

    /// <summary>Field number for the "is_complete" field.</summary>
    public const int IsCompleteFieldNumber = 4;
    private bool isComplete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsComplete {
      get { return isComplete_; }
      set {
        isComplete_ = value;
      }
    }

    /// <summary>Field number for the "play_id" field.</summary>
    public const int PlayIdFieldNumber = 5;
    private global::AElf.Types.Hash playId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash PlayId {
      get { return playId_; }
      set {
        playId_ = value;
      }
    }

    /// <summary>Field number for the "bingo_block_height" field.</summary>
    public const int BingoBlockHeightFieldNumber = 6;
    private long bingoBlockHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BingoBlockHeight {
      get { return bingoBlockHeight_; }
      set {
        bingoBlockHeight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoutInformation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoutInformation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayBlockHeight != other.PlayBlockHeight) return false;
      if (Amount != other.Amount) return false;
      if (Award != other.Award) return false;
      if (IsComplete != other.IsComplete) return false;
      if (!object.Equals(PlayId, other.PlayId)) return false;
      if (BingoBlockHeight != other.BingoBlockHeight) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayBlockHeight != 0L) hash ^= PlayBlockHeight.GetHashCode();
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (Award != 0L) hash ^= Award.GetHashCode();
      if (IsComplete != false) hash ^= IsComplete.GetHashCode();
      if (playId_ != null) hash ^= PlayId.GetHashCode();
      if (BingoBlockHeight != 0L) hash ^= BingoBlockHeight.GetHashCode();
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
      if (PlayBlockHeight != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(PlayBlockHeight);
      }
      if (Amount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Amount);
      }
      if (Award != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Award);
      }
      if (IsComplete != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsComplete);
      }
      if (playId_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PlayId);
      }
      if (BingoBlockHeight != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(BingoBlockHeight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayBlockHeight != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PlayBlockHeight);
      }
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Amount);
      }
      if (Award != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Award);
      }
      if (IsComplete != false) {
        size += 1 + 1;
      }
      if (playId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayId);
      }
      if (BingoBlockHeight != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BingoBlockHeight);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoutInformation other) {
      if (other == null) {
        return;
      }
      if (other.PlayBlockHeight != 0L) {
        PlayBlockHeight = other.PlayBlockHeight;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      if (other.Award != 0L) {
        Award = other.Award;
      }
      if (other.IsComplete != false) {
        IsComplete = other.IsComplete;
      }
      if (other.playId_ != null) {
        if (playId_ == null) {
          PlayId = new global::AElf.Types.Hash();
        }
        PlayId.MergeFrom(other.PlayId);
      }
      if (other.BingoBlockHeight != 0L) {
        BingoBlockHeight = other.BingoBlockHeight;
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
          case 8: {
            PlayBlockHeight = input.ReadInt64();
            break;
          }
          case 16: {
            Amount = input.ReadInt64();
            break;
          }
          case 24: {
            Award = input.ReadInt64();
            break;
          }
          case 32: {
            IsComplete = input.ReadBool();
            break;
          }
          case 42: {
            if (playId_ == null) {
              PlayId = new global::AElf.Types.Hash();
            }
            input.ReadMessage(PlayId);
            break;
          }
          case 48: {
            BingoBlockHeight = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
