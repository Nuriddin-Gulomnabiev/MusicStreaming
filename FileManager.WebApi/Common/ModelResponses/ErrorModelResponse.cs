namespace FileManager.WebApi.Common.ModelResponses
{
    public class ErrorModelResponse
    {
        public int Code { get; }
        public string Message { get; }
        public IEnumerable<Error> Errors { get; set; }

        public ErrorModelResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public ErrorModelResponse(int code, string message, IEnumerable<Error> errors)
        {
            Code = code;
            Errors = errors;
            Message = message;
        }
    }

    public class Error
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
