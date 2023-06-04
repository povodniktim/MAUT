namespace MAUT.Data
{
    public class AlternativeModel
    {
        public AlternativeModel()
        {
            AltEndNodeParameters = new List<ParameterModel>();
            AltParentParameters = new List<ParameterModel>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public double TotalGrade { get; set; }
        public List<ParameterModel> AltEndNodeParameters { get; set; }
        public List<ParameterModel> AltParentParameters { get; set; }
        public bool IsHighestGrade { get; set; }

        public void InitializeAltParameters(List<ParameterModel> endNodeParameters)
        {
            if (AltEndNodeParameters.Count == 0)
            {
                AltEndNodeParameters = new List<ParameterModel>();
                foreach (var param in endNodeParameters)
                {
                    // Create a new parameter with a unique ID for the current alternative
                    var altParam = new ParameterModel
                    {
                        Id = $"{Id}-{param.Id}",
                        ParentId = param.ParentId,
                        Name = param.Name,
                        ActualValue = param.ActualValue,
                        Weight = param.Weight,
                        Usefulness = param.Usefulness,
                        UtilityFunction = param.UtilityFunction,
                    };
                    AltEndNodeParameters.Add(altParam);
                }
            }
        }
    }
}



