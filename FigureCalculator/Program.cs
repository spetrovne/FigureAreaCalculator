using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FigureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"crash-course-task-input.json");
            var figureCollection = JsonConvert.DeserializeObject<FigureCollection>(input);
            var concrateFigures = new List<Figure>();

            for (int i = 0; i < figureCollection.Figures.Count; i++)
            {
                if (figureCollection.Figures[i].Type== "triangle")
                {
                    var id = figureCollection.Figures[i].Id;
                    var type = figureCollection.Figures[i].Type;
                    var x1 = figureCollection.Figures[i].Coordinates[0].X;
                    var y1 = figureCollection.Figures[i].Coordinates[0].Y;
                    var x2 = figureCollection.Figures[i].Coordinates[1].X;
                    var y2 = figureCollection.Figures[i].Coordinates[1].Y;
                    var x3 = figureCollection.Figures[i].Coordinates[2].X;
                    var y3 = figureCollection.Figures[i].Coordinates[2].Y;

                    var cordA=Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2 - y1), 2));
                    var cordB = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                    var cordC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));

                    var triangle = new Triangle(id, type, cordA, cordB, cordC);
                    concrateFigures.Add(triangle);

                    triangle.Area=triangle.CalculateArea();
                    triangle.Perimeter = triangle.CalculateParameter();

                }
                if (figureCollection.Figures[i].Type == "rectangle")
                {
                    var id = figureCollection.Figures[i].Id;
                    var type = figureCollection.Figures[i].Type;
                    var x1 = figureCollection.Figures[i].Coordinates[0].X;
                    var y1 = figureCollection.Figures[i].Coordinates[0].Y;
                    var x2 = figureCollection.Figures[i].Coordinates[1].X;
                    var y2 = figureCollection.Figures[i].Coordinates[1].Y;
                    var x3 = figureCollection.Figures[i].Coordinates[2].X;
                    var y3 = figureCollection.Figures[i].Coordinates[2].Y;

                    var cordA = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    var cordB = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

                    var rectangle = new Rectangle(id,type,cordA,cordB);
                    concrateFigures.Add(rectangle);

                    rectangle.Area = rectangle.CalculateArea();
                    rectangle.Perimeter = rectangle.CalculateParameter();

                }
                if (figureCollection.Figures[i].Type == "square")
                {
                    var id = figureCollection.Figures[i].Id;
                    var type = figureCollection.Figures[i].Type;
                    var x1 = figureCollection.Figures[i].Coordinates[0].X;
                    var y1 = figureCollection.Figures[i].Coordinates[0].Y;
                    var x2 = figureCollection.Figures[i].Coordinates[1].X;
                    var y2 = figureCollection.Figures[i].Coordinates[1].Y;
                   

                    var cordA = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    

                    var square = new Square(id, type, cordA);
                    concrateFigures.Add(square);

                    square.Area = square.CalculateArea();
                    square.Perimeter = square.CalculateParameter();

                }
            }


            var figures = JsonConvert.SerializeObject(concrateFigures.Select(x => new {x.Id, x.Area, x.Perimeter }));
            File.WriteAllText(@"figures.json", figures);
            Console.WriteLine(figures);
        }
    }
}
