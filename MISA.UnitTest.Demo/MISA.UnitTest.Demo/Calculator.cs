using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.UnitTest.Demo
{
    /// <summary>
    /// máy tính
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// tổng
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int add(int x,int y)
        {
            return x + y;
        }

        /// <summary>
        /// hiệu
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Subtract(int x,int y)
        {
            return x - y;
        }

        /// <summary>
        /// tích
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// thương
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
       /* public int Division(int x, int y)
        {
            return x / y;
        }
        */
        public int? Division(int x,int y)
        {
            if (y == 0)
                return null;
            return x / y;
        }
    }
}
