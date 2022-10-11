using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    internal class Movie
    {
        private String title;
        private DateTime publishedAt;
        private List<Watcher> watchers;

        public Movie(string title, DateTime publishedAt)
        {
            this.title = title;
            this.publishedAt = publishedAt;
        }

        public int PublishedYear
        {
            get
            {
                return publishedAt.Year;
            }
        }

        public List<Watcher> Watchers
        {
            get 
            { 
                return watchers; 
            }
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
