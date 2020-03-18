using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator
{
    class Square: Figure
    {
        //private int id;
        //private string type;
        //private double cordA;
        //private double cordB;
        //private double area;
        //private double perimeter;

        public Square(int id, string type, double cordA)// : base(id, type, cordA, cordB)
        {
            base.Id = id;
            base.Type = type;
            base.CordA = cordA;
           
        }

        //public double Perimeter
        //{
        //    get { return perimeter; }
        //    set { perimeter = value; }
        //}

        //public double Area
        //{
        //    get { return area; }
        //    set { area = value; }
        //}

        //public double CordB
        //{
        //    get { return cordB; }
        //    set { cordB = value; }
        //}

        //public double CordA
        //{
        //    get { return cordA; }
        //    set { cordA = value; }
        //}


        //public string Type
        //{
        //    get { return type; }
        //    set { type = value; }
        //}


        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public override double CalculateArea()
        {
            double calcS = base.CordA * base.CordB;

            return calcS;
        }

        public override double CalculateParameter()
        {
            double calcP = 4*base.CordA;

            return calcP;
        }
    }
}
