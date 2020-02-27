//@QnSCodeCopy
//MdStart
using System;
using System.Collections.Generic;
using System.Text;

namespace QnSBillShare.Adapters
{
    public static partial class Factory
    {
        static Factory()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();

        public static string BaseUri = "";
        public enum AdapterType
        {
           Controller,
           Service,
        }
        public static AdapterType Adapter { get; set; } = Factory.AdapterType.Controller;
    }
}
//MdEnd
