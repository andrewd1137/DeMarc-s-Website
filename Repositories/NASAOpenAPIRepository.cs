using Models.NASAOpenAPI;

namespace Repositories
{
    public class NASAOpenAPIRepository : INASAOpenAPIRepository
    {
        public string APODUrl = "https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY";

        public async Task<APOD> GetAPODAsync(bool randomlyChooseDay = false)
        {
            using (var httpClient = new HttpClient())
            {
                var url = this.APODUrl;

                if (randomlyChooseDay)
                {
                    url += "&count=1";
                }

                return await httpClient.GetFromJsonAsync<APOD>(url);
            }
        }
    }
}