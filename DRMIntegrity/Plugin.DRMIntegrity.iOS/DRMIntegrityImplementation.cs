using Foundation;
using ObjCRuntime;
using Plugin.DRMIntegrity.Abstractions;
using System;
using UIKit;

namespace Plugin.DRMIntegrity
{
    /// <summary>
    /// Implementation for IDRMIntegrity
    /// </summary>
    public class DRMIntegrityImplementation : IDRMIntegrity
    {
        #region Constants

        protected const string CydiaExampleUrl = "cydia://package/com.example.package";

        #endregion

        #region Public methods inherited from IDRMIntegrity

        /// <inheritdoc cref="IDRMIntegrity"/>
        public bool IsDeviceRooted => GetIsJailbroken();

        /// <inheritdoc cref="IDRMIntegrity"/>
        public bool IsApplicationCracked
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Private helper methods

        /// <summary>
        /// Check the iOS device for jailbreak. LSApplicationQueriesSchemes must be set in the Info.plist!
        /// </summary>
        /// <returns><c>true</c> if device is jailbroken, <c>false</c> otherwise.</returns>
        private static bool GetIsJailbroken()
        {
            if (Runtime.Arch == Arch.SIMULATOR)
            {
                return false;
            }

            return UIApplication.SharedApplication.CanOpenUrl(NSUrl.FromString(CydiaExampleUrl));
        }

        #endregion
    }
}