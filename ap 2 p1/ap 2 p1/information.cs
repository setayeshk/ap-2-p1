using System.Collections.Generic;

namespace ap_2_p1
{
    public class information
    {
        public string firstname;
        public string lastname;
        public int age;
        public string city;
        public string equations;
        public string answers;


        public static List<information> data = new List<information>();
        public static int tedad;
        public information(string firstname,string lastname,string city, int age, string equations,string answers)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.answers = answers;
            this.city = city;
            information.data.Add(this);
            tedad ++;
        }
        public override string ToString()
        {
            return $"{firstname} {lastname} {city} {age} {equations} {answers}";
        }
    }
}