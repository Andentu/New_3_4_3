namespace New_3_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Semaphore.Red);  
        }
        enum Semaphore : int { 
            Red = 100, Yellow = 200, Green = 300}
    }
}