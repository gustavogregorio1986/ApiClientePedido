using ApiClientePedido.Models;

namespace ApiClientePedido.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public Task AddAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
