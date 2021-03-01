using Newtonsoft.Json;
using System;

namespace Covid19.Models
{
    public class Paises
    {
        [JsonProperty("ID")]
        public int IdPais { get; set; }
        [JsonProperty("Country")]
        public string NomePais { get; set; }
        [JsonProperty("CountryCode")]
        public string SiglaPais { get; set; }
        [JsonProperty("Slug")]
        public string Slug { get; set; }
        [JsonProperty("TotalConfirmed")]
        public int TotalConfirmado { get; set; }
        [JsonProperty("NewDeaths")]
        public int NovasMortes { get; set; }
        [JsonProperty("TotalDeaths")]
        public int TotalMortes { get; set; }
        [JsonProperty("NewConfirmed")] 
        public string NovosCasosConfirmados { get; set; }
        [JsonProperty("NewRecovered")]
        public int NovoRecorde { get; set; }
        [JsonProperty("TotalRecovered")]
        public int RecordeTotal { get; set; }
        [JsonProperty("Date")]
        public DateTime Data { get; set; }
    }
}