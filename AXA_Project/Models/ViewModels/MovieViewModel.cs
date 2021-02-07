using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXA_Project.Models.ViewModels
{
	public class MovieViewModel
	{
		public List<ResultMovieViewModel> Results { get; set; }
	}

	public class ResultMovieViewModel
	{
		public string Title { get; set; }
		public int Episode_id { get; set; }
		public string Rating { get; set; }
	}
}
