using Android.Runtime;
using Serilog;
using Serilog.Extensions.Logging;
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
        
#if SERILOGLOG
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "log.txt"))
            .CreateLogger();
        Tool.StartBundleLogging(this, new SerilogLoggerProvider(Log.Logger));
#else
        Tool.StartBundleLogging(this);
#endif
    }
}