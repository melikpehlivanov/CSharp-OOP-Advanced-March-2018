﻿namespace _03.DependencyInversion.Models.Strategies
{
    using E03_DependencyInversion.Interfaces;

    public class MultiplyStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
