using design_patterns_3.Chain1;
using design_patterns_3.Chain2;
using design_patterns_3.Decorator;
using design_patterns_3.Visitor;
using System.Diagnostics.Metrics;

namespace design_patterns_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INeptunUser> users = new List<INeptunUser>()
            {
                 new Student("AAA111", "John Doe", 3.4),
                 new Student("BBB222", "Jane Clein", 4.2),
                 new Student("CCC333", "Steve Stein", 1.8),
                 new Student("DDD444", "Klaus Jürgen", 5.0),
                 new Student("DDD44123", "Klaus", 4.0),
                 new Student("DDD44123", "Klaus", 4.0),
                 new Student("DDD44123", "Klaus", 4.0),
                 new Student("DDD44123", "Klaus", 4.0),
            };

            foreach (var item in users)
            {
                Console.WriteLine(item.Name + "(" + item.NeptunCode + "): " + item.Mark);
            }

            Student s1 = users[3] as Student;

            ErasmusStudent klaus = new ErasmusStudent(s1, "Budapest", new System.DateTime(2022, 1, 1));

            users[3] = klaus;

            //---------------------------------------------------

            List<Person> people = new List<Person>()
            {
             new Person("Aladár", 16, true),
             new Person("Ali", 20, true),
             new Person("Béla", 20, false),
             new Person("Dezső", 25, true),
             new Person("Géza", 20, true),
             new Person("Pál", 10, false)
            };

            List<Person> acceptedPeople = new List<Person>();

            var validatorFactory = new ValidatorFactory();
            var validators = validatorFactory.GetValidators();
            var validatorsCount = validators.Count();

            foreach (var person in people)
            {
                int counter = 0;

                foreach (var validator in validators)
                {
                    if (validator.Validate(person))
                    {
                        counter++;
                    }
                }

                if (counter == validatorsCount)
                {
                    acceptedPeople.Add(person);
                }
            }

            foreach (var person in acceptedPeople)
            {
                Console.WriteLine(person.Name);
            }

            //---------------------------------------------------

            Boss john = new Boss("John", 99999999);
            Boss jack = new Boss(john, "Jack", 100000);
            Boss paul = new Boss(jack, "Paul", 10000);

            paul.AcceptRequest("Laptop", 100000);

            //---------------------------------------------------

            JsonExporter jExporter = new JsonExporter();

            Car C1 = new Car("BMW X5", 2020);

            List<IAccepter> acceptors = new List<IAccepter>() { C1 };

            List<IVisitor> visitors = new List<IVisitor>() { jExporter };

            foreach (var acceptor in acceptors)
            {
                foreach (var visitor in visitors)
                { 
                    visitor.Visit(acceptor);
                }
            }
        }
    }
}
