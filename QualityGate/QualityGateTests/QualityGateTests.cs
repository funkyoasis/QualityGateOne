using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QualityGate;

namespace QualityGateTests
{
	public class QualityGateTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(new int[]{1,2,3,4}, 1234)]
		[TestCase(new int[] {2,2,3,4,2,3}, 223423)]
		public void GivenAnArrayOfIntegers_IntegerPasser_ReturnsOneIntegerOfAllValues(int[] inputArray, int expectedInteger)
		{
			Assert.That(() => Program.IntegerPasser(inputArray), Is.EqualTo(expectedInteger));
		}
	}
}