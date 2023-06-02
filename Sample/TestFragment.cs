using Android.Views;

namespace Sample;

public class TestFragment : Fragment
{
    public override View? OnCreateView(LayoutInflater? inflater, ViewGroup? container, Bundle? savedInstanceState)
    {
        return inflater.Inflate(Resource.Layout.test_fragment, container, false);
    }
}