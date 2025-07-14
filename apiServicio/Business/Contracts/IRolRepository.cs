using apiServicio.Models;

namespace apiServicio.Business.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
    }
}
