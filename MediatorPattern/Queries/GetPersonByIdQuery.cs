using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<PersonModel?>;
}
