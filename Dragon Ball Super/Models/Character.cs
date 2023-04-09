using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Ball_Super.Models
{
    public class Character
    {
        public string id { get; set; }
        public string name { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public string bio { get; set; }
        public string health { get; set; }
        public string attack { get; set; }
        public string defense { get; set; }
        public string kiRestoreSpeed { get; set; }
        public List<string> abilities { get; set; }
        public string img { get; set; }
    }
}