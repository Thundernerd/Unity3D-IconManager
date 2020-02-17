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

## Contributing
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.

## Installing
Installing Icon Manager into your Unity3D project is done through the [Package Manager](https://docs.unity3d.com/Manual/Packages.html).

You can either add the package manually to the [manifest.json](https://docs.unity3d.com/Manual/upm-dependencies.html) file:
```json
{
    "dependencies": {
        "net.tnrd.constrainedrect": "https://github.com/thundernerd/unity3d-iconmanager"
    }
}
```

Or add it through the UI by selecting the **+ button** in the top left of the Package Manager, selecting _Add package from git URL..._, and pasting https://github.com/Thundernerd/Unity3D-IconManager.git in the input field.

