using System;
using Xunit;

namespace TestFirstResponsiveWebApp
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
           
            string FirstName = "name";
            int BirthYear = "2001"

            string expected = "name 21";
            string actual;

            
            actual = FirstResponsiveWebAppSherzan.();

          
            Assert.Equal(expected, actual);
        }
    }
}
