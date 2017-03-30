using Plugin.DRMIntegrity.Abstractions;
using System;

namespace Plugin.DRMIntegrity
{
    /// <summary>
    /// Implementation for IDRMIntegrity
    /// </summary>
    public class DRMIntegrityImplementation : IDRMIntegrity
    {
        #region Public methods inherited from IDRMIntegrity

        /// <inheritdoc cref="IRootCheck"/>
        public bool IsDeviceRooted => throw new NotImplementedException();

        /// <inheritdoc cref="IRootCheck"/>
        public bool IsApplicationCracked => throw new NotImplementedException();

        #endregion
    }
}