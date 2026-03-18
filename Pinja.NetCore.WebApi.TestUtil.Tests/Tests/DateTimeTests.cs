using System;
using System.Net;
using System.Threading.Tasks;
using AwesomeAssertions;
using Pinja.NetCore.WebApi.TestUtil.Tests.Dummy;
using Xunit;

namespace Pinja.NetCore.WebApi.TestUtil.Tests.Tests
{
    public class DateTimeTests
    {
        [Fact]
        public async Task WhenTimeIsReturnedFromApiInUtc_ThenParseItCorrectlyAsNonLocalTime()
        {
            var expectedDate = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            await TestHost.Run<TestStartup>().Post("/datetimetestroute/", new { DateValue = expectedDate })
                .ExpectStatusCode(HttpStatusCode.OK)
                .WithContentOf<DummyRequest>()
                .Passing(x => x.DateValue.Should().Be(expectedDate));
        }
    }
}