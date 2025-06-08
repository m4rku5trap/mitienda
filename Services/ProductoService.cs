using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiendaOnline
{
    public class ProductoService
    {
        private readonly IProductoRepository _repo;

        public ProductoService(IProductoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Producto>> ListarAsync() => await _repo.ListarAsync();

        public async Task CrearAsync(Producto producto)
        {
            if (producto.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");

            await _repo.CrearAsync(producto);
        }

        public async Task EditarAsync(Producto producto)
        {
            if (producto.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");

            await _repo.EditarAsync(producto);
        }

        public async Task EliminarAsync(int id) => await _repo.EliminarAsync(id);
    }
}