using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace FluenAssertionsNullConditional;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var a = new A();
        using (new AssertionScope())
        {
            a?.B?.Obj.Should().NotBeNull("reason 1"); //passes, incorrectly
            (a?.B?.Obj).Should().NotBeNull("reason 2");//fails, correctly
        }
    }
}

public class A
{
    public B? B { get; set; } = null;
}

public class B
{
    public object? Obj { get; set; } = null;
}



