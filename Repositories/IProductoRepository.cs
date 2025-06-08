using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiendaOnline
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> ListarAsync();
        Task<Producto> ObtenerPorIdAsync(int id);
        Task CrearAsync(Producto producto);
        Task EditarAsync(Producto producto);
        Task EliminarAsync(int id);
    }
}