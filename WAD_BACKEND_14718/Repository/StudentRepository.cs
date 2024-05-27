using CW_WAD_00014718.Models;
using Microsoft.EntityFrameworkCore;
using WAD_BACKEND_14718.DAL;

namespace CW_WAD_00014718.Repository
{
    public class StudentRepository : IStudentRepository
    {

        public StudentGradeDbContext DbContext { get; }
        public StudentRepository(StudentGradeDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task CreateStudent(Student student)
        {
            await DbContext.Student.AddAsync(student);
            await DbContext.SaveChangesAsync();
        }


        public async Task DeleteStudent(int id)
        {
            var student = await DbContext.Student.FirstOrDefaultAsync(s => s.Id == id);

            if (student != null)
            {
                DbContext.Student.Remove(student);
                await DbContext.SaveChangesAsync();
            }
        }

 
        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await DbContext.Student.ToListAsync();
        }

        public async Task<Student> GetSingleStudent(int id)
        {
            return await DbContext.Student.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task UpdateStudent(Student student)
        {
            DbContext.Entry(student).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }
    }
}
