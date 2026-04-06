using Models.NASAOpenAPI;
using Services;

namespace ViewModels
{
    public class HomePageViewModel
    {
        private readonly INASAOpenAPIService _NASAOpenAPIService;

        public bool IsLoading { get; set; } = true;

        public Root Expedition40SpaceMissions { get; set; } = new Root();

        public HomePageViewModel(INASAOpenAPIService nasaOpenAPIService)
        {
            this._NASAOpenAPIService = nasaOpenAPIService;
        }

        public async Task LoadAsync()
        {
            this.IsLoading = true;
            this.Expedition40SpaceMissions = await this._NASAOpenAPIService.GETExpedition40SpaceMissions();
            this.IsLoading = false;
        }
    }
}
