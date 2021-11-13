using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess.Entities.Models
{
    internal class CityModel
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
