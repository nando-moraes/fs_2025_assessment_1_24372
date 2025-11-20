using fs_2025_assessment_1_24372.Models;
using System.Text.Json;

namespace fs_2025_assessment_1_24372.Data
{
    public class BikeStationData
    {
        public List<BikeStationModel> BikeStations { get; private set; } = new List<BikeStationModel>();

        public BikeStationData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "dublinbike.json");
            var jsonData = File.ReadAllText(filePath);
            BikeStations = JsonSerializer.Deserialize<List<BikeStationModel>>(jsonData, options) ?? new List<BikeStationModel>();
        }

    }
}
