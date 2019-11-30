using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melgar
{
    

    public class Person
    {
       

        private string _name;

        public string Name { get; }
        public double SaveMoney { get; private set; }

        public Person(string name, double savemoney) { Name = name; SaveMoney = savemoney; }

        public void Save(double save) { SaveMoney += save; }

        public void Spend(double save) { SaveMoney += save; }
        public void ChangeName(string name) { _name = name; }

    }


}

