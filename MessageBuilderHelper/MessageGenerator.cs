using System;
using Fourth.Orchestration.Model.ProductCatalogue;
using People = Fourth.Orchestration.Model.People;
using Common = Fourth.Orchestration.Model.Common;
using System.Collections;
using System.Collections.Generic;
using Fourth.Orchestration.Storage.Azure;
using Fourth.Orchestration.Messaging.Azure;
using Fourth.Orchestration.Messaging;

namespace MessageBuilderHelper
{
    public class MessageGenerator
    {
        /*
         15200 - Leicester
         15298 - Barry Pub789
         16202 - TestingNotCurrency
         16199 - 11 test
        */
        private IList<long> locationIds = new List<long> { 15200, 15298, 16202 }; // 16199 - used by the mobile team
        private IList<long> productIds = new List<long> { 12345, 12157, 31892, 31893, 31894, 31895, 31896 };
        private Random randomGenerator;

        public MessageGenerator()
        {
            this.randomGenerator = new Random();
        }

        public Events.ProductLocationsModified CreateProductLocationsModified()
        {
            var newProductLocationBuilder = Events.ProductLocationsModified.CreateBuilder();
            newProductLocationBuilder.SetSequenceNumber(Fourth.Orchestration.Model.SequenceNumbers.GetNext());
            newProductLocationBuilder.SetCustomerCanonicalId("0018E00000UGGbqQAH");
            newProductLocationBuilder.SetSource(Events.SourceSystem.R9);
            newProductLocationBuilder.SetProductExternalId(productIds[this.randomGenerator.Next(productIds.Count)]);
            newProductLocationBuilder.SetProductExternalClass(Events.ProductClass.PRODUCT_ITEM);

            var newLocationAssignment = Events.ProductLocationsModified.Types.LocationAssignment.CreateBuilder();
            newLocationAssignment.SetLocationExternalId(locationIds[this.randomGenerator.Next(locationIds.Count)]);

            var parLevel = Common.Decimal.BuildFromDecimal(decimal.Parse(this.randomGenerator.Next(10).ToString()));
            newLocationAssignment.SetParLevel(parLevel);

            newProductLocationBuilder.AddLocationAssignments(newLocationAssignment.Build());

            return newProductLocationBuilder.Build();
        }

        public People.Events.AccountCreated CreateAccountCreated()
        {
            var builder = People.Events.AccountCreated.CreateBuilder();

            builder.SetInternalId("FAS_TEST")
                    .SetEmailAddress("test_fas_4gki32uoi")
                    .SetExternalId("")
                    .SetFirstName("test_4gki32uoi")
                    .SetInternalId("")
                    .SetLastName("")
                    .SetStatus(People.Events.AccountStatus.ACTIVE)
                    .SetLocale("")
                    .SetCustomerCanonicalId("")
                    .SetLastName("fas_4gki32uoi")
                    .SetSource(People.Events.SourceSystem.R9);

            var message = builder.Build();

            return message;
        }
    }
}
