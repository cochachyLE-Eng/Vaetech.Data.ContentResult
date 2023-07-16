namespace Vaetech.Data.ContentResult.Enums
{
    public enum MessageIcon
    {
        None = 0,
        Hand = 16,
        Stop = 16,
        Error = 16,
        Question = 32,
        Exclamation = 48,
        Warning = 48,
        Asterisk = 64,
        Information = 64
    }
    public enum StatusCode
    {
        OK = 0,

        /// <summary>The operation was cancelled.</summary>
        Cancelled = 1,

        /// <summary>Unknown error.</summary>
        Unknown = 2,

        /// <summary>Client specified an invalid argument.</summary>
        InvalidArgument = 3,

        /// <summary>Deadline expired before operation could complete.</summary>
        DeadlineExceeded = 4,

        /// <summary>Not found.</summary>
        NotFound = 5,        

        /// <summary>Permission Denied.</summary>
        PermissionDenied = 7,

        /// <summary>The request does not have valid authentication credentials for the operation.</summary>
        Unauthenticated = 16,        

        /// <summary>
        /// Operation was rejected because the system is not in a state
        /// required for the operation's execution.
        /// </summary>
        FailedPrecondition = 9,

        /// <summary> The operation was aborted. </summary>
        Aborted = 10,        

        /// <summary>Operation is not implemented or not supported/enabled in this service.</summary>
        Unimplemented = 12,

        /// <summary> Internal errors.</summary>
        InternalError = 13,

        /// <summary> The service is currently unavailable.</summary>
        Unavailable = 14
    }
}