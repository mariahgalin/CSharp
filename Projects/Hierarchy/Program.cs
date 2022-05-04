using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor("Romeo", 28, "Engineer");
            Console.WriteLine(doc.GetInfo());
            Console.WriteLine(doc.GetData());

            Developer dev = new Developer("Maria", 24, "CSharp");
            Console.WriteLine(dev.GetInfo());
            Console.WriteLine(dev.GetData());
            Console.ReadKey();
        }
    }

    class People
    {
        //When is private, the variable has an underscore at first. 
        private string _name;
        private int _age;

        public People (string name, int age)
        {
            _name = name;
            _age = age; 
        }

        //If it is protected, you can only used in the hierarchy class
        public string GetInfo()
        {
            return _name + " " + _age;
        }
    }

    class Doctor : People
    {
        private string _speciality;
        public Doctor(string name, int age,string speciality) : base(name, age)
        {
            _speciality = speciality;
        }

        public string GetData()
        {
            return GetInfo() + " " + _speciality;
        }
    }

    class Developer : People
    {
        private string _language;
        
        public Developer(string name, int age, string language) : base(name, age)
        {
            _language = language;
        }

        public string GetData()
        {
            return GetInfo() + " " + _language;
        }
    }
}
