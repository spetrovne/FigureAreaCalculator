using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator
{
    public class Triangle : Figure
    {
        //private int id;
        //private string type;
        //private double cordA;
        //private double cordB;
        private double cordC;
        //private double area;
        //private double perimeter;




        public Triangle(int id, string type, double cordA, double cordB, double cordC)// : base(id, type, cordA, cordB)
        {
            base.Id = id;
            base.Type = type;
            base.CordA = cordA;
            base.CordB=cordB;
            this.CordC = cordC;
        }
        public double CordC
        {
            get { return cordC; }
            set { cordC = value; }
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
            var s = (base.CordA + base.CordB + cordC) / 2;
            var a = Math.Sqrt(s * (s - base.CordA) * (s - base.CordB) * (s - cordC));

            return a;
        }

        public override double CalculateParameter()
        {
            var p = base.CordA + base.CordB + cordC;
            return p;
        }
    }
}
