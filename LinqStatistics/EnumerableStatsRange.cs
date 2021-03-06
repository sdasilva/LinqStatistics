﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
    	/// <summary>
    	/// Computes the Range of a sequence of nullable int values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static int? Range(this IEnumerable<int?> source)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.Range();

            return null;
        }

    	/// <summary>
    	/// Computes the Range of a sequence of int values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static int Range(this IEnumerable<int> source)
        {
            return source.Max() - source.Min();
        }

        /// <summary>
        ///     Computes the Range of a sequence of nullable int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static int? Range<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }

        /// <summary>
        ///     Computes the Range of a sequence of int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static int Range<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }
 	
    	/// <summary>
    	/// Computes the Range of a sequence of nullable long values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static long? Range(this IEnumerable<long?> source)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.Range();

            return null;
        }

    	/// <summary>
    	/// Computes the Range of a sequence of long values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static long Range(this IEnumerable<long> source)
        {
            return source.Max() - source.Min();
        }

        /// <summary>
        ///     Computes the Range of a sequence of nullable long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static long? Range<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }

        /// <summary>
        ///     Computes the Range of a sequence of long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static long Range<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }
 	
    	/// <summary>
    	/// Computes the Range of a sequence of nullable float values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static float? Range(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.Range();

            return null;
        }

    	/// <summary>
    	/// Computes the Range of a sequence of float values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static float Range(this IEnumerable<float> source)
        {
            return source.Max() - source.Min();
        }

        /// <summary>
        ///     Computes the Range of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static float? Range<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }

        /// <summary>
        ///     Computes the Range of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static float Range<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }
 	
    	/// <summary>
    	/// Computes the Range of a sequence of nullable double values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static double? Range(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.Range();

            return null;
        }

    	/// <summary>
    	/// Computes the Range of a sequence of double values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static double Range(this IEnumerable<double> source)
        {
            return source.Max() - source.Min();
        }

        /// <summary>
        ///     Computes the Range of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static double? Range<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }

        /// <summary>
        ///     Computes the Range of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static double Range<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }
 	
    	/// <summary>
    	/// Computes the Range of a sequence of nullable decimal values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static decimal? Range(this IEnumerable<decimal?> source)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.Range();

            return null;
        }

    	/// <summary>
    	/// Computes the Range of a sequence of decimal values.
    	/// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The Range.</returns>
        public static decimal Range(this IEnumerable<decimal> source)
        {
            return source.Max() - source.Min();
        }

        /// <summary>
        ///     Computes the Range of a sequence of nullable decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static decimal? Range<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }

        /// <summary>
        ///     Computes the Range of a sequence of decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Range.</returns>
        public static decimal Range<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Range();
        }
     }
}