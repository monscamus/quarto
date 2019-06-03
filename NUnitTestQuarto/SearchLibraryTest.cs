using NUnit.Framework;
using System;

namespace Tests
{
    class SearchLibraryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SearchSingleInteger()
        {
            int[] testArray = new int[] {1,2,2,3,3};

            IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();

            Assert.AreEqual(search.FindUnpairedElement(testArray), 1);            

        }

        [Test]
        public void SearchNoSingleInteger()
        {
            
            int[] testArray = new int[] { 1, 1, 2, 2, 3, 3 };

            IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();

            Assert.Throws(typeof(ApplicationException), delegate { search.FindUnpairedElement(testArray); });

        }

        [Test]
        public void SearchSingleInteger2()
        {
            int[] testArray = new int[] { 1, 1, 2, 2, 4, 3, 3 };

            IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();

            int singleElement = search.FindUnpairedElement(testArray);

            Assert.Greater(singleElement, -1);
            Assert.AreEqual(singleElement, 4);    

        }

        [Test]
        public void SearchSingleInteger3()
        {
            int[] testArray = new int[] { 1, 1, 2, 2, 4, 3, 3, 5, 5, 7, 7 };

            IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();

            int singleElement = search.FindUnpairedElement(testArray);

            Assert.AreEqual(singleElement, 4);
        }

        [Test]
        public void SearchSingleIntegerAmbigious()
        {
                int[] testArray = new int[] { 1, 1, 2, 2, 4, 3, 3, 9 };

                IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();

                Assert.Throws(typeof(ApplicationException), delegate { search.FindUnpairedElement(testArray); });
        }

        [Test]
        public void SearchSingleIntegerQuickFail()
        {
                int[] testArray = new int[] { 1, 1, 2, 2, 4, 3, 3, 9 };

                IntegerUtility.SearchLibrary search = new IntegerUtility.SearchLibrary();
                
                Assert.Throws(typeof(ApplicationException), delegate { search.FindUnpairedElement(testArray); });
        }

    }
}
