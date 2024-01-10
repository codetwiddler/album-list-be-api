namespace album_list_business.Helper
{
    //Generic wrapper for returning results from queries.
    //Gives us a success flag and the data we've asked for (assuming it exists!)
    public class Result<T>
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
