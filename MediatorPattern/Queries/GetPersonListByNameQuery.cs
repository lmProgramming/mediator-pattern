using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Queries
{
    public record GetPersonListByNameQuery(string firstName) : IRequest<List<PersonModel>>;
}
