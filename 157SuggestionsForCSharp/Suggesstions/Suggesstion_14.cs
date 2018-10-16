using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _157SuggestionsForCSharp.Suggesstions
{
    public class Suggesstion_14 : ISuggestionTest
    {
        public class Hand
        {
            public string HandName { get; private set; }
            public Hand(string HandName)
            {
                this.HandName = HandName;
            }
        }
        public class Person : ICloneable, IClone
        {
            public string Name { get; set; }
            public Hand Hand { get; set; }
            public Person()
            {
                Name = "HeHe";
                Hand=new Hand("Left_Hand");
            }
            public object Clone()
            {
                return this.MemberwiseClone();
            }
            public object ShallowClone()
            {
                return Clone();
            }

            public object DeepClone()
            {
                //DeepClone
                using (Stream objectStream = new MemoryStream())
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(objectStream, this);
                    objectStream.Seek(0, SeekOrigin.Begin);
                    return (formatter.Deserialize(objectStream)) as Person;
                }
            }
        }

        public void Test()
        {
            Person person = new Person();
            Console.WriteLine($"person'Name is {person.Name},person'Hand name is {person.Hand.HandName}");
            Person person_one = (Person)person.Clone();
            Console.WriteLine($"person_one'Name is {person_one.Name},person_one'Hand name is {person_one.Hand.HandName}");
            Console.WriteLine("set person_one's Hand");
            person_one.Hand = new Hand("right_hand");
            Console.WriteLine($"person'Name is {person.Name},person'Hand name is {person.Hand.HandName}");
            Console.WriteLine($"person_one'Name is {person_one.Name},person_one'Hand name is {person_one.Hand.HandName}");
            person = new Person();
            Console.WriteLine($"person'Name is {person.Name},person'Hand name is {person.Hand.HandName}");
            Person person_two = (Person)person.Clone();
            Console.WriteLine($"person_two'Name is {person_two.Name},person_two'Hand name is {person_two.Hand.HandName}");
            Console.WriteLine("set person_two's Hand");
            person_two.Hand = new Hand( "right_hand" );
            Console.WriteLine($"person'Name is {person.Name},person'Hand name is {person.Hand.HandName}");
            Console.WriteLine($"person_two'Name is {person_two.Name},person_two'Hand name is {person_two.Hand.HandName}");
        }


    }

}
