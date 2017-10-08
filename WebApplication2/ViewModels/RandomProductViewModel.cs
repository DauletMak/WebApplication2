using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;


namespace WebApplication2.ViewModels
{
    public class RandomProductViewModel
    {
        public Product Product { get; set; }
        public List<Customer> Customer { get; set; }
    }
}