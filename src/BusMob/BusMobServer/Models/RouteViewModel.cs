using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusMobServer.Models
{
    public class RouteViewModel
    {
        public RouteViewModel()
        {
            Parts = new List<RoutePartViewModel>();
        }

        public string Start { get; set; }
        public string End { get; set; }
        public int TotalTime { get; set; }
        public int WalkDistance { get; set; }
        public List<RoutePartViewModel> Parts { get; set; }
    }
}
