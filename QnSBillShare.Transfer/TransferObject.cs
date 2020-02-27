//@QnSCodeCopy
//MdStart
namespace QnSBillShare.Transfer
{
    public class TransferObject : Contracts.IIdentifiable
    {
        public virtual int Id { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
//MdEnd
