using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Queries;

public record GetPersonByIdQuery(int Id) : IRequest<PersonModel?>;
