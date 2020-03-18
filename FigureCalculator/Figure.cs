using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator
{
    public class Figure
    {
        private int id;
        private string type;
        private double cordA;
        private double cordB;
        private double area;
        private double perimeter;
        private List<Coordinates> cooordinates;


        public Figure()
        {
            cooordinates = new List<Coordinates>();
        }
        //public Figure(int id, string type, double cordA,double cordB)
        //{
        //    this.Id = id;
        //    this.Type = type;
        //    this.CordA = cordA;
        //    this.CordB = cordB;
        //}


        public List<Coordinates> Coordinates
        {
            get { return cooordinates; }
            set { cooordinates = value; }
        }
        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        } 

        public double CordB
        {
            get { return cordB; }
            set { cordB = value; }
        }

        public double CordA
        {
            get { return cordA; }
            set { cordA = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public virtual double CalculateArea()
        {
            double calcS=this.cordA*cordB;

            return calcS;
        }

        public virtual double CalculateParameter()
        {
            double calcP = 2*this.cordA + 2*cordB;

            return calcP;
        }
    }
}
