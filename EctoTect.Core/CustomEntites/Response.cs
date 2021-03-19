namespace EctoTect.Core.CustomEntites
{
    public class Response<T>: ResponseBase
    {
        public T Data { get; set; }
    }
}
