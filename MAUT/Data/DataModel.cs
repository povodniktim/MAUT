namespace MAUT.Data
{
    public class DataModel
    {
        public List<ParameterModel> Parameters { get; set; } = new List<ParameterModel> 
        {
            new ParameterModel
            {
                Id = "0",
                Level = 0,
                Name = "Ocena",
                HasSubParameters = true,
                Expanded = true
            }
        };
        public List<ParameterModel> EndNodeParameters { get; set; } = new List<ParameterModel>();
        public List<AlternativeModel> Alternatives { get; set; } = new List<AlternativeModel>();
    }
}
