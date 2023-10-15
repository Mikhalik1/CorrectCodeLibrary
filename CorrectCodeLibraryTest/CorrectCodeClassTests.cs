using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTest
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        /// <summary>
        /// Проверка верных тестов
        /// </summary>
        /// <param name="text"></param>
        [DataTestMethod]
        //данные
        [DataRow("1234123400")]
        [DataRow("3000030001")]
        [DataRow("3000130009")]
        [DataRow("1212121219")]
        //данные

        public void CorrectCodeClass_alltruetest_true(string text)
        {
            //act
            bool result = CorrectCodeClass.IsCorrectCode(text);
            Console.WriteLine(text);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Проверка ложных тестов
        /// </summary>
        /// <param name="text"></param>
        [DataTestMethod]
        //данные
        [DataRow("")] 
        [DataRow("123")]
        [DataRow("123123123123123")]
        [DataRow("strokasymb")]
        [DataRow("1234123401")]
        [DataRow("1234123404")]
        //данные
        public void CorrectCodeClass_allfalsetest_false(string text)
        {
            //act
            bool result = CorrectCodeClass.IsCorrectCode(text);
            Console.WriteLine(text);
            //assert
            Assert.IsFalse(result);
        }
    }
}
