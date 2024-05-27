using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemi_CookieCookbook.Model
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }

        public Ingridient(int id, string name, string instruction)
        {
            Id = id;
            Name = name;
            Instruction = instruction;
        }
    }
}
