﻿using NUnit.Framework;

class DataProviderTester
{
    [Test, TestCaseSource("AdditionProvider")]
    public void testAdd(int num1, int num2, int expectedResult)
    {
        // Arrange

        // Act
        int result = num1 + num2;

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    // the data provider
    static object[] AdditionProvider =
    {
        new object[] { 0, 0, 0 },
        new object[] { 1, 0, 1 },
        new object[] { 0, 1, 1 },
        new object[] { 1, 1, 2 }
    };
}