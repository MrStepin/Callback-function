using NUnit.Framework;
using System;
using Callback_functions;

namespace Test
{
    public class Tests
    {
        private int[] Massive = new int[5] { 5, 4, 2, 3, -1};
        Checker<int> checker = new Checker<int>();

        [TestCase]
        public void CheckMoreThanThreeCondition()
        {
            bool MoreThree(int num)
            {
                return num > 3;
            }
            CollectionAssert.DoesNotContain(checker.ResultList(Massive, MoreThree),3);
            CollectionAssert.Contains(checker.ResultList(Massive, MoreThree), 4);
        }

        [TestCase]
        public void CheckEvenCondition()
        {
            bool Even(int num)
            {
                return num%2 ==0;
            }
            CollectionAssert.DoesNotContain(checker.ResultList(Massive, Even), 3);
            CollectionAssert.Contains(checker.ResultList(Massive, Even), 4);
        }
        [TestCase]
        public void CheckOddCondition()
        {
            bool Odd(int num)
            {
                return num % 2 != 0;
            }
            CollectionAssert.DoesNotContain(checker.ResultList(Massive, Odd), 2);
            CollectionAssert.Contains(checker.ResultList(Massive, Odd), -1);
            CollectionAssert.Contains(checker.ResultList(Massive, Odd), 5);
        }
        [TestCase]
        public void CheckMinusCondition()
        {
            bool Minus(int num)
            {
                return num < 0;
            }
            CollectionAssert.DoesNotContain(checker.ResultList(Massive, Minus), 2);
            CollectionAssert.Contains(checker.ResultList(Massive, Minus), -1);
        }
        [TestCase]
        public void CheckAnyAndAll()
        {
            bool MoreThree(int num)
            {
                return num > 3;
            }

            Assert.IsTrue(Massive.AnyNum(MoreThree));
            Assert.False(Massive.AllNum(MoreThree));
        }
    }
}
