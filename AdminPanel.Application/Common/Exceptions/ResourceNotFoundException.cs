using AdminPanel.Application.Common.Enums;

namespace AdminPanel.Application.Common.Exceptions
{
    public class ResourceNotFoundException : BaseException
    {
        public override ErrorCodeEnum Code { get => ErrorCodeEnum.RESOURCE_NOT_FOUND; }

        public ResourceNotFoundException(string message) : base(message)
        {
        }
    }
}
