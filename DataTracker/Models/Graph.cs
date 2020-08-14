using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataTracker.Models
{
    public class Graph
    {
        [Required]
        [Display(Name = "Graph Name")]
        public string GraphName { get; set; }

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

        [Display(Name = "Graph Type")]
        public Type GraphType { get; set; }

        [Display(Name = "Graph Data")]
        public Data GraphData { get; set; }
    }
}
