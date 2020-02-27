using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodeGenerator.ConApp.Generation
{
    partial class TransferGenerator
    {
        partial void CanCreateTransfer(Type type, ref bool create)
        {
        }
        partial void CreateTransferPropertyAttributes(Type type, string propertyName, List<string> codeLines)
        {
            if (type.Name.Equals("IBillExpense"))
            {
                if (propertyName.Equals("Bill"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
                else if (propertyName.Equals("Expenses"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
                else if (propertyName.Equals("Balances"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
            }
        }
    }
}
