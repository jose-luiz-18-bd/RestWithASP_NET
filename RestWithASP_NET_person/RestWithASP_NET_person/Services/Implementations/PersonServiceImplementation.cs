using RestWithASP_NET_person.Model;

namespace RestWithASP_NET_person.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public volatile int count;


        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);

            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "José Luiz",
                LastName = "De Jesus Santos",
                Address = "Uberlândia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }


        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "José Luiz" +i,
                LastName = "De Jesus Santos" + i,
                Address = "Uberlândia - Minas Gerais - Brasil" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
