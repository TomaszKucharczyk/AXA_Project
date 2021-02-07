using AXA_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AXA_Project.Helpers
{
	/// <summary>
	/// Helper class responsible for JSON conversion
	/// </summary>
	public static class JSONConversionHelper
	{
		/// <summary>
		/// Method calls for additional data from main SWApi movie call
		/// </summary>
		/// <param name="model">List of urls to additional SWApi data (characters, planets etc)</param>
		/// <param name="client">HttpClient object for optimalisation</param>
		/// <returns>List of names get from SWApi</returns>
		public static async Task<List<string>> ConversionHelperAsync(List<string> model, HttpClient client)
		{
			List<string> newModel = new List<string>();
			for (int i = 0; i < model.Count; i++)
			{
				using (var response = await client.GetAsync(model[i]))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					var tmp = JsonConvert.DeserializeObject<NamesModel>(apiResponse);
					newModel.Add(tmp.Name);
				}
			}

			return newModel;
		}
	}
}
