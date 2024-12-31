using DentisteApp.IRepositories;
using DentisteApp.Models.Entities;
using Microsoft.AspNetCore.Mvc;


namespace DentisteApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DossierMedicalController : ControllerBase
    {
        private readonly IDossierMedicalRepository _dossierMedicalRepository;

        public DossierMedicalController(IDossierMedicalRepository dossierMedicalRepository)
        {
            _dossierMedicalRepository = dossierMedicalRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DossierMedical>>> GetDossiersMedicaux()
        {
            return Ok(await _dossierMedicalRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DossierMedical>> GetDossierMedical(int id)
        {
            var dossier = await _dossierMedicalRepository.GetByIdAsync(id);
            if (dossier == null)
                return NotFound();
            return Ok(dossier);
        }

        [HttpPost]
        public async Task<ActionResult> CreateDossierMedical(DossierMedical dossierMedical)
        {
            await _dossierMedicalRepository.AddAsync(dossierMedical);
            return CreatedAtAction(nameof(GetDossierMedical), new { id = dossierMedical.DossierMedicalID }, dossierMedical);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDossierMedical(int id, DossierMedical dossierMedical)
        {
            if (id != dossierMedical.DossierMedicalID)
                return BadRequest();

            await _dossierMedicalRepository.UpdateAsync(dossierMedical);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDossierMedical(int id)
        {
            await _dossierMedicalRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
