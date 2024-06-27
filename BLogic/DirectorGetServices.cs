using DL;
using System;
using System.Collections.Generic;
using TheModel;

namespace BLogic
{
    public class DirectorGetServices
    {
        public List<Directors> GetAllDirectors()
        {
            DirectorData directorData = new DirectorData();

            return directorData.GetDirectors();
        }

     

        public Directors GetDirectors(string Director, string Movie)
        {
            Directors foundDirectors = new Directors();

            foreach(var director in GetAllDirectors())
            {
                if(director.Director == Director && director.Movie == Movie)
                {
                    foundDirectors = director;
                }
            }
            return foundDirectors;
        }

        public Directors GetDirectors(string Director)
        {
            Directors foundDirectors = new Directors();

            foreach (var director in GetAllDirectors())
            {
                if (director.Director == Director)
                {
                    foundDirectors = director;
                }
            }

            return foundDirectors ;
        }

    }
}
