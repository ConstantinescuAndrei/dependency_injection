namespace dependency_injection.repositories;

public class SqlCustomerRepository: ICustomerRepository
{
    public void Save(string name)
    {
        Console.WriteLine($"{name} has been saved");
    }
}