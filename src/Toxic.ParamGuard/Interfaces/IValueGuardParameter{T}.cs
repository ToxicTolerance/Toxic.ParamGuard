namespace Toxic.ParamGuard.Interfaces
{
    /// <summary>
    /// Interface provides basic structure for an ValueGuardParameter implementation
    /// </summary>
    public interface IValueGuardParameter<T> : IGuardParameter<T>
    {
        /// <summary>
        /// The actual parameter.
        /// </summary>
        public T Value { get; init; }
    }
}
