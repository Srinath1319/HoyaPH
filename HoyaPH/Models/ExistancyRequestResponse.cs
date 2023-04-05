using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoyaPH.Model
{
    public class Location
    {
        public string UserName { get; set; }
    }

    public class ExistancyRequest
    {
        public string ActionType { get; set; }
        public Location Location { get; set; }
    }
}
