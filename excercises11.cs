// See https://aka.ms/new-console-template for more information

//Console.WriteLine(IsStrongPassword("1Birgul*demir"));

int[,] sudoku =
{
    {5,3,4,6,7,8,9,2,2 },
    {6,7,2,1,9,5,3,4,8 },
    {1,9,8,3,4,2,5,6,7 },
    {8,5,9,7,6,1,4,2,3 },
    {4,2,6,8,5,3,7,9,1 },
    {7,1,3,9,2,4,8,5,6 },
    {9,6,1,5,3,7,2,8,4 },
    {2,8,7,4,1,9,6,3,5 },
    {3,4,5,2,8,6,1,7,9 }
};

Console.WriteLine(IsValidSubgrid(sudoku, 0, 0) ? "Valid subgrids" : "Invalid subgrids");


static bool IsValidSubgrid(int[,] board, int startRow, int startCol)
{
    int[] seen = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            int num = board[startRow + i, startCol + j];

            if (seen[num - 1]==0)
            {
                seen[num - 1] = 1;
            }
            else
                return false;
        }
    }
    return true;
}

/*static bool IsStrongPassword(string password)
{
    if (password.Length < 8)
        return false;

    bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial=false;
    string specialChars = "!@#^&%*";

    foreach (char ch in password)
    {
        if (char.IsUpper(ch))
        {
            hasUpper = true;
        }
        if (char.IsLower(ch))
        {
            hasLower = true;
        }
        if (char.IsDigit(ch))
        {
            hasDigit = true;
        }
        if (specialChars.Contains(ch))
        {
            hasSpecial = true;
        }
    }
    return hasUpper && hasSpecial && hasLower && hasDigit;
}*/
