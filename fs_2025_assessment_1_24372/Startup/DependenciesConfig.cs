using fs_2025_assessment_1_24372.Data;

namespace fs_2025_assessment_1_24372.Startup
{
    public static class DependenciesConfig
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
           builder.Services.AddTransient<CourseData>();
           builder.Services.AddSingleton<BikeStationData>();
        }
    }
}
