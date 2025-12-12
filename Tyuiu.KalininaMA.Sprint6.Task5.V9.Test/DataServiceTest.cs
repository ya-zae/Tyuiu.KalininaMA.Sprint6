using Tyuiu.KalininaMA.Sprint6.Task5.V9.Lib;
namespace Tyuiu.KalininaMA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KalininaMA.Sprint6\Tyuiu.KalininaMA.Sprint6.Task5.V9\bin\Debug\InPutDataFileTask5V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
