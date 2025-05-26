using MediatorPattern.DataAccess;
using MediatorPattern.Models;
using MediatorPattern.Queries;
using MediatR;

namespace MediatorPattern.Handlers;

public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel?>
{
    private readonly IDataAccess _data;

    public GetPersonByIdHandler(IDataAccess data)
    {
        _data = data;
    }

    public Task<PersonModel?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_data.GetPersonById(request.Id));
    }
}
