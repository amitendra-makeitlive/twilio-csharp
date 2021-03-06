/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Events.V1.Sink;

namespace Twilio.Tests.Rest.Events.V1.Sink
{

    [TestFixture]
    public class SinkValidateTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Events,
                "/v1/Sinks/DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Validate",
                ""
            );
            request.AddPostParam("TestId", Serialize("test_id"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SinkValidateResource.Create("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "test_id", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"result\": \"valid\"}"
                                     ));

            var response = SinkValidateResource.Create("DGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "test_id", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}