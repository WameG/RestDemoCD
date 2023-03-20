using RestDemoCD.Models;

namespace RestDemoCD.Repository
{
    public class TeacherRepository
    {
        private static List<Teacher> data = new List<Teacher>()
        {
            new Teacher() {Id = 1, Name = "John"},
            new Teacher() {Id = 1, Name = "John"}
        };

        public List<Teacher> GetAll()
        {
            return new List<Teacher>(data);
        }
    }
}
