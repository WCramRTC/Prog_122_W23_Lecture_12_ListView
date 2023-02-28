using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_12_ListView
{
    
    internal class RaceCar
    {
        string _engine;
        string _color;
        float _tireWare;
        float _bodyWare;
        string _number;

        public RaceCar(string engine, string color, float tireWare, float bodyWare, string number)
        {
            _engine = engine;
            _color = color;
            _tireWare = tireWare;
            _bodyWare = bodyWare;
            _number = number;
        }

        public string Engine { get => _engine; set => _engine = value; }
        public string Color { get => _color; set => _color = value; }
        public float TireWare { get => _tireWare; set => _tireWare = value; }
        public float BodyWare { get => _bodyWare; set => _bodyWare = value; }
        public string Number { get => _number; set => _number = value; }

        public override string ToString()
        {
            return $"{_engine} {_color} {_tireWare} {_bodyWare} {_number}";
        }

    }
}
