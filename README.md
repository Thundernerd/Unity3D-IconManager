# Icon Manager

<p align="center">
	<img alt="GitHub package.json version" src ="https://img.shields.io/github/package-json/v/Thundernerd/Unity3D-IconManager" />
	<a href="https://github.com/Thundernerd/Unity3D-IconManager/issues">
		<img alt="GitHub issues" src="https://img.shields.io/github/issues/Thundernerd/Unity3D-IconManager">
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-IconManager/pulls">
		<img alt="GitHub pull requests" src ="https://img.shields.io/github/issues-pr/Thundernerd/Unity3D-IconManager" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-IconManager/blob/master/LICENSE.md">
		<img alt="GitHub license" src ="https://img.shields.io/github/license/Thundernerd/Unity3D-IconManager" />
	</a>
	<img alt="GitHub last commit" src ="https://img.shields.io/github/last-commit/Thundernerd/Unity3D-IconManager" />
</p>

Icon Manager is a small utility that allows you to set icons on GameObjects through code.

## Installation
1. The package is available on the [openupm registry](https://openupm.com). You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).
```
openupm add net.tnrd.iconmanager
```
2. Installing through a [Unity Package](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.iconmanager?registry=https://package.openupm.com) created by the [Package Installer Creator](https://package-installer.glitch.me) from [Needle](https://needle.tools)

[<img src="https://img.shields.io/badge/-Download-success?style=for-the-badge"/>](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.iconmanager?registry=https://package.openupm.com)

## Usage
Here's how you use the IconManager
```c#
private void Foo()
{
    GameObject gameObject = FetchGameObject();
    IconManager.SetIcon(gameObject, LabelIcon.Teal);
}
```

Or by using an extension for GameObjects
```c#
private void Foo()
{
    GameObject gameObject = FetchGameObject();
    gameObject.SetIcon(ShapeIcon.CircleGreen);
}
```

Removing an icon is also possible; both through the IconManager and via an extension method
```c#
private void Foo()
{
    GameObject gameObject = FetchGameObject();

    IconManager.RemoveIcon(gameObject);
    // or
    gameObject.RemoveIcon();
}
```

## Support
**Icon Manager** is a small and open-source utility that I hope helps other people. It is by no means necessary but if you feel generous you can support me by donating.

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/J3J11GEYY)

## Contributing
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.

