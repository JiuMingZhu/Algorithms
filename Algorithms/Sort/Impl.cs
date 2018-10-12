using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    internal interface ISortFunc
    {
        /// <summary>
        /// Sort Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        void Sort<T>(T[] array);
        /// <summary>
        /// compare to element in array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="v"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        bool Less<T>(T v,T w);
        /// <summary>
        /// exchange two element in array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void Exch<T>(T[] array,int a ,int b);
        /// <summary>
        /// print array to console
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        void Show<T>(T[] array);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        bool IsSorted<T>(T[] array);
    }
}
