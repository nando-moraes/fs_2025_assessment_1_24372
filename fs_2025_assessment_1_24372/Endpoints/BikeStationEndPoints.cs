using fs_2025_assessment_1_24372.Data;
using Microsoft.AspNetCore.Mvc;


namespace fs_2025_assessment_1_24372.Endpoints
{
    public static class BikeStationEndPoints
    {
        public static void AddBikeStationEndPoints(this WebApplication app)
        {
            app.MapGet("/bikestation", LoadAllBikeStationsAsync);

            app.MapGet("/bikestation/{id:int}",LoadBikeStationById);

         
        }

        private static async Task<IResult> LoadBikeStationById([FromServices] BikeStationData bikestationData, int id)
        {
            var output = bikestationData.BikeStations.FirstOrDefault(c => c.number == id);
            if (output is null)
            {
                return Results.NotFound();
            }   
            return Results.Ok(output);

        }

        private static async Task<IResult> LoadAllBikeStationsAsync([FromServices]
            BikeStationData bikestationData, 
            string? bikestationName,
            string? search
            )
        {
            var output = bikestationData.BikeStations;

            if (!string.IsNullOrWhiteSpace(bikestationName))
            {
                output = output.Where(c => c.name.Equals(bikestationName, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if(!string.IsNullOrWhiteSpace(search))
            {
                output = output.Where(c => c.name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                           c.address.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return Results.Ok(output);
        }
    }
}
