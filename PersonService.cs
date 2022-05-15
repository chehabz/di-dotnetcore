public class PersonService : IPersonService
{
    
    private PersonRepository _personRepository;

    public PersonService(PersonRepository personRepository) {
        _personRepository = personRepository;
    }

    public IList<Person> GetList()
    {
        return _personRepository.Collection;
    }

    public Person GetPerson(string? name = null)
    {
      return _personRepository.Collection.First();
    }
}