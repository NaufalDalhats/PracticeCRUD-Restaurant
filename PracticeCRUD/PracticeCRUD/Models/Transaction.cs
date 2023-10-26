using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Models
{
	public class Transaction
	{
		public int ID { get; set; }
		public int CustomerId { get; set; }
		public int FoodId { get; set; }
	}
}
