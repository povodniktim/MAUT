namespace MAUT.Data
{
    public class ParameterModel
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double ActualValue { get; set; }
        public double Usefulness { get; set; }
        public string UtilityFunction { get; set; } = "linear";
        public string Color { get; set; }
        public bool Expanded { get; set; }
        public bool IsSelected { get; set; }
        public bool HasSubParameters { get; set; }
    }
}
