using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ap_2_p1
{
    public class Coordinate
    {
        public Canvas Canvas;
        public double scale;
        public string MinX = "-10";
        public string MinY = "-10";
        public string MaxX = "10";
        public string MaxY = "10";
        public double TransformY(double y, double minY, double maxY, double scale)
        {
            return (maxY - y) * 438 / (maxY - minY);
        }
        public Point convert(Point p)
        {
            p.Y = -p.Y;
            p.X += 400;
            p.Y += 219;
            return p;
        }

        public static double TransformX(double x, double minX, double maxX, double scale)
        {
            //مثلا اگه صفر بود بشه 400 یعنی بشه یک دوم ضرب در 800 نسبت رو به دست بیاریم بعد به اندازه ی اندازه ی کانوس بریم جلو
            return (x - minX) * 800 / (maxX - minX);
        }
        public Coordinate(Canvas Canvas, string minX = "-10", string minY = "-10", string maxX = "10", string maxY = "10", double scale = 1, double delta = 0)
        {
            this.Canvas = Canvas;
            this.MinX = ((double.Parse(minX.ToString()) + delta) * scale).ToString();
            this.MinY = ((double.Parse(minY.ToString())) * scale).ToString();
            this.MaxX = ((double.Parse(maxX.ToString()) + delta) * scale).ToString();
            this.MaxY = ((double.Parse(maxY.ToString())) * scale).ToString();
            this.Canvas = Canvas;
           // Polyline polyline = new Polyline();
           // polyline.Points.Add(new Point(0, 0));
            //polyline.Points.Add(new Point(400, 400));
            //polyline.Points.Add(new Point(390, 400));
            //polyline.Stroke = Brushes.Black;
            //polyline.StrokeThickness = 2;
            //Canvas.Children.Add(polyline);

            //Polyline polyline2 = new Polyline();
            //// polyline.Points.Add(new Point(0, 0));
            //polyline2.Points.Add(new Point(TransformX(0,-10,10,1),TransformY(0,-10,10,1)));
            //polyline2.Points.Add(new Point(TransformX(5,-10,10,1), TransformY(5,-10,10,1)));
            //polyline2.Stroke = Brushes.Blue;
            //polyline2.StrokeThickness = 2;
            //Canvas.Children.Add(polyline2);
            for (double i = Canvas.Height / 2; i < Canvas.Height; i += Canvas.Height / 2 / double.Parse(maxX) * scale)
            {
                drawline(i, Canvas, "ofoghy", 1, Brushes.LightGray, false);
            }
            for (double i = Canvas.Height / 2; i > 0; i -= Canvas.Height / 2 / Math.Abs(double.Parse(minX)) * scale)
            {
                drawline(i, Canvas, "ofoghy", 1, Brushes.LightGray, false);
            }
            for (double i = Canvas.Width / 2; i < Canvas.Width; i += Canvas.Width / 2 / double.Parse(maxY) * scale)
            {
                drawline(i, Canvas, "amodi", 1, Brushes.LightGray, false);
            }
            for (double i = Canvas.Width / 2; i > 0; i -= Canvas.Width / 2 / Math.Abs(double.Parse(minY)) * scale)
            {
                drawline(i, Canvas, "amodi", 1, Brushes.LightGray, false);
            }
            drawline(Canvas.Height / 2, Canvas, "ofoghy", 3, Brushes.Black, true);
            drawline(Canvas.Width / 2, Canvas, "amodi", 3, Brushes.Black, true);


        }

        public void drawline(double y1, Canvas Canvas, string ofogamod, int strokeThickness, SolidColorBrush colorBrush, bool mehvar)
        {

            Line line = new Line();
            if (ofogamod == "ofoghy")
            {
                line.Y1 = y1;
                line.X1 = 0;
                line.X2 = 800;
                line.Y2 = y1;
            }
            else
            {
                line.X1 = y1;
                line.Y1 = 0;
                line.X2 = y1;
                line.Y2 = 438;
            }

            line.Stroke = colorBrush;
            line.StrokeThickness = strokeThickness;
            Canvas.Children.Add(line);
        }

    }
}