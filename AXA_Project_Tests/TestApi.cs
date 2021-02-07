using AXA_Project.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net.Http;

namespace AXA_Project_Tests
{
	[TestClass]
	public class TestApi
	{
		[TestMethod]
		public async System.Threading.Tasks.Task TestCharacterNameAsync()
		{
			string url = "https://swapi.dev/api/people/1/";
			string name = "";

			using (HttpClient client = new HttpClient())
			{
				using (var response = await client.GetAsync(url))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					var tmp = JsonConvert.DeserializeObject<NamesModel>(apiResponse);
					name = tmp.Name;
				}
			}

			Assert.AreEqual("Luke Skywalker", name);
		}
	}
}
