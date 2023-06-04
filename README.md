# TooLargeTool
Tool for logging android bundle size

This is unofficial clone of [TooLargeTool](https://github.dev/guardian/toolargetool/) for `.NET 7`

## How to use
In your application class
```csharp
public override void OnCreate()
{
    base.OnCreate();
    Tool.StartBundleLogging(this);
}
```
After that your can see in android logs records like this:
```
[TestFragment][OnSaveInstanceState] Total bundle size is 0.0 KB with 0 keys
[MainActivity][OnSaveInstanceState] Total bundle size is 1.3 KB with 3 keys
    android:viewHierarchyState - 0.8 KB
    android:lastAutofillId - 0.1 KB
    android:fragments - 0.4 KB
```

Starting from version `1.1.0` you can also log intent extras size by using extensions
methods.
Here the example:
```csharp
var intent = new Intent(Context, typeof(SecondActivity));
intent.PutExtra("test_key", "test_data");
StartActivityWithLoggingExtras(intent);
```
In log you can see:
```
[MainActivity][StartActivity] Total bundle size is 0.1 KB with 1 keys
    test_key - 0.1 KB
```