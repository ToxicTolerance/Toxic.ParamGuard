using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    public static class GenericParameterGuardClauses
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException"></see> when the parameter is zero.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T> IfNull<T>(this IGuardParameter<T> param, string message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
            IValueGuardParameter<T> parameter = param as IValueGuardParameter<T>;

            if (parameter.Value == null)
                if (message == null)
                    throw new ArgumentNullException(parameter.ParameterName);
                else
                    throw new ArgumentNullException(parameter.ParameterName, message);
            else
                return parameter;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"></see> when the <see cref="{T[]}"/> is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T[]> IfNull<T>(this IGuardParameter<T[]> param, string message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
            IValueGuardParameter<T[]> parameter = param as IValueGuardParameter<T[]>;

            if (parameter.Value == null)
                if (message == null)
                    throw new ArgumentNullException(parameter.ParameterName);
                else
                    throw new ArgumentNullException(parameter.ParameterName, message);
            else
                return parameter;
        }
    }
}
