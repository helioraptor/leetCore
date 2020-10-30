using NUnit.Framework;

public class UnitTest1
{
    [Test]
    public void TestTest1()
    {
        var s = new Solution();
        s.MergeKLists(null);
        Assert.Pass();
    }
}
