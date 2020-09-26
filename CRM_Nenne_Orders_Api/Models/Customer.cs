using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Nenne_Orders_Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string Phone { get; set; }
        
        public string Description { get; set; }
       
        public string Contact { get; set; }
        
        public string Mail { get; set; }
    }
}
