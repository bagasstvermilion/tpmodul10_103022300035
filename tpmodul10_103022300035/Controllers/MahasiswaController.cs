using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul10_103022300035.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Bagas Pratama", NIM = "103022300035" },
            new Mahasiswa { Nama = "Raffa Rixky Febrian", NIM = "103022330138" },
            new Mahasiswa { Nama = "Frizam Daffa Maulana", NIM = "103022300011" },
            new Mahasiswa { Nama = "Naufal Muhammad Dzulfikar", NIM = "103022300021" },
            new Mahasiswa { Nama = "Riziq Rizwwan", NIM = "103022300119" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> GetById(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
                return NotFound("ID tidak ditemukan");

            return Ok(mahasiswaList[id]);
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> AddMahasiswa(Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok(mahasiswaList);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Mahasiswa>> DeleteMahasiswa(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
                return NotFound("ID tidak ditemukan");

            mahasiswaList.RemoveAt(id);
            return Ok(mahasiswaList);
        }
    }
}

public class Mahasiswa
{
    public string NIM { get; set; }
    public string Nama { get; set; }
}
