using QnSBillShare.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonBase.Extensions;

namespace QnSBillShare.AspMvc.Models
{
    public class ModelObject : Contracts.IIdentifiable, Contracts.ICopyable<Contracts.IIdentifiable>
    {
        public int Id { get; set; }

        public byte[] Timestamp { get; set; }

        public void CopyProperties(IIdentifiable other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            Timestamp = other.Timestamp;
        }
    }
}
