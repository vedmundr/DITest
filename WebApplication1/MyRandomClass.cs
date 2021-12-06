namespace WebApplication1
{
    public interface IMyRandomClass
    {
        int GetRandom();
    }

    public class MyRandomClass : IMyRandomClass
    {
        public int GetRandom()
        {
            Random random = new();
            return random.Next(0, 100);
        }
    }
}
