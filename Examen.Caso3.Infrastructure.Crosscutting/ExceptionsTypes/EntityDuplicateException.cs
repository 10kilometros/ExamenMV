using System;

namespace Examen.Caso3.Infrastructure.Crosscutting.ExceptionsTypes
{
    public class EntityDuplicateException : Exception
    {
        private string _errorMessage;
        public EntityDuplicateException(string errorMessage)
        {
            _errorMessage = errorMessage;
        }

        public override string Message
        {
            get
            {
                return _errorMessage;
            }
        }
    }
}
