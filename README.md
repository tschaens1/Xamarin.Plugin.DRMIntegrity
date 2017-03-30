# Xamarin.Plugin.DRMIntegrity

The DRMIntegrity plugin for Xamarin and Xamarin.Forms applications will handle two integrity checks:

* Check if the device has root access activated (Jailbreak on iOS, root on Android)
* Check if the application bundle is signed correctly, which will give you a **hint** to piracy

There is never a 100% chance to distinguish cracked apps from others. ** Please use with care! **

## Getting Started

Coming soon.

### Supported Platforms

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 8+|
|Xamarin.iOS Unified|Yes|iOS 8+|
|Xamarin.Android|Yes|API 10+|

### Using the API

```csharp

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

```

## Versioning

The current version is v0.1.0, I will try to release the package via NuGet as soon as possible.

## Version history

Coming soon.

## Authors

* **Jan Schölch** - *Initial work* - [tschaens1](https://github.com/tschaens1)

Kudos to [James Montemagno](https://github.com/jamesmontemagno) for providing the awesome plugin project template!

## Contributing

As we all know, students do not have a lot of time and are very busy doing stuff ;-))
So I am very happy about everyone who wants to contribute!
You can do so by following these steps:

1. Just do a Fork
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push your changes to the branch: `git push origin my-new-feature`
5. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
