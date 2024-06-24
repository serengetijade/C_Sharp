namespace Project_StarWarsAPI_MVC.Models                    
{
    public class Result
    {
        protected Result(bool success, string error, string message = null)
        {
            if (success && error != string.Empty)
                throw new InvalidOperationException();
            if (!success && error == string.Empty)
                throw new InvalidOperationException();
            Success = success;
            Error = error;
            Message = message;
        }

        public bool Success { get; }
        public string Error { get; }
        public bool IsFailure => !Success;
        public string Message { get; }

        public static Result Fail(string message)
        {
            return new Result(false, message);
        }

        public static Result<T> Fail<T>(string message)
        {
            return new Result<T>(default, false, message);
        }

        public static Result Ok()
        {
            return new Result(true, string.Empty);
        }

        public static Result<T> Ok<T>(T content)
        {
            return new Result<T>(content, true, string.Empty);
        }
    }

    public class Result<T> : Result
    {
        protected internal Result(T content, bool success, string error)
            : base(success, error)
        {
            Content = content;
        }

        public T Content { get; set; }
    }
}
