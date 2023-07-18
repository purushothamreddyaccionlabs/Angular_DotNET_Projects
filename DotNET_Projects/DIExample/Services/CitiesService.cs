namespace Services
{
    public class CitiesService
    {
        private List<string> _cities;

        public CitiesService()
        {
            _cities = new List<string>()
            {
                "London","Delhi","Bengaluru","Hyderabad","Pune","Paris","Rome"
            };
        }

        public List<string> GetCities()
        {
            return _cities;
        }
    }
}