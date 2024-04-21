using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<Ogrenciler> ogrencilers = new List<Ogrenciler>()
        {
            new Ogrenciler { id = 0, isim = "semih" },
            new Ogrenciler { id = 1, isim = "ayþe" },
            new Ogrenciler { id = 2, isim = "mehmet" }
        };

        [HttpGet]
        public List<Ogrenciler> get()
        {
            return ogrencilers;
        }
        [HttpGet("id")]
        public Ogrenciler Get (int id)
        {
            return ogrencilers.FirstOrDefault(o=>o.id==id);
        }
        [HttpPost]
        public Ogrenciler post(Ogrenciler ogrenciler)
        {
            ogrencilers.Add(ogrenciler);
            return ogrenciler;
        }

    }
}
