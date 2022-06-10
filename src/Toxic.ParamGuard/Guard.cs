using System.Runtime.CompilerServices;
using Toxic.ParamGuard.Interfaces;
using Toxic.ParamGuard.Types;

namespace Toxic.ParamGuard
{
    /// <summary>
    /// Provides entrypoint for parameterchecking with guard clauses.
    /// </summary>
    public sealed class Guard 
    {
        /// <summary>
        /// Static constructor
        /// </summary>
        static Guard() { }


        /// <summary>
        /// Generic Method which returns an implementation of <see cref="IGuardParameter{T}"/>.
        /// This allows us to write specific GuardClauses for different types.
        /// </summary>
        /// <typeparam name="T">The type of the ComponentModel</typeparam>
        /// <param name="parameter">The ComponentModel itself.</param>
        /// <returns>An implementation of <see cref="IGuardParameter{T}"/> containting information of the component model.</returns>
        public static IGuardParameter<T> ThrowOn<T>(T parameter, [CallerArgumentExpression("parameter")] string? parameterName = null)
        {
            return new GuardParameter<T>
            {
                Value = parameter,
                ParameterName = parameterName
            };
        }
    }
}