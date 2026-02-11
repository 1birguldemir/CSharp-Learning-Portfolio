// See https://aka.ms/new-console-template for more information
string text1 = "10010101101001100101111010";
string pattern1 = "001011";

int result1 = BruteForceSearch(text1, pattern1);
Console.WriteLine($"Pattern '{pattern1}' fount at index: {result1}");

string text2 = "It is never too late to have a happy childhood.";
string pattern2 = "happy";

int result2 =BruteForceSearch(text2, pattern2);
Console.WriteLine($"Pattern '{pattern2}' fount at index: {result2}");



//class BruteForceSearch
//{
static int BruteForceSearch(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;

        for (int i = 0; i < n - m; i++)
        {
        int j;
            for (j = 0; j < m; j++)
            {
                if(text[i + j] != pattern[j])
                break;

                
            }
        if (j == m)
        {
            return i;
        }

    }
        return -1;
    }
//}