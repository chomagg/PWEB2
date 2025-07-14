using apiServicio.Business.Clases;
using apiServicio.Business.Contracts;
using apiServicio.Models;
using apiServicio.Services.Contracts;

namespace apiServicio.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _repository;

        public RolService(IRolRepository repository)
        {
            _repository = repository;  
        }
        public Task<List<Rol>> GetList()
        {
            return _repository.GetList();
        }
    }
}
