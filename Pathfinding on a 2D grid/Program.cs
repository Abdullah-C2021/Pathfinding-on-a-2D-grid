using System;
using System.Collections.Generic;

namespace Pathfinding_on_a_2D_grid
{
    class Program
    {
        // Method to display grid
        static void displayGrid(char[,] pGrid)
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[0, 0], pGrid[0, 1], pGrid[0, 2], pGrid[0, 3], pGrid[0, 4], pGrid[0, 5], pGrid[0, 6], pGrid[0, 7], pGrid[0, 8], pGrid[0, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[1, 0], pGrid[1, 1], pGrid[1, 2], pGrid[1, 3], pGrid[1, 4], pGrid[1, 5], pGrid[1, 6], pGrid[1, 7], pGrid[1, 8], pGrid[1, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[2, 0], pGrid[2, 1], pGrid[2, 2], pGrid[2, 3], pGrid[2, 4], pGrid[2, 5], pGrid[2, 6], pGrid[2, 7], pGrid[2, 8], pGrid[2, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[3, 0], pGrid[3, 1], pGrid[3, 2], pGrid[3, 3], pGrid[3, 4], pGrid[3, 5], pGrid[3, 6], pGrid[3, 7], pGrid[3, 8], pGrid[3, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[4, 0], pGrid[4, 1], pGrid[4, 2], pGrid[4, 3], pGrid[4, 4], pGrid[4, 5], pGrid[4, 6], pGrid[4, 7], pGrid[4, 8], pGrid[4, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[5, 0], pGrid[5, 1], pGrid[5, 2], pGrid[5, 3], pGrid[5, 4], pGrid[5, 5], pGrid[5, 6], pGrid[5, 7], pGrid[5, 8], pGrid[5, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[6, 0], pGrid[6, 1], pGrid[6, 2], pGrid[6, 3], pGrid[6, 4], pGrid[6, 5], pGrid[6, 6], pGrid[6, 7], pGrid[6, 8], pGrid[6, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[7, 0], pGrid[7, 1], pGrid[7, 2], pGrid[7, 3], pGrid[7, 4], pGrid[7, 5], pGrid[7, 6], pGrid[7, 7], pGrid[7, 8], pGrid[7, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[8, 0], pGrid[8, 1], pGrid[8, 2], pGrid[8, 3], pGrid[8, 4], pGrid[8, 5], pGrid[8, 6], pGrid[8, 7], pGrid[8, 8], pGrid[8, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} | {3,1} | {4,1} | {5,1} | {6,1} | {7,1} | {8,1} | {9,1} |", pGrid[9, 0], pGrid[9, 1], pGrid[9, 2], pGrid[9, 3], pGrid[9, 4], pGrid[9, 5], pGrid[9, 6], pGrid[9, 7], pGrid[9, 8], pGrid[9, 9]);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("==================================================");
        }

        // Methods to move vehicle in different directions
        static void moveLeft(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA, pB - 1] = circle;
            grid[pA, pB] = dot;
        }

        static void moveDownLeft(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA + 1, pB - 1] = circle;
            grid[pA, pB] = dot;
        }

        static void moveDown(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA + 1, pB] = circle;
            grid[pA, pB] = dot;
        }

        static void moveDownRight(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA + 1, pB + 1] = circle;
            grid[pA, pB] = dot;
        }

        static void moveRight(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA, pB + 1] = circle;
            grid[pA, pB] = dot;
        }

        static void moveUpRight(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA - 1, pB + 1] = circle;
            grid[pA, pB] = dot;
        }

        static void moveUp(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA - 1, pB] = circle;
            grid[pA, pB] = dot;
        }

