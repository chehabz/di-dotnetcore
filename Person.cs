
public class Person {

    private string _name = string.Empty;

    private int? _age;
    public string Name {
        get => _name;
        set => _name = value;
    }

    public int? Age {
        get => _age;
        set => _age = value;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Age: {_age}";
    }
}