using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_core_visiual_studio.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        
                       
         static Repository()
        {
            _movies = new List<Movie>
            {
                new Movie(){id=1,Name="Shazam",Description="Shazam",İmageUrl="https://im0-tub-tr.yandex.net/i?id=eb0a67fca351b050f2ab5d70b1988f67&n=13" },
                 new Movie(){id=2,Name="Amazing Grace",Description="Amazing Grace",İmageUrl="https://image.tmdb.org/t/p/w400/zr48JEuwxcYM03NcdJU6qWMHPtq.jpg" },
                  new Movie(){id=3,Name="High Life",Description="High Life",İmageUrl="https://im0-tub-tr.yandex.net/i?id=ed5a20a760e6012ba9635d3a52330af0&n=13" },
                   new Movie(){id=4,Name="Billboard",Description="BillBoard",İmageUrl="https://im0-tub-tr.yandex.net/i?id=58577dd4aa3306047d20a30aca2dcec3&n=13" },
                    new Movie(){id=5,Name="Storm Boy",Description="Storm Boy",İmageUrl="https://im0-tub-tr.yandex.net/i?id=e8ada37a598e2b69763f80b2089a0000&n=13" }
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.id == id);
        }
    }
}
