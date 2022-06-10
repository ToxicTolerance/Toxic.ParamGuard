using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard
{
    public static class StringGuardClausesExtension
    {
        /// <summary>
        /// Checks a string for <see cref="string.IsNullOrWhiteSpace(string?)"/>,
        /// throws <see cref="ArgumentNullException"/> if true.
        /// </summary>
        /// <param name="param">The string to check.</param>
        /// <param name="message">The custom messaage for exception </param>
        /// <returns>A <see cref="IGuardParameter{string}"/> implementation for further checking.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<string> IfNullOrWhiteSpace(this IGuardParameter<string> param, string? message = null)
        {
            IValueGuardParameter<string> parameter = param as IValueGuardParameter<string>;

            if (string.IsNullOrWhiteSpace(parameter.Value))
                if (message == null)
                    throw new ArgumentNullException(parameter.ParameterName);
                else
                    throw new ArgumentNullException(parameter.ParameterName, message);
            else
                return parameter;
        }

        /// <summary>
        /// Checks a string for <see cref="string.IsNullOrEmpty(string?)"/>,
        /// throws <see cref="ArgumentNullException"/> if true.
        /// </summary>
        /// <param name="param">The string to check.</param>
        /// <param name="message">The custom messaage for exception </param>
        /// <returns>A <see cref="IGuardParameter{string}"/> implementation for further checking.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IValueGuardParameter<string> IfNullOrEmpty(this IGuardParameter<string> param, string? message = null)
        {
            IValueGuardParameter<string> parameter = param as IValueGuardParameter<string>;

            if (string.IsNullOrEmpty(parameter.Value))
                if (message == null)
                    throw new ArgumentNullException(param.ParameterName);
                else
                    throw new ArgumentNullException(param.ParameterName, message);
            else
                return parameter;

        }
    }
}
