using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    /// <summary>
    /// Extensionmethods for Arrays
    /// </summary>
    public static class ArrayParameterGuardClauses
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if one of the Elements contained in the <see cref="List{T}"/> is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T[]> IfContainsNullElements<T>(this IGuardParameter<T[]> param, string? message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
            IValueGuardParameter<T[]> parameter = param as IValueGuardParameter<T[]>;

            if (parameter.Value.Where(p => p == null).Count() > 0)
                if (message == null)
                    throw new ArgumentNullException(parameter.ParameterName);
                else
                    throw new ArgumentNullException(parameter.ParameterName, message);
            else
                return parameter;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if Count of the <see cref="List{T}"/> is 0 (Zero).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IValueGuardParameter<T[]> IfLengthZero<T>(this IGuardParameter<T[]> param, string? message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
            IValueGuardParameter<T[]> parameter = param as IValueGuardParameter<T[]>;

            if (parameter.Value.Length <= 0)
                if (message == null)
                    throw new ArgumentOutOfRangeException(parameter.ParameterName);
                else
                    throw new ArgumentOutOfRangeException(parameter.ParameterName, message);
            else
                return parameter;
        }
    }

}
