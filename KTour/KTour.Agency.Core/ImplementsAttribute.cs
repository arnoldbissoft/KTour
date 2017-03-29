using System;
using System.Linq;
using System.Reflection;

namespace KTour.Agency
{
    /// <summary>
    /// Marks a class as a candidate implementation for the specified Type
    /// (which is usually an interface).
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ImplementsAttribute : Attribute
    {
        /// <summary>
        /// Constructor which specifies the type which the decorated class is meant to serve.
        /// </summary>
        /// <param name="injectableType"></param>
        public ImplementsAttribute(Type injectableType)
        {
            Type = injectableType;
        }

        /// <summary>
        /// Gets the service type which the decorated class implements.
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Check if there is at least one reference to the Attribute
        /// </summary>
        /// <param name="candidateType"></param>
        /// <returns></returns>
        public static bool Any(Type candidateType)
        {
            var definitions = (ImplementsAttribute[])candidateType.GetTypeInfo().GetCustomAttributes(typeof(ImplementsAttribute), true);

            return definitions.Any();
        }

        /// <summary>
        /// Get the first reference to the Attribute
        /// </summary>
        /// <param name="candidateType">Type of the candidate.</param>
        /// <returns>The attribute that decorates the specified Type, or NULL if one is not found.</returns>
        public static ImplementsAttribute Get(Type candidateType)
        {
            var definitions = (ImplementsAttribute[])candidateType.GetTypeInfo().GetCustomAttributes(typeof(ImplementsAttribute), true);

            return definitions.FirstOrDefault();
        }
    }
}
