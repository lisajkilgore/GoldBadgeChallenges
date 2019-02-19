using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ClaimRepository
    {
        Queue<Claim> _queueOfClaim = new Queue<Claim>();

        public Queue<Claim> GetClaimQueue()
        {
            return _queueOfClaim;
        }

        public void EnqueueClaim(Claim claim)
        {
            _queueOfClaim.Enqueue(claim);
        }

        public void DequeueClaim(Claim claim)
        {
            _queueOfClaim.Dequeue();
        }
    }
}
