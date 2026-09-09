namespace Learning.HotChocolate.Models;

public class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }

    // [GraphQLIgnore]
    public int Ignore { get; set; }
}

public class User1
{
    public int Id { get; set; }
}
