using RestWithASP_NET_person.Model;

namespace RestWithASP_NET_person.Services
{
    public interface IPersonService
    {
        List<Person> FindAll();
        Person FindById(long id);
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
    }
}
