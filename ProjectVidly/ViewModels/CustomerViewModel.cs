using ProjectVidly.Models;
using System.Collections.Generic;

namespace ProjectVidly.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
    }
}