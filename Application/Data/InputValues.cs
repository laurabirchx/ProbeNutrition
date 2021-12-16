using Application.Enums;

namespace Application.Data
{
    public class InputValues
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Activity ActivityLevel { get; set; }
        public Stress StressLevel { get; set; }
        public WeightGain WeightGain { get; set; }
        public double ExpectedAspirat { get; set; }
        public double ExpectedDrainageLoss { get; set; }
        public double ExpectedDiurese { get; set; }
        public double ExpectedOther { get; set; }
    }
}
