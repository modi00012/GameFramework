//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace GX
{
    public static partial class Utility
    {
        /// <summary>
        /// 随机相关的实用函数。
        /// </summary>
        public static partial class Random
        {
            private static System.Random s_Random = new System.Random((int)DateTime.Now.Ticks);

            /// <summary>
            /// 设置随机数种子。
            /// </summary>
            /// <param name="seed">随机数种子。</param>
            public static void SetSeed(int seed)
            {
                s_Random = new System.Random(seed);
            }

            /// <summary>
            /// 返回非负随机数。
            /// </summary>
            /// <returns>大于等于零且小于 System.Int32.MaxValue 的 32 位带符号整数。</returns>
            public static int GetRandom()
            {
                return s_Random.Next();
            }

            /// <summary>
            /// 返回一个小于所指定最大值的非负随机数。
            /// </summary>
            /// <param name="maxValue">要生成的随机数的上界（随机数不能取该上界值）。maxValue 必须大于等于零。</param>
            /// <returns>大于等于零且小于 maxValue 的 32 位带符号整数，即：返回值的范围通常包括零但不包括 maxValue。不过，如果 maxValue 等于零，则返回 maxValue。</returns>
            public static int GetRandom(int maxValue)
            {
                return s_Random.Next(maxValue);
            }

            /// <summary>
            /// 返回一个指定范围内的随机数。
            /// </summary>
            /// <param name="minValue">返回的随机数的下界（随机数可取该下界值）。</param>
            /// <param name="maxValue">返回的随机数的上界（随机数不能取该上界值）。maxValue 必须大于等于 minValue。</param>
            /// <returns>一个大于等于 minValue 且小于 maxValue 的 32 位带符号整数，即：返回的值范围包括 minValue 但不包括 maxValue。如果 minValue 等于 maxValue，则返回 minValue。</returns>
            public static int GetRandom(int minValue, int maxValue)
            {
                return s_Random.Next(minValue, maxValue);
            }

            /// <summary>
            /// 返回一个介于 0.0 和 1.0 之间的随机数。
            /// </summary>
            /// <returns>大于等于 0.0 并且小于 1.0 的双精度浮点数。</returns>
            public static double GetRandomDouble()
            {
                return s_Random.NextDouble();
            }

            /// <summary>
            /// 用随机数填充指定字节数组的元素。
            /// </summary>
            /// <param name="buffer">包含随机数的字节数组。</param>
            public static void GetRandomBytes(byte[] buffer)
            {
                s_Random.NextBytes(buffer);
            }
        }

        /// <summary>
        /// ref https://github.com/Gibibit/RandomExtensions/blob/master/RandomExtensions/RandomExtensions.cs
        /// </summary>
        public static partial class Random
        {
            //#region MonoGame

            //public static Point NextPoint(this Random r, int xMin, int yMin, int xMax, int yMax) => new Point(xMin + r.Next(xMax - xMin), yMin + r.Next(yMax - yMin));
            //public static Vector2 NextVector2Direction(this Random r) => Vector2.Normalize(new Vector2(r.NextFloat(), r.NextFloat()));
            //public static Vector3 NextVector3Direction(this Random r) => Vector3.Normalize(new Vector3(r.NextFloat(), r.NextFloat(), r.NextFloat()));
            //public static Color NextColor(this Random r) => new Color(NextVector3Direction(r));
            //public static Matrix NextRotationX(this Random r) => Matrix.CreateRotationX(r.NextFloat() * MathHelper.TwoPi);
            //public static Matrix NextRotationY(this Random r) => Matrix.CreateRotationY(r.NextFloat() * MathHelper.TwoPi);
            //public static Matrix NextRotationZ(this Random r) => Matrix.CreateRotationZ(r.NextFloat() * MathHelper.TwoPi);
            ///// <summary>
            ///// Rotates a Vector2 to a random direction
            ///// </summary>
            //public static Vector2 NextRotateVector2(this Random r, Vector2 v) => r.NextVector2Direction() * v.Length();
            ///// <summary>
            ///// Rotates a Vector3 to a random direction
            ///// </summary>
            //public static Vector3 NextRotateVector3(this Random r, Vector3 v) => r.NextVector3Direction() * v.Length();
            //#endregion MonoGame
            //#region Collections
            ///// <summary>
            ///// Chooses a random element from a given list.
            ///// </summary>
            //public static T Choose<T>(this Random r, IList<T> list) => list[r.Next(list.Count)];
            ///// <summary>
            ///// Chooses a random element from a given array or parameters.
            ///// </summary>
            //public static T Choose<T>(this Random r, params T[] items) => items[r.Next(items.Length)];
            //#endregion Collections
            //#region Float
            //public static float NextFloat(this Random r) => (float)r.NextDouble();
            //#endregion
            //#region Strings
            //public static string NextString(this Random r, int length)
            //{
            //    var result = "";
            //    for (int i = 0; i < length; i++) result += r.NextChar();
            //    return result;
            //}
            //public static char NextChar(this Random r) => (char)r.Next(char.MaxValue);
            //// Some useful ASCII numbers
            //private const int ASCII_FIRST_NON_CTRL_CHAR = 32;
            //private const int ASCII_LAST_CHAR = 255;
            ///// <summary>
            ///// Returns a random (non-control code) ASCII character.
            ///// </summary>
            //public static char NextCharASCII(this Random r) => (char)(r.Next(ASCII_FIRST_NON_CTRL_CHAR, ASCII_LAST_CHAR + 1));
            ///// <summary>
            ///// Returns a random ASCII string of specified length that does not contain any control code characters.
            ///// </summary>
            //public static string NextStringASCII(this Random r, int length)
            //{
            //    var result = "";
            //    for (int i = 0; i < length; i++) result += r.NextCharASCII();
            //    return result;
            //}
            //// ASCII lowercase letter codes
            //private const int ASCII_LOWER_A = 97;
            //private const int ASCII_LOWER_Z = 122;
            //public static char NextCharLowerAlphabetic(this Random r) => (char)r.Next(ASCII_LOWER_A, ASCII_LOWER_Z + 1);
            //public static string NextStringLowerAlphabetic(this Random r, int length)
            //{
            //    var result = "";
            //    for (int i = 0; i < length; i++) result += r.NextCharLowerAlphabetic();
            //    return result;
            //}
            //#endregion Strings
            ///// <summary>
            ///// Creates a Distribution using specified values and their frequencies. A distribution can be used to retrieve random values with desired frequencies.
            ///// </summary>
            ///// <typeparam name="T">Type of the values in the distribution</typeparam>
            ///// <param name="rand">The random instance used to select values</param>
            ///// <param name="distribution">Dictionary of values and frequencies with Dictionary keys acting as values and Dictionary values acting as frequencies.</param>
            ///// <returns>An instance of Distribution which returns the specified values in the specified frequencies.</returns>
            //public static Distribution<T> NextDistribution<T>(this Random rand, Dictionary<T, int> distribution) => new Distribution<T>(rand, distribution);
        }

        /// <summary>
        /// Class that adds extension methods for IEnumerable for choosing and taking random elements.
        /// </summary>
        public static partial class Random
        {
            //    /// <summary>
            //    /// The amount of times random operations that might fail will retry before throwing an <see cref="TooManyTriesException"/>.
            //    /// </summary>
            //    public static int AttemptCount { get; set; } = 50;

            //    /// <summary>
            //    /// Private accessor to the global RNG instance.
            //    /// </summary>
            //    private static IRandomGenerator Random => RandomGenerator.Instance;

            //    /// <summary>
            //    /// Generates an <see cref="IEnumerable{T}"/> with the specified <paramref name="generationFunction"/>.
            //    /// </summary>
            //    /// <typeparam name="T">The type of elements to generate.</typeparam>
            //    /// <param name="generationFunction">The function used to generate the elements.</param>
            //    /// <param name="amount">The amount of elements to generate.</param>
            //    /// <returns>A generated enumerable.</returns>
            //    public static IEnumerable<T> GenerateRandom<T>(Func<T> generationFunction, int amount)
            //    {
            //        T[] generated = new T[amount];

            //        for (int index = 0; index < amount; index++)
            //            generated[index] = generationFunction();

            //        return generated;
            //    }

            //    /// <summary>
            //    /// Uses the <paramref name="generationFunction"/> to generate a value that satisfies the <paramref name="validationPredicate"/>.
            //    /// </summary>
            //    /// <param name="generationFunction">The function that generates values.</param>
            //    /// <param name="validationPredicate">The predicate that validates.</param>
            //    /// <returns>A generated value that satisfies the <paramref name="validationPredicate"/>.</returns>
            //    public static T GenerateValid<T>(Func<T> generationFunction, Predicate<T> validationPredicate)
            //    {
            //        T value;
            //        int attempts = 0;

            //        do
            //        {
            //            //Throw exception if we tried to often.
            //            if (attempts > AttemptCount)
            //                throw new TooManyTriesException();

            //            //Generate.
            //            value = generationFunction();

            //            //Update counter.
            //            attempts++;

            //            //Validate.
            //        } while (!validationPredicate(value));

            //        return value;
            //    }

            //    /// <summary>
            //    /// Generates multiple values that satisft the <paramref name="validationPredicate"/>.
            //    /// </summary>
            //    /// <param name="generationFunction">The function that generates values.</param>
            //    /// <param name="validationPredicate">The predicate that validates.</param>
            //    /// <param name="amount">The amount of values to generate.</param>
            //    /// <returns>The generated values.</returns>
            //    public static IEnumerable<T> GenerateValid<T>(Func<T> generationFunction, Predicate<T> validationPredicate,
            //                                                  int amount)
            //    {
            //        Func<T> generator = () => GenerateValid(generationFunction, validationPredicate);
            //        return GenerateRandom(generator, amount);
            //    }

            //    #region Choosing

            //    /// <summary>
            //    /// Chooses a random element.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an element of.</param>
            //    /// <returns>A randomly chosen element.</returns>
            //    public static T ChooseRandom<T>(this IEnumerable<T> enumerable)
            //    {
            //        IEnumerable<T> safeEnumerable = enumerable as T[] ?? enumerable.ToArray();

            //        int index = safeEnumerable.ChooseRandomIndex();
            //        return safeEnumerable.ElementAt(index);
            //    }

            //    /// <summary>
            //    /// Chooses multiple random elements.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an element of.</param>
            //    /// <param name="amount">The amount of elements to choose.</param>
            //    /// <remarks>The same element may be chosen multiple times. If Distinct elements are needed, use <see cref="ChooseRandomDistinct{T}"/>.</remarks>
            //    /// <returns>The randomly chosen elements.</returns>
            //    public static IEnumerable<T> ChooseRandom<T>(this IEnumerable<T> enumerable, int amount)
            //    {
            //        return GenerateRandom(enumerable.ChooseRandom, amount);
            //    }

            //    /// <summary>
            //    /// Randomly chooses multiple distinct elements.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an element of.</param>
            //    /// <param name="amount">The amount of elements to choose.</param>
            //    /// <remarks>If the <paramref name="amount"/> is more than the total amount of elements in <paramref name="enumerable"/>, the <paramref name="enumerable"/> is returned as is.</remarks>
            //    /// <returns>Multiple randomly chosen elements.</returns>
            //    public static IEnumerable<T> ChooseRandomDistinct<T>(this IEnumerable<T> enumerable, int amount)
            //    {
            //        List<T> list = enumerable.ToList();
            //        return list.Count <= amount ? list : list.GrabRandom(amount);
            //    }

            //    /// <summary>
            //    /// Chooses a random element from the <paramref name="enumerable"/> where the weights as determined by the <paramref name="weightFunction"/> bias the selection.
            //    /// </summary> 
            //    public static T ChooseRandomWeighted<T>(this IEnumerable<T> enumerable, Func<T, float> weightFunction)
            //    {
            //        Dictionary<T, float> elementsWithWeights = new Dictionary<T, float>();

            //        foreach (T element in enumerable)
            //        {
            //            float weight = weightFunction(element);
            //            elementsWithWeights[element] = weight;
            //        }

            //        return ChooseRandomWeighted(elementsWithWeights);
            //    }

            //    /// <summary>
            //    /// Chooses a random element in the <paramref name="collectionWithWeights"/>, where the weights are used to bias the selection.
            //    /// </summary> 
            //    public static T ChooseRandomWeighted<T>(this IDictionary<T, float> collectionWithWeights)
            //    {
            //        //Sum the weights.
            //        float weightSum = collectionWithWeights.Values.Sum();

            //        //Generate a value lower than the sum.
            //        float randomValue = Random.RandomRange(weightSum);

            //        foreach (T element in collectionWithWeights.Keys)
            //        {
            //            //Substract weight.
            //            float weight = collectionWithWeights[element];
            //            randomValue -= weight;

            //            //If zero is passed, return element.
            //            if (randomValue <= 0)
            //                return element;
            //        }

            //        //Should not be reachable.
            //        throw new InvalidOperationException();
            //    }

            //    #region Where

            //    /// <summary>
            //    /// Chooses a random element that satisfies the predicate.
            //    /// </summary>
            //    /// <typeparam name="T">The type of elements in the <paramref name="enumerable"/>.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an element of.</param>
            //    /// <param name="predicate">The predicate the randomly chosen element should satisfy.</param>
            //    /// <returns>A randomly chosen element of <paramref name="enumerable"/> that satisfies <paramref name="predicate"/>.</returns>
            //    public static T ChooseRandomWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
            //    {
            //        IEnumerable<T> validElements = enumerable.Where(predicate);
            //        return validElements.ChooseRandom();
            //    }

            //    /// <summary>
            //    /// Randomly chooses multiple elements that satisfy the <paramref name="predicate"/>.
            //    /// </summary>
            //    /// <typeparam name="T">The type of elements in the <paramref name="enumerable"/>.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose elements of.</param>
            //    /// <param name="predicate">The predicate the randomly chosen element should satisfy.</param>
            //    /// <param name="amount">The amount of random elements to select.</param>
            //    /// <returns>Multiple randomly chosen elements of <paramref name="enumerable"/> that satisfy the <paramref name="predicate"/>.</returns>
            //    public static IEnumerable<T> ChooseRandomWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, int amount)
            //    {
            //        IEnumerable<T> validElements = enumerable.Where(predicate);
            //        return validElements.ChooseRandom(amount);
            //    }

            //    /// <summary>
            //    /// Randomly chooses multiple distinct elements that satisfy the <paramref name="predicate"/>.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an element of.</param>
            //    /// <param name="predicate">The predicate that the chosen elements need to satisfy.</param>
            //    /// <param name="amount">The amount of elements to choose.</param>
            //    /// <returns>Multiple randomly chosen elements.</returns>
            //    public static IEnumerable<T> ChooseRandomDistinctWhere<T>(this IEnumerable<T> enumerable,
            //                                                              Func<T, bool> predicate, int amount)
            //    {
            //        IEnumerable<T> validElements = enumerable.Where(predicate);
            //        return validElements.ChooseRandomDistinct(amount);
            //    }

            //    #endregion

            //    #region Preferred

            //    /// <summary>
            //    /// Chooses a random element, where elements that satisfy the <paramref name="predicate"/> are given precedence if they are 
            //    /// present in the <paramref name="enumerable"/>.
            //    /// </summary>
            //    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose elements of.</param>
            //    /// <param name="predicate">The predicate that preferred elements satisfy.</param>
            //    /// <returns>A randomly chosen element if any is present, or a completely randomly chosen element otherwise.</returns>
            //    public static T ChooseRandomPreferred<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
            //    {
            //        //Cast to arrays to avoid multiple enumerations.
            //        IEnumerable<T> asArray = enumerable.ToArray();
            //        IEnumerable<T> preferredElements = asArray.Where(predicate).ToArray();

            //        //Choose a preferred elements if there are any, otherwise any other possible element.
            //        return preferredElements.Any()
            //            ? preferredElements.ChooseRandom()
            //            : asArray.ChooseRandom();
            //    }

            //    /// <summary>
            //    /// Chooses multiple distinct elements, where elements that satisfy the <paramref name="predicate"/> are preferred.
            //    /// </summary>
            //    /// <typeparam name="T">The type of elements in the array.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose elements of.</param>
            //    /// <param name="predicate">The predicate that preferred elements satisfy.</param>
            //    /// <param name="amount">The amount of elements to choose.</param>
            //    /// <returns>Randomly chosen elements if any are present, plus additional completely random chosen element otherwise.</returns>
            //    public static IEnumerable<T> ChooseRandomPreferred<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, int amount)
            //    {
            //        //Select preferred elements.
            //        enumerable = enumerable.ToArray();
            //        IEnumerable<T> preferredSelection = enumerable.ChooseRandomDistinctWhere(predicate, amount).ToArray();

            //        //If we have enough, return selection.
            //        int selectionCount = preferredSelection.Count();
            //        if (selectionCount == amount)
            //            return preferredSelection;

            //        //Select the remaining amount from the rest of the elements.
            //        int amountLeft = amount - selectionCount;
            //        IEnumerable<T> unpreferredSelection = enumerable.ChooseRandomDistinctWhere(x => !predicate(x), amountLeft);

            //        //Concat the two selections.
            //        return preferredSelection.Concat(unpreferredSelection);
            //    }

            //    #endregion

            //    #region Indices

            //    /// <summary>
            //    /// Chooses a random valid index for the <paramref name="enumerable"/>.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose an index for.</param>
            //    /// <returns>A valid index for the enumerable.</returns>
            //    public static int ChooseRandomIndex<T>(this IEnumerable<T> enumerable)
            //    {
            //        int indexMax = enumerable.Count();
            //        return Random.RandomRange(indexMax);
            //    }

            //    /// <summary>
            //    /// Chooses multiple random indices.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose indices for.</param>
            //    /// <param name="amount">The amount of indices to choose.</param>
            //    /// <remarks>The same index may be chosen multiple times. If Distinct indices are needed, use <see cref="ChooseRandomIndicesDistinct{T}"/>.</remarks>
            //    /// <returns>The randomly chosen indices.</returns>
            //    public static IEnumerable<int> ChooseRandomIndices<T>(this IEnumerable<T> enumerable, int amount)
            //    {
            //        int indexMax = enumerable.Count();
            //        Func<int> generationFunction = () => Random.RandomRange(indexMax);

            //        return GenerateRandom(generationFunction, amount);
            //    }

            //    /// <summary>
            //    /// Chooses multiple random distinct indices.
            //    /// </summary>
            //    /// <typeparam name="T">Type of the elements in the enumerable.</typeparam>
            //    /// <param name="enumerable">The enumerable to choose indices for.</param>
            //    /// <param name="amount">The amount of indices to choose.</param>
            //    /// <returns>Multiple random distinct indices.</returns>
            //    public static IEnumerable<int> ChooseRandomIndicesDistinct<T>(this IEnumerable<T> enumerable, int amount)
            //    {
            //        int indexMax = enumerable.Count();
            //        IEnumerable<int> indices = MathHelper.GetRange(0, indexMax);

            //        return indices.ChooseRandomDistinct(amount);
            //    }

            //    #endregion

            //    #endregion

            //    #region Grabbing

            //    /// <summary>
            //    /// Chooses and removes a random element of the <paramref name="list"/>.
            //    /// </summary>
            //    /// <typeparam name="T">Type of elements in the list.</typeparam>
            //    /// <param name="list">The list to choose elements from.</param>
            //    /// <returns>The randomly grabbed element.</returns>
            //    public static T GrabRandom<T>(this IList<T> list)
            //    {
            //        int index = list.ChooseRandomIndex();
            //        T element = list.ElementAt(index);

            //        list.RemoveAt(index);
            //        return element;
            //    }

            //    /// <summary>
            //    /// Randomly chooses and removes multiple elements from the <paramref name="list"/>.
            //    /// </summary>
            //    /// <typeparam name="T">Type of elements in the list.</typeparam>
            //    /// <param name="list">The list to choose elements from.</param>
            //    /// <param name="amount">Amount of elements to grab.</param>
            //    /// <returns>The grabbed elements.</returns>
            //    public static IEnumerable<T> GrabRandom<T>(this IList<T> list, int amount)
            //    {
            //        return GenerateRandom(list.GrabRandom, amount);
            //    }
            //    #endregion

            //    #region MathHelper

            //    #endregion
            //}
        }

}
