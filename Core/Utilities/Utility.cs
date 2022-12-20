using AspNetCoreApi.Core.Types;

namespace AspNetCoreApi.Core.Utilities
{
    public class Utility
    {
        public ApiResult<bool> GetErrorResponse(object error, string message)
        {
            var result = new ApiResult<bool>(false) { Error = error, Message = message, IsSuccess = false };
            return result;
        }
    }
}
