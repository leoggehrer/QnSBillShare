//@QnSCodeCopy
//MdStart
namespace QnSBillShare.Contracts
{
    /// <summary>
    /// Defines the basic properties of identifiable components.
    /// </summary>
    public partial interface IIdentifiable
    {
        /// <summary>
        /// Gets the identity of the component.
        /// </summary>
        int Id { get; }
        byte[] Timestamp { get; }
    }
}
//MdEnd
