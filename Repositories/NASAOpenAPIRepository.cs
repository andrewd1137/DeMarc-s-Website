using Models.NASAOpenAPI;

namespace Repositories
{
    public class NASAOpenAPIRepository : INASAOpenAPIRepository
    {
        public string APODUrl = "https://api.nasa.gov/planetary/apod?api_key=iqoIcm2JSKcBFraMmaTQYP6MVai6v0SXGcl5OSqu";

        public NASAOpenAPIRepository()
        {
        }

        public async Task<APOD> GetAPODAsync(bool randomlyChooseDay = false)
        {
            using (var httpClient = new HttpClient())
            {
                var url = this.APODUrl;

                if (randomlyChooseDay)
                {
                    url += "&count=1";

                    var results = await httpClient.GetFromJsonAsync<List<APOD>>(url);
                    return results?.FirstOrDefault();
                }
                else
                {
                    // For a single date, it remains a single object
                    return await httpClient.GetFromJsonAsync<APOD>(url);
                }
  
            }
        }
    }
}