using System;
using System.ComponentModel;

namespace Application.Enums
{
    public enum Activity
    {
        [Description("Rask")]
        Healthy,
        [Description("Oppegående")]
        Walking,
        [Description("Sengeliggende")]
        InBed,
    }
}
