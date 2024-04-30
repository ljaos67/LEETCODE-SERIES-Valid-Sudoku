public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; ++i) {
            for (int j = 0; j < 9; ++j) {
                char number = board[i][j];
                if (number != '.') {
                    string inRow = number + " in row " + i;
                    string inCol = number + " in column " + j;
                    string inBlock = number + " in block " + i / 3 + "-" + j / 3;

                    if (!seen.Add(inRow) || !seen.Add(inCol) || !seen.Add(inBlock))
                        return false;
                }
            }
        }
        return true;    
    }
}
