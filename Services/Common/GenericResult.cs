namespace Services.Common
{
    public class GenericResult(bool isSuccess, string message, object? data = null)
    {
        public bool IsSuccess { get; set; } = isSuccess;
        public string Message { get; set; } = message;
        public object? Data { get; set; } = data;
    }

    public class Response(StatusCode statusCode, string message, object? data = null)
    {
        public StatusCode StatusCode { get; set; } = statusCode;
        public string Message { get; set; } = message;
        public object? Data { get; set; } = data;
    }

    public class Message
    {
        public const string Success = "Success";
        public const string Error = "Error";
        public const string NotFound = "Not Found";
        public const string BadRequest = "Bad Request";
        public const string Unauthorized = "Unauthorized";
        public const string Forbidden = "Forbidden";
        public const string InternalServerError = "Internal Server Error";
        public const string Conflict = "Conflict";
        public const string Created = "Created";
        public const string NoContent = "No Content";
    }

    public class StatusCode
    {
        public const int Success = 200;
        public const int Created = 201;
        public const int NoContent = 204;
        public const int BadRequest = 400;
        public const int Unauthorized = 401;
        public const int Forbidden = 403;
        public const int NotFound = 404;
        public const int Conflict = 409;
        public const int InternalServerError = 500;
    }
}
