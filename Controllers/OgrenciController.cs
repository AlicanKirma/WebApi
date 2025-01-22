using basitwebapi.Models;
using Microsoft.AspNetCore.Mvc;



namespace basitwebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OgrenciController :  ControllerBase
    { 
         static List<Ogrenci>  ogrenciler = new List<Ogrenci>{
             new Ogrenci{Id = 1,AdSoyad="Alican Kırma"},
             new Ogrenci{Id = 2,AdSoyad="Vildan Kırma"},
             new Ogrenci{Id = 3,AdSoyad="Süha Kırma"}
         };
         
        [HttpGet]
        public List<Ogrenci> Get(){
          
           return ogrenciler;
        }

        [HttpGet("{id}")]
        public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }
    }
}