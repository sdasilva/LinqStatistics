﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable int values.
        /// </summary>
        /// <param name="source">A sequence of nullable int values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? StandardDeviationP(this IEnumerable<int?> source)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.StandardDeviationP();
            
            return null;
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of int values.
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP(this IEnumerable<int> source)
        {
            return (double)Math.Sqrt((double)source.VarianceP());
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double? StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviationP();
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviation();
        }
 	
        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable long values.
        /// </summary>
        /// <param name="source">A sequence of nullable long values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? StandardDeviationP(this IEnumerable<long?> source)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.StandardDeviationP();
            
            return null;
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of long values.
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP(this IEnumerable<long> source)
        {
            return (double)Math.Sqrt((double)source.VarianceP());
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double? StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviationP();
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviation();
        }
 	
        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable decimal values.
        /// </summary>
        /// <param name="source">A sequence of nullable decimal values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static decimal? StandardDeviationP(this IEnumerable<decimal?> source)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.StandardDeviationP();
            
            return null;
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of decimal values.
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static decimal StandardDeviationP(this IEnumerable<decimal> source)
        {
            return (decimal)Math.Sqrt((double)source.VarianceP());
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static decimal? StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviationP();
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of decimal values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static decimal StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviation();
        }
 	
        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable float values.
        /// </summary>
        /// <param name="source">A sequence of nullable float values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static float? StandardDeviationP(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.StandardDeviationP();
            
            return null;
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of float values.
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static float StandardDeviationP(this IEnumerable<float> source)
        {
            return (float)Math.Sqrt((double)source.VarianceP());
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static float? StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviationP();
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static float StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviation();
        }
 	
        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable double values.
        /// </summary>
        /// <param name="source">A sequence of nullable double values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values, or null if the source sequence is
        ///     empty or contains only values that are null.
        /// </returns>
        public static double? StandardDeviationP(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.StandardDeviationP();
            
            return null;
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of double values.
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the population StandardDeviation of.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP(this IEnumerable<double> source)
        {
            return (double)Math.Sqrt((double)source.VarianceP());
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double? StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviationP();
        }

        /// <summary>
        /// Computes the population StandardDeviation of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>       
        ///     The population StandardDeviation of the sequence of values.
        /// </returns>
        public static double StandardDeviationP<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).StandardDeviation();
        }
     }
}