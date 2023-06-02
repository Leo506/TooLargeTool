#pragma warning disable CA1422
#pragma warning disable CA1416
using TooLargeTool;

namespace Sample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        
        FragmentManager?.RegisterFragmentLifecycleCallbacks(new FragmentCallback(), true);

        FragmentManager?.BeginTransaction()
            ?.Replace(Resource.Id.fragmentFrame, new TestFragment())
            ?.Commit();
    }
}
#pragma warning restore CA1416
#pragma warning restore CA1422
