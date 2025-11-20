using fs_2025_assessment_1_24372.Models;
using System.Text.Json;

namespace fs_2025_assessment_1_24372.Data
{
    public class CourseData
    {
        public List<CourseModel> Courses { get; private set; } = new List<CourseModel>();

        public CourseData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "coursedata.json");
            var jsonData = File.ReadAllText(filePath);
            Courses = JsonSerializer.Deserialize<List<CourseModel>>(jsonData, options) ?? new List<CourseModel>();
        }

    }
}
