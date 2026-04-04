using Models.NASAOpenAPI;
using Services;

namespace ViewModels
{
    public class HomePageViewModel
    {
        private readonly INASAOpenAPIService _NASAOpenAPIService;

        public bool IsLoading { get; set; } = true;

        public APOD APOD { get; set; } = new APOD();

        public HomePageViewModel(INASAOpenAPIService nasaOpenAPIService)
        {
            this._NASAOpenAPIService = nasaOpenAPIService;
        }

        public async Task LoadAsync()
        {
            this.IsLoading = true;
            this.APOD = await this._NASAOpenAPIService.GetARandomAPODAsync();
            this.IsLoading = false;
        }
    }
}
