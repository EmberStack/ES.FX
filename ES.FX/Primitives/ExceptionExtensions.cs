using System;

namespace ES.FX.Primitives
{
    /// <summary>
    /// Extension methods for <see cref="Exception"/>
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Returns the inner most <see cref="Exception"/>
        /// </summary>
        public static Exception InnerMostException(this Exception exception)
        {
            if (exception == null) return null;
            return exception.InnerException == null ? exception : InnerMostException(exception.InnerException);
        }


        /// <summary>
        /// Returns the inner most <see cref="Exception"/> of a specific Type
        /// </summary>
        public static Exception InnerMostException<T>(this Exception exception) where T : Exception
        {
            if (exception == null) return null;
            var current = exception as T;
            return exception.InnerException == null ? current : InnerMostException(exception.InnerException);
        }
    }
}