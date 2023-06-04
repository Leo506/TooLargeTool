using Android.Content;
using Android.Views;
using TooLargeTool.Extensions;

namespace Sample;

public class TestFragment : Fragment, View.IOnClickListener
{
    public override View? OnCreateView(LayoutInflater? inflater, ViewGroup? container, Bundle? savedInstanceState)
    {
        return inflater.Inflate(Resource.Layout.test_fragment, container, false);
    }

    public override void OnViewCreated(View? view, Bundle? savedInstanceState)
    {
        base.OnViewCreated(view, savedInstanceState);
        var button = View?.FindViewById<Button>(Resource.Id.startActivityButton);
        button?.SetOnClickListener(this);
    }

    public void OnClick(View? v)
    {
        var intent = new Intent(Context, typeof(SecondActivity));
        intent.PutExtra("test_key", "test_data");
        Activity?.StartActivityWithLoggingExtras(intent);
    }
}