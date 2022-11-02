namespace FileManager.WebApi.Common.ModelResponses
{
    public class ErrorModelResponse
    {
        public ErrorModelResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; }
        public string Message { get; }
    }
}
