namespace AdminPanel.Web.Common.ModelResponses
{
    public class SuccessModelResponse : BaseModelResponse
    {
        public object Data { get; set; }

        public SuccessModelResponse(int code, string message, object data = null) : base(code, message)
        {
            Data = data;
        }
    }
}
