using Models.NASAOpenAPI;
using Services;

namespace ViewModels
{
    public class HomePageViewModel
    {
        protected INASAOpenAPIService NASAOpenAPIService { get; set; }

        public APOD APOD { get; set; }

        public HomePageViewModel(INASAOpenAPIService nasaOpenAPIService)
        {
            this.NASAOpenAPIService = nasaOpenAPIService;
        }

        public async Task LoadAsync()
        {
            this.APOD = await this.NASAOpenAPIService.GetARandomAPODAsync();
        }
    }
}
