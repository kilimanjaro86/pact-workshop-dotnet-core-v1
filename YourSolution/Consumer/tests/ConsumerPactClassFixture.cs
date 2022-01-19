using System;
using Xunit;
using PactNet;
using PactNet.Mocks.MockHttpService;

namespace tests
{
    // This class is responsible for setting up a shared
    // mock server for Pact used by all the tests.
    // XUnit can use a Class Fixture for this.
    // See: https://goo.gl/hSq4nv
    public class ConsumerPactClassFixture
    {
        public IPactBuilder PactBuilder {get; private set; }
        public IMockProvider MockPoviderService { get; private set; }

        public int MockServicePort {get {return 9222; } }
        public string MockPoviderServiceBaseUri {get { return String.Format("http://localhost:{0}", MockServicePort); } }
    }
}