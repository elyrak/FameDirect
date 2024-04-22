using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheModel;

namespace DL
{

    public class DirecList
    {
        List<Directors> list = new List<Directors>();
        

        public DirecList()
        {

            Directors Greta = new Directors();
            Greta.director = "  Greta Gerwig";
            Greta.moviesName = """
                > Hannah Takes the Stairs [co-writer] (2007)

                > Nights and Weekends [co-writer co-director] (2008)

                > Northern Comfort [writer] (2010)

                > Lady Bird [director] (2017)

                > Little Women [director] (2019)

                > Barbie [director] (2023)
                """;
            Greta.tvSeriesName = """
                > China IL (2008)

                > On Story (2018)
                """
               ;
            list.Add(Greta);

            Directors Nolan = new Directors();
            Nolan.director = "  Christopher Nolan";
            Nolan.moviesName = """   
                >  Following (1998)
                > Insomnia (2002)
                > The Dark Knight Rises (2012)
                > Batman Begins (2005)
                > Tenet (2020)
                > Memento (2000)
                > Inception (2010)
                > Interstellar (2014)
                > The Prestige (2006)
                > The Dark Knight (2008)
                > Oppenheimer (2023)
                > Dunkirk (2017)
                """;
            Nolan.tvSeriesName = """ 
                > 100 Years of Warner Bros (2023)

                > The Story of Film: An Odyssey (2011)
                """
            ;
            list.Add(Nolan);
            Directors DanielKwan = new Directors();

            DanielKwan.director = "  Daniel Kwan";
            DanielKwan.moviesName = "" +
                "> Everything Everywhere All at Once (2022)";
            DanielKwan.tvSeriesName = """
                > Awkwafina Is Nora from Queens TV (2020)
                > Legion TV (2017-2019)
                > Childrens Hospital TV (2008 - 2016)
                """
            ;
            list.Add(DanielKwan);

            Directors Speilberg = new Directors();
            Speilberg.director = "  Steven Speilberg";
            Speilberg.moviesName = """
                > Empire of the Sun (1987)
                > Indiana Jones and the Last Crusade (1989)
                > Always (1989)
                > Hook (1991)
                > Schindler's List (1993)
                > Jurassic Park (1993)
                > Catch me if you Can (2002)
                > War of Worlds (2005)
                > Lincoln (2012)
                > The BFG (2016)
                > West Side Story (2021)
                """;
            Speilberg.tvSeriesName = """ 
            > Five Came Back (2017)
            > Ready Player One (2018)
            > James Cameron Story of Science Fiction (2018) 
            """
            ;
            list.Add(Speilberg);

            Directors Woody = new Directors();
            Woody.director = "  Woody Allen";
            Woody.moviesName = """ 
                > Everyone Says I Love You (1996)
                > Antz(1998)
                > New York Stories (1989)
                > Anything Else (2003)
                """;
            list.Add(Woody);

            Directors Heckerling = new Directors();
            Heckerling.director = "  Amy Heckerling";
            Heckerling.moviesName = """  
                 > Life on the Flips (1988)
                 > A night at the Roxbury (1998) 
                 > Loser (2000)
               """;
            Heckerling.tvSeriesName = """
                > Clueless (1996)
                > The Office (2005)
                > Gossip Girl (2007)
                > The Carrie Diaries (2013)
                > Weird City (2019)
               """;
            list.Add(Heckerling);
        }

        public List<Directors> GetDirectors()
        {
            return list;
        }




    }
}
