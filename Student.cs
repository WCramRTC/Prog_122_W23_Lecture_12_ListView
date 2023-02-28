using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_W23_Lecture_12_ListView
{
    internal class Student
    {
        // Fields
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        // Constructor
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = -1;
            _genEdGrade = -1;
        }

        // Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }
        public double Average { get => StudentAverage(); }


        private double StudentAverage()
        {
            return (_csiGrade + _genEdGrade) / 2;
        }

    }
}
