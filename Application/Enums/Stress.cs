using System.ComponentModel;

namespace Application.Enums
{
    public enum Stress
    {
        [Description("Ingen stress (tp 37)")]
        NoStress,
        [Description("tp 38")]
        ThirthyEight,
        [Description("tp 39")]
        ThirthyNine,
        [Description("tp 40")]
        Forty,
        [Description("Svære infektioner")]
        Infections
    }
}
