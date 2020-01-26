using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using Npgsql;
using System.IO;
using Path = System.Windows.Shapes.Path;

namespace ap_2_p1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public enum numbers
    {
        zero,one,two,three,four,five,six,seven,eight,nine,ten,eleven,twelve
    }
    public partial class MainWindow : Window
    {
        public static information informationss;
        
        public MainWindow()
        {
            InitializeComponent();
            Coordinate coordinate = new Coordinate(coordinate_plane);
             Clock clockpart = new Clock(watch);
            //  Function function=new Function
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string check = $"{name.Text} {last_name.Text} {city.Text} {age.Text} {equations.Text}";
            string[] checks = check.Split(' ');
            StreamReader stream = new StreamReader("informations.txt");

            bool exist = false;
            List<string> add = new List<string>();
            for (int i = 0;; i++)
            {

                string temp = stream.ReadLine();
                if (temp == null || temp == "")
                    break;
               
                    add.Add(temp.ToString());
             

                string[] tempp = temp.Split(' ');
               

                if (temp != null&& temp!="" && temp == check)
                    exist = true;
                else if (temp != null&&temp!="" && checks[4] == tempp[4] && check != temp)
                    soloutions.Text = tempp[5];
          
               
               
            }
            stream.Close();
            if (!exist)
            {
                stream.Close();
                StreamWriter streamWriter = new StreamWriter("informations.txt");
                Calculateequation calculateequation = new Calculateequation(equations, soloutions);
                for(int i = 0; i < add.Count; i++)
                {
                    streamWriter.WriteLine($"{add[i].ToString()}");
                }
               informationss = new information(checks[0], checks[1], checks[2],
                    int.Parse(checks[3]), checks[4], soloutions.Text);
                streamWriter.WriteLine(check + $" {soloutions.Text}");  
                streamWriter.Close();
                
            }
            
        }
       // public delegate void methods(string a);

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            //methods methods = null;
            StreamReader streamReader = new StreamReader("informations.txt");
            string[] temp = streamReader.ReadToEnd().Split('\n');
            //chon oon bala new mishe va to constructor gazashtam age clear nakonam do bar neveshte mishe
            information.data.Clear();
            for(int i = 0; i < temp.Length-1; i++)
            {
                string[] tempp = temp[i].Split(' ');
                new information(tempp[0], tempp[1], tempp[2],
                    int.Parse(tempp[3]), tempp[4], tempp[5]);
            }
            List<information> infosaver = information.data;
          
            {
                if (Peopleolderthan.Text.Trim() != "")
                    peopleolderthan(Peopleolderthan.Text);
                if (Peopleyoungerthan.Text.Trim() != "")
                    peopleyoungerthan(Peopleyoungerthan.Text);
                if (Answeroftheequation.Text.Trim() != "")
                     answeroftheequation(Answeroftheequation.Text);
                if (Namestartwith.Text.Trim() != "")
                    namestartwith(Namestartwith.Text);
                if (Peoplenamed.Text.Trim() != "")
                    peoplenamed(Peoplenamed.Text);
                if (Agemodaiszero.Text.Trim() != "")
                   agemodaiszero(Agemodaiszero.Text);
                if (Peoplecity.Text.Trim() != "")
                    peoplecity(Peoplecity.Text);
                if (Peoplelastname.Text.Trim() != "")
                   peoplelastname(Peoplelastname.Text);
                if (Lastnamestartwith.Text.Trim() != "")
                   lastnamestartwith(Lastnamestartwith.Text);
                if (Peoplecitystartwith.Text.Trim() != "")
                    peoplecitystartwith(Peoplecitystartwith.Text);
                if (Equation.Text.Trim() != "")
                   isequations(Equation.Text);
                if (Numberofequations.Text.Trim() != "")
                    numberofequations(Numberofequations.Text);
            }
            string answer = null;
           for(int i = 0; i < information.data.Count(); i++)
            {
                answer += information.data[i].ToString();
                answer += "\n";

            }
            people.Text = answer;
            information.data = infosaver;

        }
        //ya hameye ina to ye class abstract va harkodom ye textbox begiran va ...
        public void peopleolderthan(string number)
        {
            information.data = information.data.Where(a => a.age > int.Parse(number)).ToList();
        }
        public void peopleyoungerthan(string number)
        {
            information.data = information.data.Where(a => a.age < int.Parse(number)).ToList();
        }
        public void answeroftheequation(string results)
        {
            information.data = information.data.Where(a => a.answers == results).ToList();
        }
        public void namestartwith(string startwith)
        {
           information.data = information.data.Where(a => a.firstname[0].ToString() == startwith).ToList();
        }
        public void peoplenamed(string name)
        {
           information.data = information.data.Where(a => a.firstname == name).ToList();
        }
        public void agemodaiszero(string b)
        {
            //where ienumarable(foreachmishe zad) برمیردونه تو لیست که بریزیم داخل یه لیت
           information.data = information.data.Where(a => a.age%int.Parse(b)==0).ToList();
          //  string[] temp = information.data.Where(a => a.age % int.Parse(b) == 0);
        }
        public void peoplecity(string name)
        {
           information.data = information.data.Where(a => a.city == name).ToList();
        }
        public void peoplelastname(string name)
        {
           information.data = information.data.Where(a => a.lastname.ToString() == name).ToList();
        }
        public void lastnamestartwith(string startwith)
        {
           information.data = information.data.Where(a => a.lastname[0].ToString() == startwith).ToList();
        }

        public void peoplecitystartwith(string startwith)
        {
           information.data = information.data.Where(a => a.city[0].ToString() == startwith).ToList();
        }
        public void isequations(string equations)
        {
           information.data = information.data.Where(a => a.equations == equations).ToList();
        }
        public void numberofequations(string numequations)
        {
           information.data = information.data.Where(a => a.equations.Split(',').Length == int.Parse(numequations)).ToList();
        }
        private void Clear_function_Click(object sender, RoutedEventArgs e)
        {
            coordinate_plane.Children.Clear();
        }
        private void Draw_function_Click(object sender, RoutedEventArgs e)
        {

            Coordinate coordinate = new Coordinate(coordinate_plane, min_x.Text, min_y.Text, max_x.Text, max_y.Text);
            Function function = new Function(function1.Text, min_x.Text, min_y.Text, max_x.Text, max_y.Text, coordinate_plane);
          //  coordinate_plane.MouseWheel += MouseWheelHandler;
        }
        //private void DispatcherTimer_Tick(object sender, EventArgs e)
        //{
        //    DateTime time = DateTime.Now;
        //    int hour = time.Hour;
        //    int minute = time.Minute;
        //    int second = time.Second;
        //    int hangle = (hour) * 30 + (minute) * 6 + (second) / 10;
        //    //   int mangle=()
        //    LineGeometry hline = new LineGeometry();
        //    //وسط دایره
        //    hline.StartPoint = new Point(86, 86);
        //    hline.EndPoint = new Point(86 - Math.Abs(Math.Sin(hangle)) * 86, 86 + Math.Abs(Math.Cos(hangle)) * 86);
        //    GeometryGroup linegroup = new GeometryGroup();
        //    linegroup.Children.Add(hline);
        //    Path path = new Path();
        //    path.Data = linegroup;
        //    path.StrokeThickness = 3;
        //    path.Stroke = path.Fill = Brushes.Black;
        //    watch.Children.Add(path);

        //}

    }
}
