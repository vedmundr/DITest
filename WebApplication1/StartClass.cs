namespace WebApplication1
{
    public interface IStartClass
    {
        int MethodRun();
    }

    public class StartClass : IStartClass
    {
        private readonly IMyRandomClass _classRandome;

        public StartClass(IMyRandomClass classRandome)
        {
            _classRandome = classRandome;
        }

        public int MethodRun()
        {
            int v = _classRandome.GetRandom();
            Console.WriteLine(v);
            return v;
        }
    }
}
