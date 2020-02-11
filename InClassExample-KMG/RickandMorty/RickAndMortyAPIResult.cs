using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kala Rodriguez

namespace RickandMorty
{
    class RickAndMortyAPIResult
    {
        public InfoObj info { get; set; }

        public List<ResultObj> results { get; set; }
    }

    public class InfoObj
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }

    }

    public class ResultObj
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }

    }
}
