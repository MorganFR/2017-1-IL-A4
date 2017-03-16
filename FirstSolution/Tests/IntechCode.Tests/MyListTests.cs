using FluentAssertions;
using IntechCode.IntechCollection;
using System;
using Xunit;

namespace IntechCode.Tests
{
    [NUnit.Framework.TestFixture]
    public class MyListTests
    {
        [NUnit.Framework.Test]
        [Fact]
        public void MyList_is_initially_empty()
        {
            //Arrange
            MyList<int> l = new MyList<int>();
            //Act -- nothing
            //Assert
            l.Count.Should().Be(0);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void Add_element_to_MyList_should_return_count_1()
        {
            //Arrange
            MyList<int> l = new MyList<int>();
            //Act
            l.Add(1);
            //Assert
            l.Count.Should().Be(1);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void Add_element_to_MyList_when_table_is_full_should_return_l_16_equal_16()
        {
            //Arrange
            MyList<int> l = new MyList<int>();
            //Act
            for(int i = 0; i <= 16; i++)
            {
                l.Add(i);
            }      
            //Assert
            l[16].Should().Be(16);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void Remove_element_from_MyList_table_1_should_be_2()
        {
            //Arrange
            MyList<int> l = new MyList<int>();
            //Act
            for (int i = 0; i <= 2; i++)
            {
                l.Add(i);
            }
            l.RemoveAt(1);
            //Assert
            l[1].Should().Be(2);
        }
    }
}
