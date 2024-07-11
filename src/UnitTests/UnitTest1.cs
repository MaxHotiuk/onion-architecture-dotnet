using Core;

namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Class1 class1 = new();
        Assert.NotNull(class1);
    }
}