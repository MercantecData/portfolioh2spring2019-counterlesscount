using System;
using System.Collections.Generic;

namespace Abstract_Classes_and_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person() { Name = "Jepser", Age = 12, Sex = "Male" });
            person.Add(new Person() { Name = "Kim", Age = 22, Sex = "Female" });
            person.Add(new Person() { Name = "Kim", Age = 22, Sex = "Male" });
            person.Add(new Person() { Name = "Kenneth", Age = 42, Sex = "Male" });
            person.Add(new Person() { Name = "July", Age = 56, Sex = "Female" });
            person.Add(new Person() { Name = "Patrick", Age = 73, Sex = "Male" });
            person.Add(new Person() { Name = "Yvonne", Age = 17, Sex = "Female" });
            person.Add(new Person() { Name = "Ann", Age = 21, Sex = "Female" });
            person.Add(new Person() { Name = "Jakob", Age = 26, Sex = "Male" });
            person.Add(new Person() { Name = "Mathias", Age = 84, Sex = "Male" });
            person.Add(new Person() { Name = "Brian", Age = 68, Sex = "Male" });
            person.Add(new Person() { Name = "Anne", Age = 43, Sex = "Female" });

            person.Sort();

            foreach (Person item in person) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    }



    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public int CompareTo(object obj)
        {
            Person person2 = (Person)obj;

            if(this.Name.CompareTo( person2.Name) == -1)
            {
                return -1;
            }
            else if (this.Name.CompareTo(person2.Name) == 1)
            {
                return 1;
            }
            else
            {
                if (this.Age < person2.Age)
                {
                    return -1;
                }
                else if (this.Age > person2.Age)
                {
                    return 1;
                }
                else
                {
                    if (this.Sex.CompareTo(person2.Sex) == -1)
                    {
                        return -1;
                    }
                    else if (this.Sex.CompareTo(person2.Sex) == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }



           
        }

        public override string ToString()
        {
            return Name + " " +Age + " " + Sex;
        }

    }









    abstract class Employee
    {
        public abstract void EmployeeNumber();
    }

    class Leader : Employee
    {
        public override void EmployeeNumber() => throw new NotImplementedException();
    }

    class Worker : Employee, IEmployee
    {
        public override void EmployeeNumber() => throw new NotImplementedException();

        void IEmployee.FireEmplyee() => throw new NotImplementedException();

        void IEmployee.NewEmplyee() => throw new NotImplementedException();

        void IEmployee.RaiseEmplyee() => throw new NotImplementedException();
    }

    class Footman : Employee, IEmployee
    {
        public override void EmployeeNumber() => throw new NotImplementedException();

        void IEmployee.FireEmplyee() => throw new NotImplementedException();
        

        void IEmployee.NewEmplyee() => throw new NotImplementedException();

        void IEmployee.RaiseEmplyee() => throw new NotImplementedException();
    }




}
