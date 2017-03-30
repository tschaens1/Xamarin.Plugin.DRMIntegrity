using Plugin.DRMIntegrity.Abstractions;
using System;

namespace Plugin.DRMIntegrity
{
    /// <summary>
    /// Cross platform DRMIntegrity implemenations
    /// </summary>
    public class CrossDRMIntegrity
    {
        static Lazy<IDRMIntegrity> Implementation = new Lazy<IDRMIntegrity>(() => CreateDRMIntegrity(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IDRMIntegrity Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IDRMIntegrity CreateDRMIntegrity()
        {
#if PORTABLE
            return null;
#else
            return new DRMIntegrityImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
