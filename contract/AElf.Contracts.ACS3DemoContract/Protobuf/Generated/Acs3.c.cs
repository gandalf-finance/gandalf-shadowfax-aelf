// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs3.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Standards.ACS3 {

  #region Events
  public partial class ProposalCreated : aelf::IEvent<ProposalCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalCreated> GetIndexed()
    {
      return new List<ProposalCreated>
      {
      new ProposalCreated
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ProposalCreated GetNonIndexed()
    {
      return new ProposalCreated
      {
        ProposalId = ProposalId,
      };
    }
  }

  public partial class ProposalReleased : aelf::IEvent<ProposalReleased>
  {
    public global::System.Collections.Generic.IEnumerable<ProposalReleased> GetIndexed()
    {
      return new List<ProposalReleased>
      {
      new ProposalReleased
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ProposalReleased GetNonIndexed()
    {
      return new ProposalReleased
      {
        ProposalId = ProposalId,
      };
    }
  }

  public partial class OrganizationCreated : aelf::IEvent<OrganizationCreated>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationCreated> GetIndexed()
    {
      return new List<OrganizationCreated>
      {
      };
    }

    public OrganizationCreated GetNonIndexed()
    {
      return new OrganizationCreated
      {
        OrganizationAddress = OrganizationAddress,
      };
    }
  }

  public partial class ReceiptCreated : aelf::IEvent<ReceiptCreated>
  {
    public global::System.Collections.Generic.IEnumerable<ReceiptCreated> GetIndexed()
    {
      return new List<ReceiptCreated>
      {
      new ReceiptCreated
      {
        OrganizationAddress = OrganizationAddress
      },
      };
    }

    public ReceiptCreated GetNonIndexed()
    {
      return new ReceiptCreated
      {
        ProposalId = ProposalId,
        Address = Address,
        ReceiptType = ReceiptType,
        Time = Time,
      };
    }
  }

  public partial class OrganizationWhiteListChanged : aelf::IEvent<OrganizationWhiteListChanged>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationWhiteListChanged> GetIndexed()
    {
      return new List<OrganizationWhiteListChanged>
      {
      };
    }

    public OrganizationWhiteListChanged GetNonIndexed()
    {
      return new OrganizationWhiteListChanged
      {
        OrganizationAddress = OrganizationAddress,
        ProposerWhiteList = ProposerWhiteList,
      };
    }
  }

  public partial class OrganizationThresholdChanged : aelf::IEvent<OrganizationThresholdChanged>
  {
    public global::System.Collections.Generic.IEnumerable<OrganizationThresholdChanged> GetIndexed()
    {
      return new List<OrganizationThresholdChanged>
      {
      };
    }

    public OrganizationThresholdChanged GetNonIndexed()
    {
      return new OrganizationThresholdChanged
      {
        OrganizationAddress = OrganizationAddress,
        ProposerReleaseThreshold = ProposerReleaseThreshold,
      };
    }
  }

  #endregion
}
#endregion

