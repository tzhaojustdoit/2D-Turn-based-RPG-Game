﻿using Game.Models;
using Game.Helpers;
using System;
using System.Linq;
using NUnit.Framework;

namespace UnitTests.Helpers
{
    [NUnit.Framework.TestFixture]
    class ItemLocationEnumHelperTests
    {
        [Test]
        public void ItemLocationEnumHelper_ItemLocationEnum_Valid_1Time_6sided_Should_Between_1_and_6()
        {
            // Arrange

            // Act
            var result = ItemLocationEnumHelper.GetListItem;

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ItemLocationEnumHelper_GetLocationByPosition_1_Should_Pass()
        {
            // Arrange

            var value = 1;

            // Act
            var Actual = ItemLocationEnumHelper.GetLocationByPosition(value);
            var Expected = ItemLocationEnum.Head;

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
    }
}
