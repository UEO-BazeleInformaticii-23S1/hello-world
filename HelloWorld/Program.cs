namespace HelloWorld
{
    internal class Program
    {
        static int i = 10;

        static void Main(string[] args)
        {
            //Console.WriteLine("Inside Main, i=" + i);
            //Print();

            Person p1 = new Person();
            p1.ReadName();
            p1.SayHello();

        }


        static void Print()
        {
            Console.WriteLine("Inside Print, i=" + i);
        }

        
    }
}