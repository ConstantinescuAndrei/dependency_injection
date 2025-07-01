using dependency_injection.repositories;

namespace dependency_injection.Services;

public class CustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository _customerRepository)
    {
        _repository = _customerRepository;
    }

    public void Register(string name)
    {
        _repository.Save(name);
    }
}