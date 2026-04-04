using Models.NASAOpenAPI;
using Repositories;

namespace Services
{
    public class NASAOpenAPIService : INASAOpenAPIService
    {
        private readonly INASAOpenAPIRepository _NASAOpenAPIRepository;

        public NASAOpenAPIService(INASAOpenAPIRepository nasaOpenAPIRepository)
        {
            this._NASAOpenAPIRepository = nasaOpenAPIRepository;
        }

        public async Task<APOD> GetAPODAsync()
        {
            return await this._NASAOpenAPIRepository.GetAPODAsync();
        }

        public async Task<APOD> GetARandomAPODAsync()
        {
            return await this._NASAOpenAPIRepository.GetAPODAsync(true);
        }
    }
}