using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMobServer.Models
{
    public class RoutePartViewModel
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Instruction { get; set; }
        public string Type { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public string Additional { get; set; }
    }
}
