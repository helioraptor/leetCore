using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    /*
    Input: "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.
    */
    [Test]
    public void Test1()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring("abcabcbb");
        Assert.AreEqual(3, l);
    }

    /*
    Input: "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.
    */
    [Test]
    public void Test2()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring("bbbbb");
        Assert.AreEqual(1, l);
    }

    /*
    Input: "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.
    Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    */
    [Test]
    public void Test3()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring("pwwkew");
        Assert.AreEqual(3, l);
    }

    [Test]
    public void Test4()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring(" ");
        Assert.AreEqual(1, l);
    }

    [Test]
    public void Test5()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring("abc");
        Assert.AreEqual(3, l);
    }

    [Test]
    public void Test6()
    {
        var t = new Solution();
        var l = t.lengthOfLongestSubstring("aabaab!bb");
        Assert.AreEqual(3, l);
    }
}