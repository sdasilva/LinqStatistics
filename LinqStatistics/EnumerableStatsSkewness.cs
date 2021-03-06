﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        /// Computes the sample Skewness of a sequence of nullable int values
        /// </summary>
        /// <param name="source">A sequence of nullable int values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness(this IEnumerable<int?> source)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.Skewness();

            return null;
        }

        /// <summary>
        /// Computes the sample Skewness of a sequence of int values
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            double mean = (double)source.Average();
            double s = (double)source.StandardDeviation();
            double M3 = 0;
            int n = 0;
            foreach(var x in source)
            {
                n++;
                M3 += Math.Pow(((double)x - mean) / s, 3.0);
            }

            if (n < 3)
                throw new InvalidOperationException("Source must have at least 3 elements");

            return (double)((M3 * n) / ((n - 1) * (n - 2)));
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of nullable int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }
 	
        /// <summary>
        /// Computes the sample Skewness of a sequence of nullable long values
        /// </summary>
        /// <param name="source">A sequence of nullable long values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness(this IEnumerable<long?> source)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.Skewness();

            return null;
        }

        /// <summary>
        /// Computes the sample Skewness of a sequence of long values
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness(this IEnumerable<long> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            double mean = (double)source.Average();
            double s = (double)source.StandardDeviation();
            double M3 = 0;
            int n = 0;
            foreach(var x in source)
            {
                n++;
                M3 += Math.Pow(((double)x - mean) / s, 3.0);
            }

            if (n < 3)
                throw new InvalidOperationException("Source must have at least 3 elements");

            return (double)((M3 * n) / ((n - 1) * (n - 2)));
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of nullable long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }
 	
        /// <summary>
        /// Computes the sample Skewness of a sequence of nullable decimal values
        /// </summary>
        /// <param name="source">A sequence of nullable decimal values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static decimal? Skewness(this IEnumerable<decimal?> source)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.Skewness();

            return null;
        }

        /// <summary>
        /// Computes the sample Skewness of a sequence of decimal values
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static decimal Skewness(this IEnumerable<decimal> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            double mean = (double)source.Average();
            double s = (double)source.StandardDeviation();
            double M3 = 0;
            int n = 0;
            foreach(var x in source)
            {
                n++;
                M3 += Math.Pow(((double)x - mean) / s, 3.0);
            }

            if (n < 3)
                throw new InvalidOperationException("Source must have at least 3 elements");

            return (decimal)((M3 * n) / ((n - 1) * (n - 2)));
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static decimal Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of nullable decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static decimal? Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }
 	
        /// <summary>
        /// Computes the sample Skewness of a sequence of nullable float values
        /// </summary>
        /// <param name="source">A sequence of nullable float values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static float? Skewness(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.Skewness();

            return null;
        }

        /// <summary>
        /// Computes the sample Skewness of a sequence of float values
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static float Skewness(this IEnumerable<float> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            double mean = (double)source.Average();
            double s = (double)source.StandardDeviation();
            double M3 = 0;
            int n = 0;
            foreach(var x in source)
            {
                n++;
                M3 += Math.Pow(((double)x - mean) / s, 3.0);
            }

            if (n < 3)
                throw new InvalidOperationException("Source must have at least 3 elements");

            return (float)((M3 * n) / ((n - 1) * (n - 2)));
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static float Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static float? Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }
 	
        /// <summary>
        /// Computes the sample Skewness of a sequence of nullable double values
        /// </summary>
        /// <param name="source">A sequence of nullable double values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.Skewness();

            return null;
        }

        /// <summary>
        /// Computes the sample Skewness of a sequence of double values
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the Skewness of.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness(this IEnumerable<double> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            double mean = (double)source.Average();
            double s = (double)source.StandardDeviation();
            double M3 = 0;
            int n = 0;
            foreach(var x in source)
            {
                n++;
                M3 += Math.Pow(((double)x - mean) / s, 3.0);
            }

            if (n < 3)
                throw new InvalidOperationException("Source must have at least 3 elements");

            return (double)((M3 * n) / ((n - 1) * (n - 2)));
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }

        /// <summary>
        ///     Computes the sample Skewness of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Skewness</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Skewness of the sequence of values.</returns>
        public static double? Skewness<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).Skewness();
        }
     }
}
