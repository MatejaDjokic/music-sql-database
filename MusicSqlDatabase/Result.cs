namespace MusicSqlDatabase
{
    public class Result<T>
    {
        T? value;
        string? err;

        public Result(T? value = default, string? err = null)
        {
            this.value = value;
            this.err = err;
        }

        public T Unwrap()
        {
            if (value == null)
                throw new Exception($"\nCan't unwrap an error! \n Err: \"{err}\"\n");
            else
                return this.value!;
        }
    }
}
