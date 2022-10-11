using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    internal class Theater
    {
        private List<Movie> movies;

        public void AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public int UniqueWatcherCount
        {
            get
            { 
                return movies.Count; 
            }
        }

        public List<Movie> GetLowTachedMovies(int theshold)
        {
            return movies;
        }

        private List<Watcher> GetAllWathcers;
    }
}
