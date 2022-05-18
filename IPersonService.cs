
public interface  IPersonService {

    /// <summary>
    /// searches for a person by name
    ///</summary>
    Person GetPerson(string? name = null);

    /// <summary>
    /// Get a list of person Entity
    /// <summary>
    IList<Person> GetList();

    /// <summary>
    /// Creates a new person entity
    /// <summary>
    void Create(Person person);
}