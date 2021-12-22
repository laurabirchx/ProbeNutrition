using System;
using Application.Data;

namespace BusinessLogic
{
    public class Calculation
    {
        public InputValues InputVals; //= new InputValues();
        public CalculatedValues CalculatedVals = new CalculatedValues();

        public void Calculate()
        {
            CalculateBMI();
        }

        public void CalculateBMI()
        {
            CalculatedVals.BMI = InputVals.Weight / Math.Pow(InputVals.Height/100, 2);
        }
    }
}
