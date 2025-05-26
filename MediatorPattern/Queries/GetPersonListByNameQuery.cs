using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Queries;

public record GetPersonListByNameQuery(string FirstName) : IRequest<List<PersonModel>>;
