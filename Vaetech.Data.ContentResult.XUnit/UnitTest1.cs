using Vaetech.Data.ContentResult.Enums;
using Vaetech.Data.ContentResult.Events;
using Xunit;

namespace Vaetech.Data.ContentResult.XUnit
{
    public class UnitTest1
    {
        public ActionResult GetResponse(int option)
        {
            switch (option)
            {
                case 0:
                    return ActionResult.Success(StatusCode.OK, "Successfully completed");                
                case 1:
                    return ActionResult.Fail(StatusCode.NotFound, "Not found");
                default:
                    return ActionResult.Fail(StatusCode.InternalError, "Internal errors");
            }
        }
        public ActionResult<T> GetResponse<T>(int option) {
            switch (option)
            {
                case 0:
                    return ActionResult<T>.Success(StatusCode.OK, "Successfully completed");
                case 1:
                    return ActionResult<T>.Fail(StatusCode.Unauthenticated, "You are not Authorized");
                case 2:
                    return ActionResult<T>.Fail(StatusCode.Unimplemented, "Operation is not implemented or not supported/enabled in this service");
                case 3:
                    return ActionResult<T>.Fail(StatusCode.PermissionDenied, "You are not authorized to access this resource");                    
                default: 
                    return ActionResult<T>.Fail(StatusCode.InternalError, "...");
            }
        }
        public TupleResult<T1, T2> GetResponse<T1, T2>(int option)
        {
            switch (option)
            {
                case 0:
                    return TupleResult<T1, T2>.Success(StatusCode.OK, "Successfully completed");
                case 1:
                    return TupleResult<T1, T2>.Fail(StatusCode.Unauthenticated, "You are not Authorized");
                case 2:
                    return TupleResult<T1, T2>.Fail(StatusCode.Unimplemented, "Operation is not implemented or not supported/enabled in this service");
                case 3:
                    return TupleResult<T1, T2>.Fail(StatusCode.PermissionDenied, "You are not authorized to access this resource");
                default:
                    return TupleResult<T1, T2>.Fail(StatusCode.InternalError, "...");
            }
        }
    }
}