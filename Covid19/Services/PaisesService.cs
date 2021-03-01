using Covid19.API;
using Covid19.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19.Services
{
    public class PaisesService : IPaisesService
    {
        //O número de casos ativos compreende a diferença entre o total de casos confirmados e o total de casos recuperados
        //A lista de países deve apresentar o nome do país, sua posição no ranking e o número de casos de Covid-19 ativos

        public Task<IEnumerable<Paises>> GetAll(string nomePaises)
        {
            var listaPaises = RestService.For<IPaisesApi>("https://api.covid19api.com/summary");


            return (Task<IEnumerable<Paises>>)listaPaises;
        }
    }
}