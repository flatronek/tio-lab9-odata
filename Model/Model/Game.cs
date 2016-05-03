using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CreatorCompany { get; set; }
        public int Year { get; set; }
        public int AgeRate { get; set; }
    }
}
