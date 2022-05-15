
public interface  IPersonService {

    /// <summary>
    /// searches for a person by name
    ///</summary>
    Person GetPerson(string? name = null);
}