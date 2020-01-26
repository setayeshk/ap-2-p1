using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ap_2_p1
{
    public class Clock
    {
        private double radias;
        private Point center;
        private int hourlenght;
        private int minutelenght;
        private int secondlenght;
        private DateTime time;
        public Canvas clockk;

        public Clock(Canvas clockk)
        {

            this.clockk = clockk;
            ClockSetting();
            DispatcherTimer Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 0);
            Timer.Start();

        }

        private void ClockSetting()
        {
            center = new Point(clockk.Width / 2, clockk.Height / 2);
            radias = clockk.Width / 2;
            hourlenght = (int)(radias * 0.6);
            minutelenght = (int)(radias * 0.8);
            secondlenght = (int)(radias * 0.9);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            clockk.Children.Clear();
            time = DateTime.Now;
            DrawClockFace();
            //30 daraje میچرخه عقربه ی ساعت شمار تو 1 ساعت برای همین ضرب در 30 میزان جلو رفتن رو
            double radiananglehr = (time.Hour % 12 + time.Minute / 60 + time.Second / 60) * 30 * Math.PI / 180;
            double radiananglemin = (time.Minute) * 6 * Math.PI / 180;
            double radiananglesec = (time.Second) * 6 * Math.PI / 180;
            //Polyline polyline = new Polyline();
            //polyline.Stroke = Brushes.Black;
            //polyline.StrokeThickness = 5;
            //clockk.Children.Add(polyline);
            DrawHands(radiananglehr, radiananglemin, radiananglesec);
        }

        private void DrawLine(double x1, double y1, double x2, double y2, SolidColorBrush color, int thickness, Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1; line.X2 = x2; line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thickness;
            //baraye mahali ke mikeshe va fasele az convas
            line.Margin = margin;

            clockk.Children.Add(line);
        }

        private void DrawHands(double radiananglehr, double radiananglemin, double radiananglesec)
        {

            DrawLine(hourlenght * Math.Sin(radiananglehr), -hourlenght * Math.Cos(radiananglehr), 0, 0,
                Brushes.LightBlue, 8, new Thickness(center.X, center.Y, 0, 0));

            DrawLine(minutelenght * Math.Sin(radiananglemin), -minutelenght * Math.Cos(radiananglemin), 0, 0,
                Brushes.LightBlue, 5, new Thickness(center.X, center.Y, 0, 0));

            DrawLine(secondlenght * Math.Sin(radiananglesec), -secondlenght * Math.Cos(radiananglesec), 0, 0,
                Brushes.LightBlue, 3, new Thickness(center.X, center.Y, 0, 0));

        }

        private void DrawClockFace()
        {
            int Lenght;
            int strokeThickness;
            SolidColorBrush strokeColor;

            for (int deg = 0; deg < 360; deg += 6)
            {
                double rad = deg * Math.PI / 180;
                if (deg % 30 == 0)
                {
                    Lenght = (int)(radias * 0.9);
                    strokeThickness = 5;
                    strokeColor = Brushes.Gray;
                }
                else
                {
                    Lenght = (int)(radias * 0.95);
                    strokeThickness = 3;
                    strokeColor = Brushes.Cyan;
                }

                DrawLine(Lenght * Math.Sin(rad), -Lenght * Math.Cos(rad), (radias - 2) * Math.Sin(rad), -(radias - 2) * Math.Cos(rad),
                    strokeColor, strokeThickness, new Thickness(center.X, center.Y, 0, 0));
            }
        }
    }
}