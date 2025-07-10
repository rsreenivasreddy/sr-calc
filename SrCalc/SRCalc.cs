
using LoveCalculator;
namespace SrCalc
{
    public class SRCalc
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public int Substract(int i, int j)
        {
            LoveCalculator.Calculators.PersonCalculator personCalculator = new LoveCalculator.Calculators.PersonCalculator();
            personCalculator.AgeDifference();
            return i - j;
        }
    }
}