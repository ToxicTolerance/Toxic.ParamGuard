using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    public static class GenericParameterGuardClauses
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T> IfNull<T>(this IGuardParameter<T> param, string message = null)
        {
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
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<T[]> IfNull<T>(this IGuardParameter<T[]> param, string message = null)
        {
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
