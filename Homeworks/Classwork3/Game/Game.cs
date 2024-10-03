using System;

public class Game
{
    // 0..9
    public int BorderLeftX = 0;
    public int BorderRightX = 9;
    // 0..9
    public int BorderTopY = 0;
    public int BorderBottomY = 9;

    List<Grass> grasses = new();
    List<Rock> rocks = new();
    List<Tree> treeses = new();
    Character player = new(5, 5);
    List<Plate> plates = new();

    List<Cell> cells = new();

    public Game()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                grasses.Add(new Grass(x, y));
            }
        }

        rocks.Add(new Rock(5, 6));
        treeses.Add(new Tree(7, 7));
        plates.Add(new Plate(2, 2));
        plates.Add(new Plate(2, 3));

        cells.AddRange(grasses);
        cells.AddRange(rocks);
        cells.AddRange(treeses);
        cells.Add(player);
        cells.AddRange(plates);
    }

    public void Print()
    {
        var field = new string[10, 10];

        foreach (var grass in grasses)
        {
            field[grass.X, grass.Y] = grass.Value;
        }

        foreach (var rock in rocks)
        {
            field[rock.X, rock.Y] = rock.Value;
        }

        foreach (var tree in treeses)
        {
            field[tree.X, tree.Y] = tree.Value;
        }

        foreach (var plate in plates)
        {
            field[plate.X, plate.Y] = plate.Value;

            if (player.X == plate.X && player.Y == plate.Y)
            {
                field[plate.X, plate.Y] = "Ⓒ";
            }

            foreach (var rock in rocks)
            {
                if (rock.X == plate.X && rock.Y == plate.Y)
                {
                    field[plate.X, plate.Y] = "Ⓡ";
                }
            }
        }

        field[player.X, player.Y] = player.Value;

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Console.Write(field[y, x] + " ");
            }
            Console.WriteLine();
        }

    }

    public bool CanIMoveCharacter(int x, int y)
    {
        int targetX = player.X + x;
        int targetY = player.Y + y;

        bool flag = true;

        foreach (var cell in cells)
        {
            if (cell.X == targetX && cell.Y == targetY)
            {
                if (!cell.IsMovable && !cell.IsCrossable)
                {
                    flag = false;
                }
            }
        }

        return flag;
    }

    public void MoveCharacter(int x, int y)
    {
        player.X += x;
        player.Y += y;
    }

    public void Run()
    {
        while (true)
        {
            Print();
            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (CanIMoveCharacter(-1, 0))
                    {
                        MoveCharacter(-1, 0);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    //if (Swap(playerX, playerY, playerX + 1, playerY))
                    // playerX++;
                    break;
                case ConsoleKey.UpArrow:
                    //if (Swap(playerX, playerY, playerX, playerY - 1))
                    // playerY--;
                    break;
                case ConsoleKey.DownArrow:
                    //if (Swap(playerX, playerY, playerX, playerY + 1))
                    // playerY++;
                    break;
            }

        }
    }
}