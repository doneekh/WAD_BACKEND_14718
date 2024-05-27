using CW_WAD_00014718.Models;
using Microsoft.EntityFrameworkCore;
using WAD_BACKEND_14718.DAL;

namespace CW_WAD_00014718.Repository
{
    public class GradeRepository : IGradeRepository
    {
        public StudentGradeDbContext DbContext { get; }
        public GradeRepository(StudentGradeDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task CreateGrade(Grade grade)
        {
            await DbContext.Grade.AddAsync(grade);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteGrade(int id)
        {
            var grade = await DbContext.Grade.FirstOrDefaultAsync(g => g.Id == id);
            if (grade != null)
            {
                DbContext.Grade.Remove(grade);
                await DbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Grade>> GetAllGrade()
        {
            return await DbContext.Grade.Include(g => g.Student).ToListAsync();
        }

        public async Task<Grade> GetSingleGrade(int id)
        {
            return await DbContext.Grade.Include(g => g.Student).FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task UpdateGrade(Grade grade)
        {
            DbContext.Entry(grade).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }
    }
}
