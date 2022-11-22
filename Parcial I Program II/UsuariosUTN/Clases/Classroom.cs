using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosUTN.Clases
{
    public class Classroom
    {
        private int _idClassroom;
        private string _name;

        public Classroom(int idClassroom, string name)
        {
            _idClassroom = idClassroom;
            _name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public int IdClassroom { get => _idClassroom; }
        public string Name { get => _name; }
    }
}
