using DL;
using TheModel;
using BLogic;

namespace Client
{
        public class Program
    {
        static void Main(string[] args)
        {
            DirectorGetServices getServices = new DirectorGetServices();

            var direc = getServices.GetAllDirectors();

            foreach (var item in direc)
            {
                Console.WriteLine(item.Director);
                Console.WriteLine(item.Movie);
                Console.WriteLine();
            }
        }
    }
}
