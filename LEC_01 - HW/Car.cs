using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_01___HW
{
    internal class Car
    {
        string _company;
        int _plate;
        int _model;

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        public int Plate
        {
            get { return _plate; }
            set { _plate = value; }
        }
        public int Model
        {
            get { return _model; }
            set
            {
                if (value < 1991)
                    return;
                _model = value;
            }
        }
        public void printCN()
        {
            Console.WriteLine($"Your Car Company Name Is: {Company}");
        }

        public void printModel()
        {
            Console.WriteLine($"Your Car Model Is: {Model}");
        }

        public void printLP()
        {
            Console.WriteLine($"Your Car License Plate Is: {Plate}");
        }
    }
}
