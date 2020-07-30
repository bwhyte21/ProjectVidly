using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectVidly.Models;

namespace ProjectVidly.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
    }
}