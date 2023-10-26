using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string phoneNumber { get; set; }
    }

}