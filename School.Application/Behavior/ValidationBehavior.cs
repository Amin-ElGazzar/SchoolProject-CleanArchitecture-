using FluentValidation;
using MediatR;

namespace School.Application.Behavior
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validatonResult = await Task.WhenAll(_validators.Select(x => x.ValidateAsync(context, cancellationToken)));
                var failures = validatonResult.SelectMany(x => x.Errors).Where(f => f != null).ToList();
                if (failures.Count != 0)
                {
                    var message = failures.Select(x => x.PropertyName + ": " + x.ErrorMessage).FirstOrDefault();

                    throw new FluentValidation.ValidationException(message);

                }
            }
            return await next();
        }
    }
}
