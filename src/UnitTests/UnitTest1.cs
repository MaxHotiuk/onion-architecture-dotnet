using Core;

namespace UnitTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        Class1 class1 = new();
        Assert.NotNull(class1);
    }
}