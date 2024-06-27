using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogic
{
    public class DirectorValidationServices
    {
        DirectorGetServices getServices = new DirectorGetServices();

        public bool CheckIfDirectorExists(string Director)
        {
            bool result = getServices.GetDirectors(Director) != null;
            return result;


        }

        public bool CheckIfDrecExists(string Director, string Movie) { 
        
        bool result = getServices.GetDirectors(Director, Movie) != null;
            return result;
        
        }
    }
}
