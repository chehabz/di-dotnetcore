public class PersonService : IPersonService
{
    
    private PersonRepository _personRepository;

    public PersonService(PersonRepository personRepository) {
        _personRepository = personRepository;
    }

    public Person GetPerson(string? name = null)
    {
      return _personRepository.Collection.First();
    }
}