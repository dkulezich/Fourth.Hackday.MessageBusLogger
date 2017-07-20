using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using MessageBusReceiver;

namespace MessageBusListener
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);
        private const string SUBSCRIPTION_NAME = "ilian";
        private string connectionStringCurrentConnected = "Endpoint=sb://testmessagebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=uPsT17RkgiqRRDzqQcGzUubmxc2d05yGS/pH8Psx2KI=";
        private MessageEventListener messageEventListener;

        public override void Run()
        {
            Trace.TraceInformation("MessageBusListener is running");

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at https://go.microsoft.com/fwlink/?LinkId=166357.

            bool result = base.OnStart();

            Trace.TraceInformation("MessageBusListener has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("MessageBusListener is stopping");
            if (messageEventListener != null)
            {
                messageEventListener.StopListen();
            }

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("MessageBusListener has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME, connectionStringCurrentConnected);
            var task = Task.Run(() =>
            {
                messageEventListener.StartListen();
            });
            //messageEventListener.StartListen();           
        }
    }
}
