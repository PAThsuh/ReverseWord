using ReverseWord;

namespace ReverseWordTest
{
    [TestClass]
    public class UnitTestReverseWord
    {
        [TestMethod]
        public void TestReverseWord()
        {
            WordReverse wordReverse = new WordReverse();

            Assert.AreEqual("irtS_gn;-%   b2$#e desrever", wordReverse.reverse_words("Stri_ng;-%   2b$#e reversed"));
        }
    }
}