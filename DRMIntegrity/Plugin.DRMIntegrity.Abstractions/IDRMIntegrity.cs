namespace Plugin.DRMIntegrity.Abstractions
{
    /// <summary>
    /// Interface for DRMIntegrity
    /// </summary>
    public interface IDRMIntegrity
    {
        /// <summary>
        /// Determine whether the device might be jailbroken (iOS) respectively rooted (Android).
        /// </summary>
        /// <returns><c>true</c> if root access might be active, <c>false</c> otherwise.</returns>
        bool IsDeviceRooted { get; }

        /// <summary>
        /// Determine whether the application might be cracked.
        /// </summary>
        /// <returns><c>true</c> if application might be cracked, <c>false</c> otherwise.</returns>
        bool IsApplicationCracked { get; }
    }
}
