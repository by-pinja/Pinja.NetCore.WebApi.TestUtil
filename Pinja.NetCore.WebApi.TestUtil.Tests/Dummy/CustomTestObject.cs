namespace Pinja.NetCore.WebApi.TestUtil.Tests
{
    public class CustomTestObject
    {
        public CustomTestObject(string c)
        {
            Content = c;
        }

        public string Content { get; }
    }
}