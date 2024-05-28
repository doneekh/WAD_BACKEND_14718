using CW_WAD_00014718.Models;
using CW_WAD_00014718.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WAD_BACKEND_14718.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeRepository _gradeRepository;
        public GradeController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }

        // POST: api/Grade
        [HttpPost]
        public async Task<ActionResult<Grade>> CreateGrade(Grade grade)
        {
            grade.Student.Id = 0;
            await _gradeRepository.CreateGrade(grade);
            return Ok(grade);
        }
        // PUT: api/Grade/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrade(int id, Grade grade)
        {
            if (id != grade.Id)
            {
                return BadRequest();
            }

            try
            {
                await _gradeRepository.UpdateGrade(grade);
            }
            catch (DbUpdateConcurrencyException)
            {
                var visitorSingle = await _gradeRepository.GetSingleGrade(id);
                if (visitorSingle == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Updated");
        }
        // GET: api/Grade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grade>> GetSingleGrade(int id)
        {
            var grade = await _gradeRepository.GetSingleGrade(id);
            if (grade == null)
            {
                return NotFound();
            }
            return Ok(grade);
        }
        // GET: api/Grade
        [HttpGet]
        public async Task<IEnumerable<Grade>> GetAllGrade()
        {
            return await _gradeRepository.GetAllGrade();
        }
        
        // DELETE: api/Grade/6
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            await _gradeRepository.DeleteGrade(id);

            return Ok("Deleted");
        }


    }
}
