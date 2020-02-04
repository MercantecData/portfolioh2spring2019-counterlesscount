using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //A)
            Dictionary<string, int> values = new Dictionary<string, int>();
            values.Add("A", 1);         values.Add("AA", 134574367);
            values.Add("B", 145);       values.Add("AB", 1346743674);
            values.Add("C", 1346573);   values.Add("AC", 134673467);
            values.Add("D", 13457);     values.Add("AD", 134673467);
            values.Add("E", 13574357);  values.Add("AE", 256542571);

            //B)
            Dictionary<float, bool> morevalues = new Dictionary<float, bool>();
            morevalues.Add(1, true); morevalues.Add(6, false);
            morevalues.Add(2, true); morevalues.Add(7, false);
            morevalues.Add(3, true); morevalues.Add(8, false);
            morevalues.Add(4, true); morevalues.Add(9, false);
            morevalues.Add(5, true); morevalues.Add(10, false);

            //C)
            Dictionary<Person, int> anothervalue = new Dictionary<Person, int>();
            anothervalue.Add(new Person {Name = "Person1", Age = 22 }, 1);
        }
    }

    //Class that saves Name and Age of a person.
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public bool Equals(Person person)
        {
            return person.Name.Equals(Name) && person.Age.Equals(Age);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}
