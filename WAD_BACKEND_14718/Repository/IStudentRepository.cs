using CW_WAD_00014718.Models;

namespace CW_WAD_00014718.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetSingleStudent(int id);
        Task CreateStudent(Student recept);
        Task UpdateStudent(Student recept);
        Task DeleteStudent(int id);
    }
}
