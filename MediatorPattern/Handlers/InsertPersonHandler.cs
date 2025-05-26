using MediatorPattern.Commands;
using MediatorPattern.DataAccess;
using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Handlers;

public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
{
    private readonly IDataAccess data;

    public InsertPersonHandler(IDataAccess data)
    {
        this.data = data;
    }

    public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(data.InsertPerson(request.FirstName, request.LastName));
    }
}