        static void moveUpLeft(int pA, int pB, char[,] grid, char circle, char dot)
        {
            grid[pA - 1, pB - 1] = circle;
            grid[pA, pB] = dot;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Amazon Coding Challenge - Pathfinding on a 2D Grid");
            Console.WriteLine("==================================================");

            // Initialise program variables
            char diamond = '\u2666'; // ♦ to symbolise the destination
            char circle = '\u25cb'; // ○ to symbolise the vehicle
            char square = '\u25a0'; // ■ to symbolise the obstacles
            char dot = '\u2022'; // • to symbolise the path taken

            // Change text encoding from ASCII to UTF8, to enable shape symbol display
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Create empty grid
            char[,] grid =
            {
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
            };

            // Place initial objects in grid
            grid[0, 0] = circle;
            grid[9, 9] = diamond;
            grid[7, 9] = square;
            grid[7, 8] = square;
            grid[7, 6] = square;
            grid[8, 6] = square;

            Random Rng = new Random();
            int obstacles = 4;
            bool maxObstacles = false;
            List<String> listObstacles = new List<String>();

            // Place 20 obstacles randomly in grid
            while (maxObstacles == false)
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (grid[i, j] == ' ')
                        {
                            if (Rng.Next(0, 4) == 0)
                            {
                                grid[i, j] = square;
                                string obstaclePos = ("(" + i + ", " + j + ")");
                                // Add new obstacles co-ordinates to list each time obstacle is added
                                listObstacles.Add(obstaclePos);

                                obstacles++;

                                if (obstacles == 24)
                                {
                                    maxObstacles = true;
                                    break;
                                }
                            }
                        }
                    }
                    
