using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace ES.FX.Data.Common
{
    /// <inheritdoc />
    public class ConnectionStringBuilder : DbConnectionStringBuilder
    {
        protected T GetValueOrDefault<T>([CallerMemberName]string property = null)
        {
            if (!ContainsKey(property)) return default(T);
            return (T)Convert.ChangeType(this[property]?.ToString(), typeof(T));
        }


        protected object SetValue(object value, [CallerMemberName]string property = null)
        {
            this[property] = value;
            return value;
        }
    }
}