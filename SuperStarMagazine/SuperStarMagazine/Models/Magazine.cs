using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperStarMagazine.Models
{
    public class Magazine
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public double Price { get; set; }

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}