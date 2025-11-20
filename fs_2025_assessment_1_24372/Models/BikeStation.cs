namespace fs_2025_assessment_1_24372.Models
{
    public class BikeStationModel
    {
        public int number { get; set; }
        public string contractName { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public int bikeStands { get; set; }
        public int availableBikeStands { get; set; }
        public int availableBikes { get; set; }
        public string status { get; set; }
        public long lastUpdate { get; set; }
    }
}
