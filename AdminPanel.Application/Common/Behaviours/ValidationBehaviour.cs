using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace AdminPanel.Application.Common.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;
        private readonly ILogger<ValidationBehaviour<TRequest, TResponse>> logger;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators, ILogger<ValidationBehaviour<TRequest, TResponse>> logger)
        {
            this.logger = logger;
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
                    var commandName = request.GetType().Name;
                    var errors = string.Join(", ", failures.Select(f => f.ErrorMessage));

                    logger.LogWarning($"Validation errors - {commandName}; Errors - {errors}");

                    throw new ValidationException("Validation exception", failures);
                }
            }

            return await next();
        }
    }
}
