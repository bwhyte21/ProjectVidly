using ProjectVidly.Models;
using System.Collections.Generic;

namespace ProjectVidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }

        public string Title => (Customer != null && Customer.Id != 0) ? "Edit Customer" : "New Customer";
    }
}