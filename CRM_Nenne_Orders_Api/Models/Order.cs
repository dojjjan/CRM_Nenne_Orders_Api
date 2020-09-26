using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Nenne_Orders_Api.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
        public int JobId { get; set; }
        public int CustomerId { get; set; }
    }
}
