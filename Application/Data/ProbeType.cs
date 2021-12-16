using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public class ProbeType
    {
        //Known
        public string Name { get; set; }
        public double EnergyKcalPerDosisML { get; set; }
        public double ProteinPerDosisL { get; set; }

        //Calculated
        public double Dosis { get; set; }
        public double AdditionalLiquid { get; set; }
        public double RequiredEnergyKcal { get; set; }
        public double RequiredProtein { get; set; }
        public double ReceivedEnergyKcal { get; set; }
        public double ReceivedProtein { get; set; }
        public double EnergyKcalDifference { get; set; }
        public double ProteinGramDifference { get; set; }
    }
}
