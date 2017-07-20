using System.Diagnostics;
using System.Net;
using System.Threading;
using Microsoft.WindowsAzure.ServiceRuntime;
using MessageBusReceiver;

namespace WorkerRoleMessageBus
{
    public class WorkerRole : RoleEntryPoint
    {
        ManualResetEvent CompletedEvent = new ManualResetEvent(false);
        private const string SUBSCRIPTION_NAME = "MessageBusLogger";
        private string connectionStringCurrentConnected = "Endpoint=sb://rntestorchestration.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=o4SfS9q+vyffUM10ydy+ccN3Av94GZiNVV2/dyep3j0=";
        private MessageEventListener messageEventListener;

        public override void Run()
        {
            Trace.WriteLine("Starting processing of messages");
            
            messageEventListener = new MessageEventListener(SUBSCRIPTION_NAME, connectionStringCurrentConnected);
            messageEventListener.StartListen();

            CompletedEvent.WaitOne();
        }

        public override bool OnStart()
        {
            ServicePointManager.DefaultConnectionLimit = 12;
            return base.OnStart();
        }

        public override void OnStop()
        {
            if(messageEventListener != null)
            {
                messageEventListener.StopListen();
            }

            CompletedEvent.Set();
            base.OnStop();
        }
    }
}
