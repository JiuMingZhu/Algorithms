using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _157SuggestionsForCSharp.Suggesstions
{
    public class Person:IEquatable<Person>
    {
        //IEquatable接口是针对值类型的优化，当值类型与引用类型相比较时，可以避免装箱操作
        public string Name { get; set; }

        public string IDNo { get;private set; }

        public Person()
        {
            Name = "default";
            IDNo = "default";
        }
        public Person(string Name,string IDNo)
        {
            this.Name = Name;
            this.IDNo = IDNo;
        }

        public override bool Equals(object obj)
        {
            return IDNo == (obj as Person).IDNo;
        }

        public override int GetHashCode()
        {
            //return this.IDNo.GetHashCode();
            return (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "#" + this.IDNo).GetHashCode();
        }

        public bool Equals(Person other)
        {
            return IDNo == other.IDNo;
        }
    }
    public class Suggesstion_12 : ISuggestionTest
    {
        Dictionary<Person, string> PersonValue = new Dictionary<Person, string>();
        public void Test()
        {
            AddPerson();
            Person mike = new Person("mike", "123");
            Console.WriteLine(mike.GetHashCode());
            Console.WriteLine(PersonValue.ContainsKey(mike));
        }
        public void AddPerson()
        {
            Person mike = new Person("mike", "123");
            PersonValue.Add(mike, "111");
            Console.WriteLine(mike.GetHashCode());
            Console.WriteLine(PersonValue.ContainsKey(mike));
        }
    }
}