                    if (maxObstacles)
                    {
                        break;
                    }
                }
            }

            displayGrid(grid);

            // Vehicle position co-ordinates
            int a = 0;
            int b = 0;
            List<String> listPath = new List<string>();

            int movement = 1;
            bool foundGoal = false;

            // Loop until path to destination is found by vehicle moves along its right side
            while (foundGoal == false)
            {
                // If vehicle moves left or down left, first move to try next is up left
                if (movement == 1) 
                {
                    if (a != 0 && b != 0 && grid[a - 1, b - 1] != square)
                    {
                        moveUpLeft(a, b, grid, circle, dot);
                        a--;
                        b--;
                        movement = 4;
                    }
                    else if (b != 0 && grid[a, b - 1] != square)
                    {
                        moveLeft(a, b, grid, circle, dot);
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && b != 0 && grid[a + 1, b - 1] != square)
                    {
                        moveDownLeft(a, b, grid, circle, dot);
                        a++;
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && grid[a + 1, b] != square)
                    {
                        moveDown(a, b, grid, circle, dot);
                        a++;
                        movement = 2;
                    }
                    else if (a != 9 && b != 9 && grid[a + 1, b + 1] != square)
                    {
                        moveDownRight(a, b, grid, circle, dot);
                        a++;
                        b++;
                        movement = 2;
                    }
                    else if (b != 9 && grid[a, b + 1] != square)
                    {
                        moveRight(a, b, grid, circle, dot);
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && b != 9 && grid[a - 1, b + 1] != square)
                    {
                        moveUpRight(a, b, grid, circle, dot);
                        a--;
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && grid[a - 1, b] != square)
                    {
                        moveUp(a, b, grid, circle, dot);
                        a--;
                        movement = 4;
                    }
                }
                // If vehicle moves down or down right, first move to try next is down left
                else if (movement == 2) 
                {
                    if (a != 9 && b != 0 && grid[a + 1, b - 1] != square)
                    {
                        moveDownLeft(a, b, grid, circle, dot);
                        a++;
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && grid[a + 1, b] != square)
                    {
                        moveDown(a, b, grid, circle, dot);
                        a++;
                        movement = 2;
                    }
                    else if (a != 9 && b != 9 && grid[a + 1, b + 1] != square)
                    {
                        moveDownRight(a, b, grid, circle, dot);
                        a++;
                        b++;
                        movement = 2;
                    }
                    else if (b != 9 && grid[a, b + 1] != square)
                    {
                        moveRight(a, b, grid, circle, dot);
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && b != 9 && grid[a - 1, b + 1] != square)
                    {
                        moveUpRight(a, b, grid, circle, dot);
                        a--;
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && grid[a - 1, b] != square)
                    {
                        moveUp(a, b, grid, circle, dot);
                        a--;
                        movement = 4;
                    }
                    else if (a != 0 && b != 0 && grid[a - 1, b - 1] != square)
                    {
                        moveUpLeft(a, b, grid, circle, dot);
                        a--;
                        b--;
                        movement = 4;
                    }
                    else if (b != 0 && grid[a, b - 1] != square)
                    {
                        moveLeft(a, b, grid, circle, dot);
                        b--;
                        movement = 1;
                    }
                }
                // If vehicle moves right or up right, first move to try next is down right
                else if (movement == 3)
                {
                    if (a != 9 && b != 9 && grid[a + 1, b + 1] != square)
                    {
                        moveDownRight(a, b, grid, circle, dot);
                        a++;
                        b++;
                        movement = 2;
                    }
                    else if (b != 9 && grid[a, b + 1] != square)
                    {
                        moveRight(a, b, grid, circle, dot);
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && b != 9 && grid[a - 1, b + 1] != square)
                    {
                        moveUpRight(a, b, grid, circle, dot);
                        a--;
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && grid[a - 1, b] != square)
                    {
                        moveUp(a, b, grid, circle, dot);
                        a--;
                        movement = 4;
                    }
                    else if (a != 0 && b != 0 && grid[a - 1, b - 1] != square)
                    {
                        moveUpLeft(a, b, grid, circle, dot);
                        a--;
                        b--;
                        movement = 4;
                    }
                    else if (b != 0 && grid[a, b - 1] != square)
                    {
                        moveLeft(a, b, grid, circle, dot);
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && b != 0 && grid[a + 1, b - 1] != square)
                    {
                        moveDownLeft(a, b, grid, circle, dot);
                        a++;
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && grid[a + 1, b] != square)
                    {
                        moveDown(a, b, grid, circle, dot);
                        a++;
                        movement = 2;
                    }
                }
                // If vehicle moves up or up left, first move to try next is up right
                else if (movement == 4)
                {
                    if (a != 0 && b != 9 && grid[a - 1, b + 1] != square)
                    {
                        moveUpRight(a, b, grid, circle, dot);
                        a--;
                        b++;
                        movement = 3;
                    }
                    else if (a != 0 && grid[a - 1, b] != square)
                    {
                        moveUp(a, b, grid, circle, dot);
                        a--;
                        movement = 4;
                    }
                    else if (a != 0 && b != 0 && grid[a - 1, b - 1] != square)
                    {
                        moveUpLeft(a, b, grid, circle, dot);
                        a--;
                        b--;
                        movement = 4;
                    }
                    else if (b != 0 && grid[a, b - 1] != square)
                    {
                        moveLeft(a, b, grid, circle, dot);
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && b != 0 && grid[a + 1, b - 1] != square)
                    {
                        moveDownLeft(a, b, grid, circle, dot);
                        a++;
                        b--;
                        movement = 1;
                    }
                    else if (a != 9 && grid[a + 1, b] != square)
                    {
                        moveDown(a, b, grid, circle, dot);
                        a++;
                        movement = 2;
                    }
                    else if (a != 9 && b != 9 && grid[a + 1, b + 1] != square)
                    {
                        moveDownRight(a, b, grid, circle, dot);
                        a++;
                        b++;
                        movement = 2;
                    }
                    else if (b != 9 && grid[a, b + 1] != square)
                    {
                        moveRight(a, b, grid, circle, dot);
                        b++;
                        movement = 3;
                    }
                }

                // Add new path co-ordinates to list each time vehicle moves
                string newPos = ("(" + a + ", " + b + ")");
                listPath.Add(newPos);

                displayGrid(grid);
                //Thread.Sleep(100);

                if (newPos == "(0, 0)")
                {
                    Console.WriteLine("Unable to reach delivery point");
                    break;
                }

                if (grid[a, b] == grid[9, 9])
                {
                    Console.WriteLine("You have reached your delivery point");
                    foundGoal = true;
                    break;
                }
            }

            // Display obstacle information
            Console.WriteLine("");
            Console.WriteLine("Obstacle positions:");
            foreach (string str in listObstacles)
            {
                Console.Write(str + ", ");
            }
            Console.WriteLine("number of obstacles added = 20");

            // Display path information
            Console.WriteLine("");
            Console.WriteLine("Vehicle path:");
            foreach (string str in listPath)
            {
                Console.Write(str + ", ");
            }
            Console.Write("number of steps = " + listPath.Count);

            Console.ReadKey();
        }
    }
}
