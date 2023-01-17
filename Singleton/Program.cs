namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton 패턴 을통한 객체 생성");
            for(int count = 0 ; count < 5; count++)
            {
                var singletonClass = Singleton.SingletonClass.Instance;
                singletonClass.Say();
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("일반 객체 생성");
            for (int count = 0; count < 5; count++)
            {
                var nonSingletonClass = new NonSingletonClass();
                nonSingletonClass.Say();
            }
        }
    }
}