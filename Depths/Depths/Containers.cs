using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class Containers
    {
        public string ContainerName { get; set; }
        public string ContainerDescription { get; set; }
        public List<Items> Contents { get; set; }
    }
}
