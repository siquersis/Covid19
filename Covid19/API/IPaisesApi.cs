using Covid19.Models;

using Refit;

using System.Threading.Tasks;

namespace Covid19.API
{
    public interface IPaisesApi

    {
        [Get("https://api.covid19api.com/summary")]
        Task<Paises> GetPaises(string nomePais);
    }
}
