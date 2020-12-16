namespace Melsoft.Models
{
    public class ServiceResponse<T>
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        public T Result { get; set; }
    }
}