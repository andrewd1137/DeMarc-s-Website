using Models.NASAOpenAPI;
using Repositories;

namespace Services
{
    public class NASAOpenAPIService : INASAOpenAPIService
    {
        public INASAOpenAPIRepository NASAOpenAPIRepository;

        public NASAOpenAPIService(INASAOpenAPIRepository nasaOpenAPIRepository)
        {
            this.NASAOpenAPIRepository = nasaOpenAPIRepository;
        }

        public async Task<APOD> GetAPODAsync()
        {
            return await this.NASAOpenAPIRepository.GetAPODAsync();
        }

        public async Task<APOD> GetARandomAPODAsync()
        {
            return await this.NASAOpenAPIRepository.GetAPODAsync(true);
        }
    }
}