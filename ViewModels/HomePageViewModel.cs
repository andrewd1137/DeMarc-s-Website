using ColorThiefDotNet;
using Models.NASAOpenAPI;
using Services;

namespace ViewModels
{
    public class HomePageViewModel
    {
        private readonly INASAOpenAPIService _NASAOpenAPIService;

        public bool IsLoading { get; set; } = true;

        public Root Expedition40SpaceMissions { get; set; } = new Root();

        public string ImagePath { get; set; } = "";

        public HomePageViewModel(INASAOpenAPIService nasaOpenAPIService)
        {
            this._NASAOpenAPIService = nasaOpenAPIService;
        }

        public async Task LoadAsync()
        {
            this.IsLoading = true;
            
            //todo: cache this result so we don't have to make a new API call every time the user visits the home page
            this.Expedition40SpaceMissions = await this._NASAOpenAPIService.GETExpedition40SpaceMissions();
            this.ImagePath = this.DisplayRandomExpidition40Image();
            this.IsLoading = false;
        }

        public string DisplayRandomExpidition40Image()
        {
            var random = new Random();
            var randomIndex = random.Next(0, this.Expedition40SpaceMissions.Collection.Items.Count);
            var randomImageUrl = this.Expedition40SpaceMissions.Collection.Items[randomIndex].Links[0].Href;
            return randomImageUrl;
        }

        public void DeterminePallete()
        {
            var colorThief = new ColorThief();

            using (var bitmap = new System.Drawing.Bitmap(this.ImagePath))
            {
                var palette = colorThief.GetPalette(bitmap, 8);

                foreach (var quantizedColor in palette)
                {
                    var color = quantizedColor.Color;
                    Console.WriteLine($"RGB: {color.R}, {color.G}, {color.B} | Population: {quantizedColor.Population}");
                    //todo make this output the colors to be used in the homt page design (background color, text color, accent color, etc.)
                }
            }    
        }
    }
}
