using AdminPanel.Application.Common.Enums;

namespace AdminPanel.Application.Common.Exceptions
{
    public class ResourceNotFoundException : BaseException
    {
        public ResourceNotFoundException(string message) : base(message)
        {
        }

        public override ErrorCodeEnum Code { get => ErrorCodeEnum.RESOURCE_NOT_FOUND; }
    }
}
