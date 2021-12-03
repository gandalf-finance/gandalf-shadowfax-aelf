using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace Gandalf.Contracts.IdoContract
{
    public partial class IdoContract
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


        public override PublicOfferingOutput GetPublicOffering(Int32Value input)
        {
            var offering = State.PublicOfferList.Value.Value[input.Value];
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
                WantTokenAmount = offering.OfferingTokenAmount,
                WantTokenSymbol = offering.WantTokenSymbol,
                WantTokenBalance = offering.WantTokenBalance
            };
        }
    }
    
}