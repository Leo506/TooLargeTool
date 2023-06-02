# TooLargeTool
Tool for logging android bundle size

This is unofficial clone of [TooLargeTool](https://github.dev/guardian/toolargetool/) for `.NET 7`

## How to use
In your application class
```c#
public override void OnCreate()
{
    base.OnCreate();
    Tool.StartBundleLogging(this);
}
```
After that your can see in android logs records like this:
```
[TestFragment] Total bundle size is 0.0 KB with 0 keys
[MainActivity] Total bundle size is 1.1 KB with 3 keys
  android:viewHierarchyState - 0.8 bytes
  android:lastAutofillId - 0.1 bytes
  android:fragments - 0.3 bytes
```
