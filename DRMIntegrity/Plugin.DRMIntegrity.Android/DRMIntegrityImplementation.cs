using Plugin.DRMIntegrity.Abstractions;
using Java.IO;
using Java.Lang;
using System;

namespace Plugin.DRMIntegrity
{
    /// <summary>
    /// Implementation for IDRMIntegrity
    /// </summary>
    public class DRMIntegrityImplementation : IDRMIntegrity
    {
        #region Constants

        protected const string TestKeysBuildTag = "test-keys";
        protected const string FilePathSuperuser = "/system/app/Superuser.apk";
        protected const string CommandXBinWhich = "/system/xbin/which su";
        protected const string CommandBinWhich = "/system/bin/which su";
        protected const string CommandWhich = "which su";

        #endregion

        #region Public methods inherited from IDRMIntegrity

        /// <inheritdoc cref="IDRMIntegrity"/>
        public bool IsDeviceRooted => GetIsRootAccessActive();

        /// <inheritdoc cref="IDRMIntegrity"/>
        public bool IsApplicationCracked => GetIsApplicationCracked();

        #endregion

        #region Private helper methods

        /// <summary>
        /// Check the Android device for root access.
        /// </summary>
        /// <returns><c>true</c> if device might be rooted, <c>false</c> otherwise.</returns>
        private static bool GetIsRootAccessActive()
        {
            var buildTags = Android.OS.Build.Tags;

            if (buildTags != null && buildTags.Contains(TestKeysBuildTag))
            {
                return true;
            }

            try
            {
                if (new File(FilePathSuperuser).Exists())
                {
                    return true;
                }
            }

            catch (System.Exception)
            {
                return false;
            }

            return CanExecuteCommand(CommandXBinWhich) || CanExecuteCommand(CommandBinWhich) || CanExecuteCommand(CommandWhich);
        }

        private bool GetIsApplicationCracked()
        {
            throw new NotImplementedException();
        }

        private static bool CanExecuteCommand(string command)
        {
            try
            {
                Runtime.GetRuntime().Exec(command);
                return true;
            }

            catch (System.Exception)
            {
                return false;
            }
        }

        #endregion
    }
}