using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    /// <summary>
    /// Extensionmethods for Arrays
    /// </summary>
    public static class ArrayParameterGuardClauses
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T[]> IfContainsNullElements<T>(this IGuardParameter<T[]> param, string? message = null)
        {
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
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IValueGuardParameter<T[]> IfLengthZero<T>(this IGuardParameter<T[]> param, string? message = null)
        {
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
