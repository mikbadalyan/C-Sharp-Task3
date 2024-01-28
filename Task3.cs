//Task 2

using System;
using System.Linq;
Queen queen1 = new Queen();
Queen queen2 = new Queen();

int rows = 8;
int columns = 8;
int[,] chess_board = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        chess_board[i, j] = 0;
    }
}


for (int i = 0; i < 30; i++)
{
    Random random1 = new Random();
    queen1.queen_row = random1.Next(0, 7);
    queen1.queen_column = random1.Next(0, 7);
    if (chess_board[queen1.queen_row, queen1.queen_column] == 0)
    {
        
        queen1.queen_strokes(chess_board, queen1.queen_row, queen1.queen_column);
 
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (chess_board[i, j] == 0)
        {
            queen1.queen_row = i;
            queen1.queen_column = j;
            queen1.queen_strokes(chess_board, queen1.queen_row, queen1.queen_column);
            
        }
    }
}
queen1.visual(rows, columns, chess_board);

class Queen
{
    public int queen_row;
    public int queen_column;

    public Queen()
    {
        Console.WriteLine();
    }
    
    public void queen_strokes(int[,] chess_board, int queen_row, int queen_column)
    {
        for (int i = -7; i <= 7; i++)
        {
            if (queen_row + i >= 0 && queen_row + i <= 7)
            {
                chess_board[queen_row + i, queen_column] = 1;
            }
            if (queen_column + i >= 0 && queen_column + i <= 7)
            {
                chess_board[queen_row, queen_column + i] = 1;
            }
        }

        int mm = queen_row;
        int kk = queen_column;

        while (mm + 1 >= 0 && mm + 1 <= 7 && kk + 1 >= 0 && kk + 1 <= 7)
        {
            chess_board[mm + 1, kk + 1] = 1;
            mm = mm + 1;
            kk = kk + 1;
        }
        mm = queen_row;
        kk = queen_column;

        while (mm - 1 >= 0 && mm - 1 <= 7 && kk - 1 >= 0 && kk - 1 <= 7)
        {
            chess_board[mm - 1, kk - 1] = 1;
    
            mm = mm - 1;
            kk = kk - 1;
        }
        mm = queen_row;
        kk = queen_column;

        while (mm + 1 >= 0 && mm + 1 <= 7 && kk - 1 >= 0 && kk - 1 <= 7)
        {
            chess_board[mm + 1, kk - 1] = 1;
            mm = mm + 1;
            kk = kk - 1;
        }
        mm = queen_row;
        kk = queen_column;

        while (mm - 1 >= 0 && mm - 1 <= 7 && kk + 1 >= 0 && kk + 1 <= 7)
        {
            chess_board[mm - 1, kk + 1] = 1;
    
            mm = mm - 1;
            kk = kk + 1;
        }
        chess_board[queen_row, queen_column] = 9;
    }

    public void visual(int rows, int columns, int[,] chess_board)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(chess_board[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

}







/*

 

//

//Placing the knight in a random location.


//

// Algorithm to show the knight strokes on the chess board.


//

//Visualizing the chess board in the console.

*/
