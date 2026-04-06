using Models.NASAOpenAPI;

namespace Repositories
{
    public class NASAOpenAPIRepository : INASAOpenAPIRepository
    {
        private string APODUrl = "https://api.nasa.gov/planetary/apod?api_key=iqoIcm2JSKcBFraMmaTQYP6MVai6v0SXGcl5OSqu";

        private string ImagesFromExpedition40Url = "https://images-api.nasa.gov/search?media_type=image&keywords=EARTH%20OBSERVATIONS%20(FROM%20SPACE)%20%20EXPEDITION%2040";

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
                    return await httpClient.GetFromJsonAsync<APOD>(url);
                }
  
            }
        }

        public async Task<Root> GETExpedition40SpaceMissions()
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetFromJsonAsync<Root>(this.ImagesFromExpedition40Url);
            }
        }
    }
}