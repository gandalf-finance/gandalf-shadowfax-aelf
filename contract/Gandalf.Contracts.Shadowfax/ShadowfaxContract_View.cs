using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace Gandalf.Contracts.Shadowfax
{
    public partial class ShadowfaxContract
    {
        public override Address GetOwner(Empty input)
        {
            return State.Owner.Value;
        }

        public override ResetTimeSpanOutput GetTimespan(Empty input)
        {
            return new ResetTimeSpanOutput
            {
                MaxTimespan = State.MaximalTimeSpan.Value,
                MinTimespan = State.MinimalTimespan.Value
            };
        }

        public override PublicOfferingOutput GetPublicOffering(Int64Value input)
        {
            var offering = State.PublicOfferingMap[input.Value];
            if (offering == null)
            {
                return new PublicOfferingOutput();
            }

            return new PublicOfferingOutput
            {
                Claimed = offering.Claimed,
                Publisher = offering.Publisher,
                EndTime = offering.EndTime,
                StartTime = offering.StartTime,
                PublicId = input.Value,
                OfferingTokenAmount = offering.OfferingTokenAmount,
                OfferingTokenSymbol = offering.OfferingTokenSymbol,
                SubscribedOfferingAmount = offering.SubscribedOfferingAmount,
                WantTokenAmount = offering.WantTokenAmount,
                WantTokenSymbol = offering.WantTokenSymbol,
                WantTokenBalance = offering.WantTokenBalance
            };
        }

        public override UserInfo GetUserInfo(UserInfoInput input)
        {
            var userInfo = State.UserInfo[input.PublicId][input.User];
            if (userInfo != null)
            {
                return userInfo;
            }

            return new UserInfo
            {
                Claimed = false,
                ObtainAmount = 0
            };
        }

        public override Int64Value GetPublicOfferingLength(Empty input)
        {
            return new Int64Value
            {
                Value = State.CurrentPublicOfferingId.Value
            };
        }

        public override Address GetTokenOwnership(StringValue input)
        {
            return State.Ascription[input.Value];
        }
    }
}