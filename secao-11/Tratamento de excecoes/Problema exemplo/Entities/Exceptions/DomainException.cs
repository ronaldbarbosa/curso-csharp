namespace Problema_exemplo.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {  
        }
    }
}