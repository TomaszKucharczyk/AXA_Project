using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AXA_Project.Models
{
	public class RatingModel
	{
		[Key]
		public int Id { get; set; }
		public int Grade { get; set; }
		public int Episode_Id { get; set; }
	}
}
