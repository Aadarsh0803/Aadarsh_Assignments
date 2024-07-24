namespace TempConvLibrary
{
    public class TempConvert
    {
        public double CTF(double temp)
        {
            double result = ((9*temp)/5)+32;
            return result;
        }
        public double FTC(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
