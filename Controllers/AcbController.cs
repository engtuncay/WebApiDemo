using System.Collections.Generic;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    /// <summary>
    /// Action Based Controller
    /// </summary>
    public class AcbController: ApiController
    {
        static readonly List<string> degerler = new List<string>()
        {
            "value0","value1","value2","value3"
        };

        // GET api/acb
        // GET https://localhost/api/acb
        [HttpGet]
        public IEnumerable<string> Degerler()
        {
            return degerler;
        }

        // GET api/acb/1
        [HttpGet]
        public string DegerGetir(int id)
        {
            return degerler[id];
        }

        // POST api/acb
        [HttpPost]
        public void DegerEkle([FromBody] string value)
        {
            degerler.Add(value);
        }

        // PUT api/values/5
        [HttpPut]
        public void DegerGuncelle(int id, [FromBody] string value)
        {
            degerler[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete]
        public void DegerSil(int id)
        {
            degerler.RemoveAt(id);
        }
    }
}