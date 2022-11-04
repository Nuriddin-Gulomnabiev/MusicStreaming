using MediatR;
using FluentValidation;
using ValidationException = Domain.Exceptions.ValidationException;
using Error = Domain.Exceptions.ValidationError;

namespace FileManager.Application.Common.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);

                var validationResults = await Task.WhenAll(validators.Select(v => v.ValidateAsync(context, cancellationToken)));

                var failures = validationResults.SelectMany(r => r.Errors).Where(e => e != null);

                if (failures.Any())
                {
                    var errors = failures.Select(e => new Error
                    {
                        ErrorMessage = e.ErrorMessage,
                        PropertyName = e.PropertyName
                    });

                    throw new ValidationException(errors);
                }
            }

            return await next();
        }
    }
}
