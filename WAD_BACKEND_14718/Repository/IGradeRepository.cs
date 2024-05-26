using CW_WAD_00014718.Models;

namespace CW_WAD_00014718.Repository
{
    public interface IGradeRepository
    {
        Task<IEnumerable<Grade>> GetAllGrade();
        Task<Grade> GetSingleGrade(int id);
        Task CreateGrade(Grade grade);
        Task UpdateGrade(Grade grade);
        Task DeleteGrade(int id);
    }
}
