namespace FactoryPattern.Models
{
    public class Sample : ISample
    {
        public int RandomValue { get; set; }
        public Sample()
        {
            RandomValue = Random.Shared.Next(0, 100);
        }
    }

    public interface ISample
    {
        int RandomValue { get; set; } 
    }
}
