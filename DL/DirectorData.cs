using TheModel;

namespace DL
{
    public class DirectorData
    {
        List<Directors> director;
        SQLDbData sqlData;
        public DirectorData()
        {
            director = new List<Directors>();
            sqlData = new SQLDbData();
        }

        public List<Directors> GetDirectors()
        {
            director = sqlData.GetDirectors();
            return director;
        }

        public int AddDirectors(Directors director)
        {
            
            return sqlData.AddDirector(director.Director, director.Movie);
        }

        public int UpdateDirectors(Directors director)
        {
            return sqlData.UpdateDirector(director.Director, director.Movie);

        }
        public int DeleteDirector(Directors director)
        {
            return sqlData.DeleteDirector(director.Director);
        }

    }
}