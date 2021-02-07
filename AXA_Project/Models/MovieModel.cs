using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXA_Project.Models
{
	public class MovieModel
	{
		public List<string> Characters { get; set; }
		public DateTime Created { get; set; }
		public string Director { get; set; }
		public DateTime Edited { get; set; }
		public int Episode_Id { get; set; }
		public string Opening_Crawl { get; set; }
		public List<string> Planets { get; set; }
		public string Producer { get; set; }
		public DateTime Release_Date { get; set; }
		public List<string> Species { get; set; }
		public List<string> Starships { get; set; }
		public string Title { get; set; }
		public string Url { get; set; }
		public List<string> Vehicles { get; set; }
		public int Rating { get; set; }

	}
}
