using System.Runtime.CompilerServices;
using Toxic.ParamGuard.Interfaces;
using Toxic.ParamGuard.Types;

namespace Toxic.ParamGuard
{
    public static class ThrowExtension
    {
        /// <summary>
        /// Provides the same entrypoint on ParamGuard as the <see cref="Guard"/> class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public static IGuardParameter<T> Throw<T>(this T param, [CallerArgumentExpression("param")] string paramName = null)
        {
            return new GuardParameter<T>(param, paramName);
        }
    }
}
