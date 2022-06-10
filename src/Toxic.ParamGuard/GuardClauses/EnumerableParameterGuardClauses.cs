using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    public static class IEnumerableParameterGuardClauses
    {
        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"></see> when the <see cref="List{T}.Count"></see> is 0.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IValueGuardParameter<List<T>> IfCountZero<T>(this IGuardParameter<List<T>> param, string? message = null)
        {
            /*Convert to IValueGuardParamer because it exposes the Value-Property*/
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
