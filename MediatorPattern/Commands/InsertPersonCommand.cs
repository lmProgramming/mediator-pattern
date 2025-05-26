using MediatorPattern.Models;
using MediatR;

namespace MediatorPattern.Commands;

public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
