using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    internal class Watcher
    {
        private String fullname;
        private DateTime birthDate;

        public Watcher (string fullname, DateTime birthDate)
        {
            this.fullname = fullname;
            this.birthDate = birthDate;
        }

        public bool IsMajor()
        {
            throw new NotImplementedException();
        }

        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
