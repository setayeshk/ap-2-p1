using System;
using System.Linq;
using System.Windows.Controls;

namespace ap_2_p1
{
    public class Calculateequation
    {
        public TextBox textbox;
        public TextBlock textBlock;
      
        public Calculateequation(TextBox textBox, TextBlock textBlock)
        {
            this.textbox = textBox;
            this.textBlock = textBlock;
           
            forcalculate(textbox, textBlock);
        }
        //متغیر ها رو برمیگردونه
        public static string RemoveBadChars(string input)
        {
            char[] chars = new char[input.Length];
            int myindex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if ((int)c >= 65 && (int)c <= 90)
                {

                    chars[myindex] = c;
                    myindex++;
                }
                else if ((int)c >= 97 && (int)c <= 122)
                {
                    chars[myindex] = c;
                    myindex++;
                }
                else if ((int)c == 44)
                {

                    chars[myindex] = c;
                    myindex++;
                }
            }

            input = new string(chars);
            return input;
        }
        public static Matrix<double> replacecolumn(Matrix<double> a, Matrix<double> soloution, int k)
        {
            for (int j = 0; j < a.Count(); j++)
            {
                a[j][k] = soloution[j][0];
            }
            return a;
        }

        public static int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static Matrix<double> makefactorless(Matrix<double> a, int k, int p)
        {
            int order = a.Count();
            Matrix<double> output = new Matrix<double>(order - 1, order - 1);
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != k)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != p)
                        {
                            output[x][y] = a[m][n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }


        public static double Determinant(Matrix<double> a)
        {
            int n = a.Count();
            if (n > 2)
            {
                double value = 0;
                for (int j = 0; j < n; j++)
                {
                    Matrix<double> temp = makefactorless(a, 0, j);
                    value = value + a[0][j] * (SignOfElement(0, j) * Determinant(temp));
                }
                return value;
            }
            else if (n == 2)
            {
                return ((a[0][0] * a[1][1]) - (a[1][0] * a[0][1]));
            }
            else
            {
                return (a[0][0]);
            }
        }

        public static string makingsumchar(string a)
        {
            string b = null;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != '+' && a[i] != '-')
                {
                    b += a[i];
                }
                else
                {
                    b += '-';
                }
            }
            return b;
        }


        public static void forcalculate(TextBox textBox, TextBlock textBlock)
        {
            string equationsss = textBox.Text;
            string[] equationss = equationsss.Split(',');
            string[] equations = new string[equationss.Length];
            for (int i = 0; i < equationss.Length; i++)
            {
                equations[i] = equationss[i].Split('=')[0];
            }

            string[] aftersame = new string[equationss.Length];

            Matrix<double> forreplace = new Matrix<double>(equationss.Length, 1);
            for (int i = 0; i < equationss.Length; i++)
            {
                forreplace[i][0] = double.Parse(equationss[i].Split('=')[1]);
            }
            Matrix<double> coefficient = new Matrix<double>(equations.Length, equations.Length);
            string example = RemoveBadChars(equations[0]);
            int numberofchar = 0;
            for (int i = 0; i < example.Length; i++)
            {
                if (char.IsLetter(example[i]))
                    numberofchar++;

            }
            for (int i = 0; i < equations.Length; i++)
            {
                string temp = makingsumchar(equations[i]);
                for (int j = 0; j < equations[i].Length; j++)
                {


                    string tempcoefficient = null;
                    int tempint = j;
                    //تا جایی که همه ی عدد ها رو بگیره مثلا 23 تا جایی که 3 رو هم بگیره
                    while (!char.IsLetter(temp[j]) && temp[j] != '-' && j + 1 < temp.Length)
                    {
                        tempcoefficient += temp[j];
                        j++;
                    }
                    j = tempint;
                    int es = 0;
                    //این دو تا if برای این که اگه عدد یک رو وارد نکرده بود 1 در نظر بگیره
                    if (!(j - 1 >= 0 && char.IsNumber(temp[j - 1])))
                    {
                        if ((((j + 1 < temp.Length && (temp[j + 1] == '-') && char.IsLetter(temp[j])) || (equations.Length == 1 && char.IsLetter(temp[j]) && char.IsLetter(temp[j])) || (j - 1 > 0 && temp[j - 1] == '-' && char.IsLetter(temp[j])))) && (tempcoefficient == null && temp[j] != '-'))
                        {
                            tempcoefficient = "1";
                            es = 1;

                        }
                    }

                    if (temp[j] != '-')
                    {
                        for (int k = 0; k < numberofchar; k++)
                        {
                            //عدد خالی نداریم پس کوچک تر مساوی نه و کوچک تر از اندازه ی تمپ
                            if (j + 1 < temp.Length || es == 1)
                            {
                                //این که میره و روزی هر تعداد متغیر چک میکنه که ضریب کدومه باعث میشه اگه جابهجا وارد کردیم مشکلی پیش نیاد
                                if ((j + 1 < temp.Length && tempcoefficient != null && temp[j + 1] == example[k]) || (es == 1 && (temp[j] == example[k])))
                                {

                                    coefficient[i][k] = double.Parse(tempcoefficient);

                                }
                            }
                        }
                    }
                }
            }
            bool theyaresame = false;
            for (int i = 0; i + 1 < equations.Length; i++)
            {
                if (equations[i] == equations[i + 1] || bakhshpazir(coefficient[i], coefficient[i + 1]))
                    theyaresame = true;

            }
            Matrix<double> coefficientsaver = new Matrix<double>(coefficient.Count(), coefficient.Count());
            for (int i = 0; i < coefficient.RowCount; i++)
            {
                for (int j = 0; j < coefficient.ColumnCount; j++)
                {
                    coefficientsaver[i][j] = coefficient[i][j];

                }
            }

            int numberdetnotzero = 0;
            int numberdetzero = 0;
            string maybesoloution = null;
            int detzero = 0;

            for (int k = 0; k < equations.Length; k++)
            {

                double b = Determinant(coefficient);
                double a = (Determinant(replacecolumn(coefficient, forreplace, k)));
                if (b == 0)
                {
                    //تعدادی دترمینان کل صفر میشود(که صفر بودن یا نبودن آن مهم است چون اگر صفر باشد من به تعداد مجهولات یا همان معادله ها گفته اضفه بشه)
                    detzero++;
                }
                if (a != 0)
                {
                    numberdetnotzero++;
                }
                else
                    numberdetzero++;
                maybesoloution += $"{RemoveBadChars(equations[0])[k]}={a / b}";
                for (int i = 0; i < coefficient.RowCount; i++)
                {
                    for (int j = 0; j < coefficient.ColumnCount; j++)
                    {
                        coefficient[i][j] = coefficientsaver[i][j];

                    }
                }
            }

            if (numberdetzero != 0 && numberdetzero != equations.Length && numberdetnotzero == 0 && detzero != 0 && !theyaresame)
            {
                textBlock.Text = "No Soloution";
            }
            else if ((numberdetnotzero == numberdetzero && numberdetzero != 0 && detzero != 0) || (numberdetzero == equations.Length && theyaresame))
            {
                textBlock.Text += "No Unique Soloution";
            }
            else if (maybesoloution.Contains("NaN") || maybesoloution.Contains("∞") || maybesoloution.Contains("-∞"))
            {
                textBlock.Text = "No Soloution";
            }
            else
            {
                textBlock.Text = maybesoloution;
            }
        }

        private static bool bakhshpazir(Vectors<double> Vectors1, Vectors<double> Vectors2)
        {
            int n = Vectors1.Count();
            bool firstmoresecond = true;
            bool result = true;
            for (int i = 0; i < n; i++)
            {
                if (Vectors1[i] < Vectors2[i])
                    firstmoresecond = false;
            }
            for (int i = 0; i < n; i++)
            {
                if (firstmoresecond)
                {
                    if (Vectors1[i] % Vectors2[i] != 0)
                        result = false;
                }
                else
                {
                    if (Vectors2[i] % Vectors1[i] != 0)
                        result = false;
                }
            }
            return result;

        }
    }

}


