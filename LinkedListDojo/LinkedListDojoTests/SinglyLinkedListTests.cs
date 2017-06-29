using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {
        [TestMethod()]
        public void SinglyLinkedListIsNotNullTest()
        {
            Assert.IsNotNull(new SinglyLinkedList());
        }
    }
}