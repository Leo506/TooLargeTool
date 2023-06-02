using Android.Runtime;
using TooLargeTool;

namespace Sample;

[Application]
public class App : Application
{
    public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)  
    {  
    }  
    
    public override void OnCreate()
    {
        base.OnCreate();
        RegisterActivityLifecycleCallbacks(new ActivityCallback());
    }
}