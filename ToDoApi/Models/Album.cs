using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class Album
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        DateTime YearPublished { get; set; }
    }
}
