using Toxic.ParamGuard.Interfaces;

namespace Toxic.ParamGuard.Types
{
    /// <summary>
    /// Sealed Implementation of <see cref="IValueGuardParameter{T}"/> and <see cref="IGuardParameter{T}"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class GuardParameter<T> : IValueGuardParameter<T>, IGuardParameter<T>
    {
        /// <summary>
        /// The Parameter to apply guardclause to.
        /// </summary>
        public T Value { get; init; }

        /// <summary>
        /// The name of the parameter.
        /// </summary>
        public string ParameterName { get; init; }

        /// <summary>
        /// Creates new instance of <see cref="GuardParameter{T}"/>
        /// </summary>
        public GuardParameter()
        {

        }

        /// <summary>
        /// Creates new instance of <see cref="GuardParameter{T}"/>
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public GuardParameter(T parameter, string parameterName)
        {
            Value = parameter;
            ParameterName = parameterName;
        }
    }
}
