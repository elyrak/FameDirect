using System;
using DL;
using TheModel;

namespace BLogic
{
    public class DirectorCud
    {
        DirectorValidationServices validationServices = new DirectorValidationServices();
        DirectorData directorsData = new DirectorData();

        public bool CreateDirectors(Directors director)
        {
            bool result = false;

             if (validationServices.CheckIfDirectorExists(director.Director))
                {
                result = directorsData.AddDirectors(director) > 0;
                }

            return result;
        }

        public bool CreateDirectors(string Director, string Movie)
        {
            Directors director = new Directors { Director = Director, Movie = Movie };

            return CreateDirectors(director);
        }

        public bool UpdateDirectors(Directors director)
        {
            bool result = false;

            if (validationServices.CheckIfDirectorExists(director.Director))
            {
               result = directorsData.UpdateDirectors(director) > 0;
            }

            return result;
        }
        
        public bool UpdateDirectors(string Director, string Movie)
        {
            Directors director = new Directors { Director = Director, Movie = Movie };

            return UpdateDirectors(director);
        }

        public bool DeleteDirectors(Directors director)
        {
            bool result = false;

            if (validationServices.CheckIfDirectorExists(director.Director))
            {
                result = directorsData.DeleteDirector(director) > 0;
            }

            return result;
        }
    }

    }

