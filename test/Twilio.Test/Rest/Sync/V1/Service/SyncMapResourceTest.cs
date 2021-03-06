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
using Twilio.Rest.Sync.V1.Service;

namespace Twilio.Tests.Rest.Sync.V1.Service
{

    [TestFixture]
    public class SyncMapTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Sync,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Maps/MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SyncMapResource.Fetch("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"date_expires\": \"2015-07-30T21:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"items\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items\",\"permissions\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Permissions\"},\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SyncMapResource.Fetch("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Sync,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Maps/MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SyncMapResource.Delete("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SyncMapResource.Delete("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Sync,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Maps",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SyncMapResource.Create("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"date_expires\": \"2015-07-30T21:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"items\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items\",\"permissions\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Permissions\"},\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SyncMapResource.Create("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Sync,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Maps/MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SyncMapResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"date_expires\": \"2015-07-30T21:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"items\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items\",\"permissions\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Permissions\"},\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SyncMapResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Sync,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Maps",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SyncMapResource.Read("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"maps\": [],\"meta\": {\"first_page_url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps?PageSize=50&Page=0\",\"key\": \"maps\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps?PageSize=50&Page=0\"}}"
                                     ));

            var response = SyncMapResource.Read("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"maps\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_by\": \"created_by\",\"date_expires\": \"2015-07-30T21:00:00Z\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"links\": {\"items\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Items\",\"permissions\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Permissions\"},\"revision\": \"revision\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps/MPaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}],\"meta\": {\"first_page_url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps?PageSize=50&Page=0\",\"key\": \"maps\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://sync.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Maps?PageSize=50&Page=0\"}}"
                                     ));

            var response = SyncMapResource.Read("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}