namespace FactoryPattern.Models;

public class Time : ITime
{
    public string CurrentTime { get; set; } = DateTime.Now.ToString();
}

public interface ITime
{
	string CurrentTime { get; set; }
}