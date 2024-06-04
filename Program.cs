namespace Assignment_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NaturalNumbers(10);

            void NaturalNumbers(int n) 
            {
                if (n == 1)
                {
                    Console.Write(n);
                    
                }
                else 
                { 
                    NaturalNumbers(n - 1);
                    Console.Write(" " + n);
                }
               

                
            }
        }
    }
}
