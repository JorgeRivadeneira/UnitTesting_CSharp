﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja1st.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            //Arrange
            var formatter = new HtmlFormatter();

            //Act
            var result = formatter.FormatAsBold("abc");

            //Assert
            
            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc").IgnoreCase);

        }
    }
}
