﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product_App.Model
{	public class Product
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string ImageUri { get; set; }
		[Required]
		public decimal Price { get; set; }
		public string Description { get; set; }
	}
}