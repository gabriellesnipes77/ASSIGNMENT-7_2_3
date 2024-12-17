namespace ASSIGNMENT_7_2_3
{
    internal class Program
    {
        public static bool IsAnagram(string s, string t)
        {

            //If Lengths are different, they can't be anagrams
            if (s.Length != t.Length)
            {
                return false;
            }

            //Convert strings to character arrays and sort them
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            //Compare sorted arrays
            return new string(sArray) == new string(tArray);
        }
        static void Main(string[] args)
        {
            //Test cases
            string s1 = "anagram";
            string t1 = "nagaram";
            Console.WriteLine($"Are'{s1}' and '{t1}' anagrams? {IsAnagram(s1, t1)}");

            string s2 = "rat";
            string t2 = "car";
            Console.WriteLine($"Are '{s2}' and '{t2}' anagrams? {IsAnagram(s2, t2)}");
        }
    }
}
