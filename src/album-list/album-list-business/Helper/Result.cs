namespace album_list_business.Helper
{
    public class Result<T> where T : class
    {
        public bool Success { get; }
        public T Data { get; }

        public Result(bool success, T data)
        {
            Success = success;
            Data = data;
        }
    }
}
