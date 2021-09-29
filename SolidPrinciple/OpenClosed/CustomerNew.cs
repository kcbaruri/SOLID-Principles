using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.OpenClosed
{
    /// <summary>
    /// Invoice number is string here to support a new customer. Here, customer class is open for extension
    /// </summary>
   public class CustomerNew : Customer
    {
       public new string InvoiceNumber { get; set; }
    }
}
