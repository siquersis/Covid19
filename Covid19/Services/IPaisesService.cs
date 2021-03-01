using Covid19.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19.Services
{
    public interface IPaisesService
    {
        Task<IEnumerable<Paises>> GetAll(string nomePaises);
    }
}
