using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Model.People;
using Fourth.Orchestration.Storage.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBuilderHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageStore = new AzureMessageStore();
            var messageFactory = new AzureMessagingFactory(messageStore);
            var messageBus = messageFactory.CreateMessageBus();
            var messageGenerator = new MessageGenerator();

            for (int i = 0; i < 5; i++)
            {
                var message = messageGenerator.CreateProductLocationsModified();
                messageBus.Publish(message);
                Console.WriteLine("{0} - {1}", i + 1, message.ToString());
                Console.WriteLine();
                //System.Threading.Thread.Sleep(1000);
            }

            for (int i = 0; i < 5; i++)
            {
                var message = messageGenerator.CreateAccountCreated();
                messageBus.Publish(message);

                Console.WriteLine("{0} - {1}", i + 1, message.ToString());
                Console.WriteLine();
            }
        }
    }
}
