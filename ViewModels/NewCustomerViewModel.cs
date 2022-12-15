using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}