using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.models
{
    enum City { Voronezh, Moscow, StPeterburg, Saratov, Norilsk, Kazan}
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
        public City City { get; set; }    
    }
}
