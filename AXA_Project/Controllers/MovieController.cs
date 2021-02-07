using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AXA_Project.Helpers;
using AXA_Project.Models;
using AXA_Project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AXA_Project.Controllers
{
	public class MovieController : Controller
	{
		private readonly Context _context;

		public MovieController(Context context)
		{
			_context = context;
		}

		public async Task<IActionResult> IndexAsync()
		{
			try
			{
				MovieViewModel movies;
				using (var httpClient = new HttpClient())
				{
					using (var response = await httpClient.GetAsync("https://swapi.dev/api/films/"))
					{
						string apiResponse = await response.Content.ReadAsStringAsync();
						movies = JsonConvert.DeserializeObject<MovieViewModel>(apiResponse);
					}
				}

				foreach (var item in movies.Results)
				{
					item.Rating = _context.Ratings.Any(x => x.Episode_Id == item.Episode_id) ? _context.Ratings.First(x => x.Episode_Id == item.Episode_id).Grade.ToString() : "No rating yet!";
				}

				movies.Results = movies.Results.OrderBy(x => x.Episode_id).ToList();

				return View(movies);
			}
			catch
			{
				return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}		
		}

		public async Task<IActionResult> DetailsAsync(int id)
		{
			try
			{
				if (id != 3) //when episode 3 is choosen, id changes to 0
					id = (id + 3) % 6;
				else
					id = 6;
				MovieModel movie;
				using (var httpClient = new HttpClient())
				{
					using (var response = await httpClient.GetAsync("https://swapi.dev/api/films/" + id + "/"))
					{
						string apiResponse = await response.Content.ReadAsStringAsync();
						movie = JsonConvert.DeserializeObject<MovieModel>(apiResponse);
					}
					using (HttpClient client = new HttpClient())
					{
						movie.Characters = await JSONConversionHelper.ConversionHelperAsync(movie.Characters, client);
						movie.Planets = await JSONConversionHelper.ConversionHelperAsync(movie.Planets, client);
						movie.Species = await JSONConversionHelper.ConversionHelperAsync(movie.Species, client);
						movie.Starships = await JSONConversionHelper.ConversionHelperAsync(movie.Starships, client);
						movie.Vehicles = await JSONConversionHelper.ConversionHelperAsync(movie.Vehicles, client);
					}
				}
				movie.Rating = _context.Ratings.Any(x => x.Episode_Id == movie.Episode_Id) ? _context.Ratings.First(x => x.Episode_Id == movie.Episode_Id).Grade : 0;

				return View(movie);
			}
			catch
			{
				return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}
		}

		public IActionResult RateMovie(int Episode_Id, int Rating)
		{
			try
			{
				if (_context.Ratings.Any(x => x.Episode_Id == Episode_Id))
				{
					_context.Ratings.First(x => x.Episode_Id == Episode_Id).Grade = Rating;
				}
				else
				{
					_context.Ratings.Add(new RatingModel() { Episode_Id = Episode_Id, Grade = Rating });
				}
				_context.SaveChanges();

				return RedirectToAction("Details", "Movie", new { id = Episode_Id });
			}
			catch
			{
				return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}
		}
	}
}
