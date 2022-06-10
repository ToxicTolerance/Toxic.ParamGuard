namespace Toxic.ParamGuard.Interfaces
{
    /// <summary>
    /// Interface provides basic structure for an Guard implementation
    /// </summary>
    public interface IGuard
    {
        /// <summary>
        /// Generic Method which returns an implementation of <see cref="IGuardParameter{T}"/>.
        /// This allows us to write specific GuardClauses for different types.
        /// </summary>
        /// <typeparam name="T">The type of the ComponentModel</typeparam>
        /// <param name="parameter">The ComponentModel itself.</param>
        /// <returns>An implementation of <see cref="IGuardParameter{T}"/> containting information of the component model.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static IGuardParameter<T> Check<T>(T parameter) => throw new NotImplementedException();
    }
}
