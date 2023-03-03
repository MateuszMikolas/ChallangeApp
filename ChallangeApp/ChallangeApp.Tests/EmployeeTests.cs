using Intuit.Ipp.Data;

namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectMinusPoints_ShouldReturnCorrectResult()
        {
            var user = new Employee("Mateusz", "Mikolas", 31);
            user.MinScore(6);
            user.MinScore(2);
            user.MinScore(58);

            var result = user.ScoreSum;

            Assert.AreEqual(-66, result);
        }
        [Test]
        public void WhenEmployeeCollectPlusPoints_ShouldReturnCorrectResult()
        {
            var user = new Employee("Mateusz", "Mikolas", 31);
            user.AddScore(12);
            user.AddScore(3);
            user.AddScore(34);

            var result = user.ScoreSum;

            Assert.AreEqual(49, result);
        }
        [Test]
        public void WhenEmployeeCollectPlusAndMinusPoints_ShouldReturnCorrectResult()
        {
            var user = new Employee("Mateusz", "Mikolas", 31);
            user.AddScore(1);
            user.AddScore(13);
            user.MinScore(5);
            user.MinScore(2);

            var result = user.ScoreSum;

            Assert.AreEqual(7, result);
        }
        [Test]
        public void NewEmpleyee_ReturnCorrectValue()
        {
            var user = new Employee("Mateusz", "Mikolas", 31);

            var resultName = user.Name;
            
            Assert.AreEqual("Mateusz", resultName);
            Assert.AreEqual("Mikolas", user.Surname);
            Assert.AreEqual(31, user.Age);
        }
    }
}