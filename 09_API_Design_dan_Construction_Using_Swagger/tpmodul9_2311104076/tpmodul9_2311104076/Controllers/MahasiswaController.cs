using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104076.Models;

namespace tpmodul9_2311104076.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Alya Rabani", "2311104076"),
            new Mahasiswa("Dhiemas Tulus Ikshan", "2311104046"),
            new Mahasiswa("Berlian Seva Astryana", "2311104067")
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(daftarMahasiswa);
        }

        [HttpGet("{index}")]
        public IActionResult GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Data tidak ditemukan.");

            return Ok(daftarMahasiswa[index]);
        }

        [HttpPost]
        public IActionResult AddMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok(daftarMahasiswa);
        }

        [HttpDelete("{index}")]
        public IActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Data tidak ditemukan.");

            daftarMahasiswa.RemoveAt(index);
            return Ok(daftarMahasiswa);
        }
    }
}
