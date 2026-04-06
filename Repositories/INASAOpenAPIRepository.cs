using Models.NASAOpenAPI;

namespace Repositories
{
    public interface INASAOpenAPIRepository
    {
        Task<APOD> GetAPODAsync(bool randomlyChooseDay = false);
        Task<Root> GETExpedition40SpaceMissions();
    }
}