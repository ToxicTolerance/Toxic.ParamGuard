namespace Toxic.ParamGuard.Interfaces
{
    /// <summary>
    /// Interface provides basic structure for an GuardParameter implementation
    /// </summary>
    public interface IGuardParameter<T>
    {
        /// <summary>
        /// The name of the actual parameter
        /// retreived by [CallerArgumentExpression]
        /// </summary>
        internal string ParameterName { get; init; }
    }
}
