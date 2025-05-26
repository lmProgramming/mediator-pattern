using MediatorPattern.Models;
using MediatorPattern.Queries;
using MediatR;

namespace MediatorPattern.Handlers
{
    public class GetPersonListByNameHandler : IRequestHandler<GetPersonListByNameQuery, List<PersonModel>>
    {
        private readonly IMediator _mediator;

        public GetPersonListByNameHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<PersonModel>> Handle(GetPersonListByNameQuery request, CancellationToken cancellationToken)
        {
            var people = await _mediator.Send(new GetPersonListQuery());

            return people.Where(p => p.FirstName == request.firstName).ToList();
        }
    }
}
