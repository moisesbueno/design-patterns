using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;

        public IdInfo IdInfo;


        public Person ShallowCopy(){
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy(){
            Person clone =(Person) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
    }
}