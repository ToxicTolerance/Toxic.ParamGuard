using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    public static class IEnumerableParameterGuardClauses
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IValueGuardParameter<List<T>> IfCountZero<T>(this IGuardParameter<List<T>> param, string? message = null)
        {
            IValueGuardParameter<List<T>> parameter = param as IValueGuardParameter<List<T>>;

            if (parameter.Value.Count <= 0)
                if (message == null)
                    throw new ArgumentOutOfRangeException(parameter.ParameterName);
                else
                    throw new ArgumentOutOfRangeException(parameter.ParameterName, message);
            else
                return parameter;
        }
    }
}
