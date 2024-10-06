using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GuessMyNumber myNumber = new GuessMyNumber();
            myNumber.generateNumbers();

        }
      
    }
}
