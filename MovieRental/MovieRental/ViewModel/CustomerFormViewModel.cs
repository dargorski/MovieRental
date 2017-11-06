using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental.Models;

namespace MovieRental.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string PageTitle { get; set; }
    }
}