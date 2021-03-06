﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    /// <summary>
    /// Controls how the range of the bins are determined
    /// </summary>
    public enum BinningMode
    {
        /// <summary>
        /// The minimum will be equal to the sequence min and the maximum equal to infinity
        /// </summary>
        Unbounded,

        /// <summary>
        /// The minimum will be the sequnce min and the maximxum equal to sequence max
        /// The last bin will max inclusive instead of exclusive
        /// </summary>
        MaxValueInclusive,

        /// <summary>
        /// The total range will be expanded such that the min is
        /// less then the sequence min and max is greater then the sequence max
        /// </summary>
        ExpandRange
    }

    public static partial class EnumerableStats
    {
            /// <summary>
        /// Computes the Histogram of a sequence of int values.
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of int values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<int> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            var bins = BinFactory.CreateBins((double)source.Min(), (double)source.Max(), binCount, mode);
            source.AssignBins(bins);

            return bins;
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable int values.
        /// </summary>
        /// <param name="source">A sequence of nullable int values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable int values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<int?> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.AllValues().Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of int values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of int values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, int> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable int values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable int values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, int?> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        private static void AssignBins(this IEnumerable<int> source, IList<Bin> bins)
        {
            foreach (var value in source)
            {
                var bin = bins.First(b => b.Range.Contains((double)value));
                bin.Count++;
            }
        } 
                /// <summary>
        /// Computes the Histogram of a sequence of long values.
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of long values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<long> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            var bins = BinFactory.CreateBins((double)source.Min(), (double)source.Max(), binCount, mode);
            source.AssignBins(bins);

            return bins;
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable long values.
        /// </summary>
        /// <param name="source">A sequence of nullable long values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable long values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<long?> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.AllValues().Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of long values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of long values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, long> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable long values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable long values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, long?> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        private static void AssignBins(this IEnumerable<long> source, IList<Bin> bins)
        {
            foreach (var value in source)
            {
                var bin = bins.First(b => b.Range.Contains((double)value));
                bin.Count++;
            }
        } 
                /// <summary>
        /// Computes the Histogram of a sequence of float values.
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of float values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<float> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            var bins = BinFactory.CreateBins((double)source.Min(), (double)source.Max(), binCount, mode);
            source.AssignBins(bins);

            return bins;
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable float values.
        /// </summary>
        /// <param name="source">A sequence of nullable float values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable float values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<float?> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.AllValues().Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of float values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of float values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, float> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable float values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable float values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, float?> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        private static void AssignBins(this IEnumerable<float> source, IList<Bin> bins)
        {
            foreach (var value in source)
            {
                var bin = bins.First(b => b.Range.Contains((double)value));
                bin.Count++;
            }
        } 
                /// <summary>
        /// Computes the Histogram of a sequence of double values.
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of double values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<double> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            var bins = BinFactory.CreateBins((double)source.Min(), (double)source.Max(), binCount, mode);
            source.AssignBins(bins);

            return bins;
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable double values.
        /// </summary>
        /// <param name="source">A sequence of nullable double values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable double values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<double?> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.AllValues().Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of double values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, double> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable double values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, double?> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        private static void AssignBins(this IEnumerable<double> source, IList<Bin> bins)
        {
            foreach (var value in source)
            {
                var bin = bins.First(b => b.Range.Contains((double)value));
                bin.Count++;
            }
        } 
                /// <summary>
        /// Computes the Histogram of a sequence of decimal values.
        /// </summary>
        /// <param name="source">A sequence of decimal values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of decimal values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<decimal> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            var bins = BinFactory.CreateBins((double)source.Min(), (double)source.Max(), binCount, mode);
            source.AssignBins(bins);

            return bins;
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable decimal values.
        /// </summary>
        /// <param name="source">A sequence of nullable decimal values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable decimal values.</returns>
        public static IEnumerable<Bin> Histogram(this IEnumerable<decimal?> source, int binCount, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.AllValues().Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of decimal values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, decimal> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        /// <summary>
        /// Computes the Histogram of a sequence of nullable decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values to calculate the Histogram of.</param>
        /// <param name="binCount">The number of bins into which to segregate the data.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="mode">The method used to determine the range of each bin</param>
        /// <returns>The Histogram of the sequence of nullable decimal values.</returns>
        public static IEnumerable<Bin> Histogram<TSource>(this IEnumerable<TSource> source, int binCount, Func<TSource, decimal?> selector, BinningMode mode = BinningMode.Unbounded)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            if (!source.Any())
                throw new InvalidOperationException("source sequence contains no elements");

            return source.Select(t => selector(t)).Histogram(binCount, mode);
        }

        private static void AssignBins(this IEnumerable<decimal> source, IList<Bin> bins)
        {
            foreach (var value in source)
            {
                var bin = bins.First(b => b.Range.Contains((double)value));
                bin.Count++;
            }
        } 
         
    }
}