using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
