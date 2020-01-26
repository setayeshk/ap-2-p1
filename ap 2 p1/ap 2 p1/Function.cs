using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ap_2_p1
{
    class Function
    {

        public string MinX;
        public string MinY;
        public string MaxX;
        public string MaxY;

        public double TransformY(double y, double minY, double maxY, double scale)
        {
            return (maxY - y) * 438 / (maxY - minY);
        }
        //public Point convert(Point p)
        //{
        //    p.Y = -p.Y;
        //    p.X += 400;
        //    p.Y += 219;
        //    return p;
        //}

        public static double TransformX(double x, double minX, double maxX, double scale)
        {
            return (x - minX) * 800 / (maxX - minX);
        }

        public string Func;
        public Polyline polyline = new Polyline();

        PointCollection PointsCollection = new PointCollection();

        public Canvas coordinateplane;


        public Function(string func, string minX, string minY, string maxX, string maxY, Canvas coordinateplane, double scale = 1, double delta = 0)
        {
            this.MinX = (double.Parse(minX.ToString()) * scale).ToString();
            this.MinY = (double.Parse(minY.ToString()) * scale).ToString();
            this.MaxX = (double.Parse(maxX.ToString()) * scale).ToString();
            this.MaxY = (double.Parse(maxY.ToString()) * scale).ToString();
            this.Func = func;

            this.coordinateplane = coordinateplane;

            for (double i = double.Parse((-coordinateplane.Width / 2).ToString()) + delta; i <= double.Parse((coordinateplane.Width / 2).ToString()); i += (coordinateplane.Width / coordinateplane.Height * double.Parse(maxX) / double.Parse(maxY)) * 0.01 * scale)
            {
                string func2 = null;

                for (int j = 0; j < func.Length; j++)
                {
                    if (func[j] == '^')
                    {

                        for (int k = 1; k < int.Parse(func[j + 1].ToString()); k++)
                        {
                            if (char.IsLetter(func[j - 1]))
                            {
                                func2 += $"*{i}";
                            }
                            else
                                func2 += $"*{func[j - 1]}";

                        }
                        //که عدد توان هم حساب بشه تو جلو رفتن
                        j++;
                    }
                    else if (func[j] == '-')
                    {
                        func2 += -Func[j + 1];
                        j++;
                    }
                    else if (char.IsLetter(func[j]) && j - 1 >= 0 && char.IsNumber(func[j - 1]) && (func[j - 1] != '+' || func[j - 1] != '-'))
                    {
                        func2 += $"*{i}";
                    }

                    else if (char.IsLetter(func[j]))
                        func2 += $"{i}";
                    else
                        func2 += func[j];
                }
                //وقتی بریم توی توان 4 عدد خیلی بزرگ میشه و اور فلو میخوره و نمیتونه ذخیره بکنه
                double c = Convert.ToDouble(new DataTable().Compute(func2, null));

                polyline.Points.Add(((new Point(TransformX(i, double.Parse(MinX), double.Parse(MaxX), scale),
                    TransformY(c, double.Parse(MinY), double.Parse(MaxY), scale)))));

            }

            polyline.Stroke = Brushes.Black;
            polyline.StrokeThickness = 2;
            polyline.FillRule = FillRule.EvenOdd;
            coordinateplane.Children.Add(polyline);
        }


    }
}