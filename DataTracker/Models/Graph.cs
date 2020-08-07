using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTracker.Models
{
    public class Graph
    {
        /// <summary>
        /// Represents the type of graph to be visualized
        /// </summary>
        public enum Type
        { 
            line, bar, pie
        }

        /// <summary>
        /// Represents the type of data the graph tracks
        /// </summary>
        public enum Data
        {
            Time, Money, Measurement, Custom
        }

        public Type GraphType { get; set; }

        public Data GraphData { get; set; }
    }
}
