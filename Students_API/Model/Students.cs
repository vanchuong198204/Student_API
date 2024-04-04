using System.ComponentModel.DataAnnotations;

namespace Students_API.Model
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public ICollection<StudentCourse>? StudentCourses { get; set; }

    }
}
