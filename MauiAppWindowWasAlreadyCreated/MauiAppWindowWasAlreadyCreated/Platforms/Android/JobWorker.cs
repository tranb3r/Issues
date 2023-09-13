using Android.Content;
using Android.Util;
using AndroidX.Work;

namespace MauiAppWindowWasAlreadyCreated
{
    internal class JobWorker : Worker
    {
        public JobWorker(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {
        }

        public override Result DoWork()
        {
            Log.Info("MauiAppWindowWasAlreadyCreated", "DoWork");

            Platform.CurrentActivity?.Finish();

            return Result.InvokeSuccess();
        }
    }
}
