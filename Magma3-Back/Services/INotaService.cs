using Magma3_Back.Entities;

namespace Magma3_Back.Services
{
    public interface INotaService
    {
        Task<List<Nota>> GetAllNotas();
        Task<Nota> GetNotaById(string Id);
        Task<Nota> CreateNota(Nota nota);
        Task<Nota> UpdateNota(Nota nota);
        Task<Nota> DeleteNota(string Id);
    }
}
