using Models.NASAOpenAPI;

namespace Services
{
    public interface INASAOpenAPIService
    {
        Task<APOD> GetAPODAsync();
        Task<APOD> GetARandomAPODAsync();
    }
}