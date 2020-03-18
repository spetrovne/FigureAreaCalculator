using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalculator
{
    class FigureCollection
    {
        private List<Figure> figures;

        public List<Figure> Figures { get => figures; set => figures = value; }
    }
}
