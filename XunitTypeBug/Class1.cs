using System;
using System.Data.SqlClient;
using System.Windows;
using AnotherAssembly;
using Xunit;

namespace XunitTypeBug
{
    public class Tests
    {
        [Theory]
        [InlineData(typeof(int))]
        [InlineData(typeof(string))]
        [InlineData(typeof(MyType))]
        [InlineData(typeof(ExternalType))]
        [InlineData(typeof(GridLength))]
        [InlineData(typeof(SqlCommand))]
        public void TypeOfTests(Type type)
        {
            Assert.NotNull(type);
        }
    }

    public class MyType{}
}
