﻿using CW_WAD_00014718.Models;
using CW_WAD_00014718.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CW_WAD_00014718.Controllers
{
    public class StudentController : ControllerBase
    {
        
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudent()
        {
            return await studentRepository.GetAllStudent();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var recept = await studentRepository.GetSingleStudent(id);

            if (recept == null)
            {
                return NotFound();
            }
            return Ok(recept);
        }

        // PUT: api/Student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            await studentRepository.UpdateStudent(student);
            return NoContent();
        }

        // POST: api/Student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            await studentRepository.CreateStudent(student);

            return CreatedAtAction("GetStuudent", new { id = student.Id }, student);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await studentRepository.DeleteStudent(id);
            return NoContent();
        }
    }
}