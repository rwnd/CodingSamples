using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Combinatorics
    {
        /// <summary>
        /// Outputs all permutations of an array
        /// Uses a HashSet to track the elements visited at each iteration
        /// </summary>
        private HashSet<int> m_visited = new HashSet<int>();
        internal void PermutationsUsingHashset(int[] array, StringBuilder currentPermutation)
        {
            if (currentPermutation != null && array != null && currentPermutation.Length == array.Length)
            {
                Console.WriteLine(currentPermutation.ToString());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(m_visited.Contains(array[i]))
                {
                    continue;
                }

                // Mark this element as visited and add to the currentPermutation
                m_visited.Add(array[i]);
                currentPermutation.Append(array[i]);

                PermutationsUsingHashset(array, currentPermutation);

                // Remove the element from visited list and from the currentPermutation
                m_visited.Remove(array[i]);
                currentPermutation.Remove(currentPermutation.Length - 1, 1);
            }
        }

        /// <summary>
        /// Outputs all combinations of an array
        /// </summary>
        internal void Combinations(int[] array, int startIndex, StringBuilder currentCombination)
        {
            for (int i = startIndex; i < array.Length; i++)
            {
                currentCombination.Append(array[i]);
                Console.WriteLine(currentCombination.ToString());

                Combinations(array, i+1, currentCombination);

                currentCombination.Remove(currentCombination.Length - 1, 1);
            }
        }

        internal void SwapElements(int[] array, int i, int startIndex)
        {
            if (i == startIndex || i<0 || startIndex < 0 || i>=array.Length || startIndex >= array.Length)
            {
                return;
            }

            array[i] = array[i] ^ array[startIndex];
            array[startIndex] = array[i] ^ array[startIndex];
            array[i] = array[i] ^ array[startIndex];
        }

        internal void Permute(int[] array)
        {
            Console.WriteLine("Permutations of the array:");
            PermutationsUsingHashset(array, new StringBuilder());
        }
        internal void Combine(int[] array)
        {
            Console.WriteLine("Combinations of the array:");
            Combinations(array, 0, new StringBuilder());
        }
    }
}
