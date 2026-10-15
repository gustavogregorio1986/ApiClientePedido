using ApiClientePedido.Data;
using ApiClientePedido.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiClientePedido.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pedido pedido)
        {
            bool clieExiste = _context.Clientes.Any(c => c.Id == pedido.ClienteId);

            if (!clieExiste)
                throw new Exception($"Cliente com ID {pedido.ClienteId} não existe.");

            await _context.Pedidos.AddAsync(pedido);
        }

        public Task DeleteAsync(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
            => await _context.Pedidos.Include(p => p.Cliente).ToListAsync();

        public async Task<Pedido> GetByIdAsync(int id)
            => await _context.Pedidos.FirstOrDefaultAsync(p => p.Id == id);

        public async Task<bool> SaveAsync()
            => await _context.SaveChangesAsync() > 0;

        public Task UpdateAsync(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            return Task.CompletedTask;
        }
    }
}
