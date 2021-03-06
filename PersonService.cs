public class PersonService : IPersonService
{
    
    private PersonRepository _personRepository;

    public PersonService(PersonRepository personRepository) {
        _personRepository = personRepository;
    }

    public void Create(Person person)
    {
        if(person is null)
            throw new ArgumentNullException($"{nameof(person)} cannot be null");

        _personRepository.Collection.Add(person);
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