using System;

public class Program
{
	public static void Main()
	{
		Select();
	}

	static void Select() //Game Select Code
	{
		LOGO();
		Console.WriteLine();
		string gameselect; // game select string
		Console.WriteLine("Would you like to play Scissors Paper Rock (Input r) or Tic Tac Toe (Input t)?");
		gameselect = Console.ReadLine();
		if (gameselect.ToLower() == "r") // if input is r, starts rock paper scissors
		{
			Console.Clear();
			Console.WriteLine("You are now playing Scissors Paper Rock against a Computer");
			Console.WriteLine("What object would you like to play, Rock (r), Paper (p) or Scissors (s)");
			//string line;
			//line = "What object would you like to play, Rock (r), Paper (p) or Scissors (s)";
			//for (int i = 0; i < line.Length; i++)
			//{
			//	Console.Write(line[i]);
			//	System.Threading.Thread.Sleep(60); // Sleep for 150 milliseconds
			//}
			RPS();

		}
		else if (gameselect.ToLower() == "t") // if input is t, starts tic tac toe
		{
			Console.WriteLine("You are now playing Tic Tac Toe");
			TTT();
		}
		else // If input is not r or t
		{
			Console.Clear();
			Console.WriteLine("Error: Unknown Input, Please Enter Again");
			Select(); // Goes back to game select upon error
		}
	}

	static void RPS() // Rock Paper Scissors Code
	{
		string rpschoice;

		Console.WriteLine();
		rpschoice = Console.ReadLine();
		Random rand = new Random();
		int CPUChoice = rand.Next(0, 3);
		int winner;
		if (rpschoice.ToLower() == "r")
		{
			int playernum = 0;
			winner = (3 + playernum - CPUChoice % 3);
			if (winner == 0)
			{
				Console.WriteLine("The game has ended in a draw");
			}
			else if (winner == 1)
			{
				Console.WriteLine("You have won the game!");
			}
			else if (winner == 2)
			{
				Console.WriteLine("You have lost the game");
			}
			else
			{
				Console.WriteLine("Error please try again");
			}
		}
		else if (rpschoice.ToLower() == "p")
		{
			int playernum = 1;
			winner = (3 + playernum - CPUChoice) % 3;
			if (winner == 0)
			{
				Console.WriteLine("The game has ended in a draw");
			}
			else if (winner == 1)
			{
				Console.WriteLine("You have won the game!");
			}
			else if (winner == 2)
			{
				Console.WriteLine("You have lost the game");
			}
			else
			{
				Console.WriteLine("Error please try again");
			}
		}
		else if (rpschoice.ToLower() == "s")
		{
			int playernum = 2;
			winner = (3 + playernum - CPUChoice) % 3;
			if (winner == 0)
			{
				Console.WriteLine("The game has ended in a draw");
			}
			else if (winner == 1)
			{
				Console.WriteLine("You have won the game!");
			}
			else if (winner == 2)
			{
				Console.WriteLine("You have lost the game");
			}
			else
			{
				Console.WriteLine("Error please try again");
			}

		}
		else
		{
			Console.WriteLine("Error: Unknown Input please try again");
			RPS();
		}
		if (CPUChoice == 0)
		{
			Console.WriteLine("The CPU has chosen Rock");
		}
		else if (CPUChoice == 2)
		{
			Console.WriteLine("The CPU has chosen Scissors");
		}
		else if (CPUChoice == 1)
		{
			Console.WriteLine("The CPU has chosen Paper");
		}
		System.Threading.Thread.Sleep(300);
		WINRPS();

	}
	static void WINRPS()
	{
		string again;
		Console.WriteLine("What would you like to do? Have a rematch (R) Select a new game (S) or quit (Q)");
		again = Console.ReadLine();
		if (again.ToLower() == "r")
		{
			Console.Clear();
			Console.WriteLine("Restarting..");
			Console.WriteLine("What object would you like to play, Rock (r), Paper (p) or Scissors (s)");
			RPS();
		}
		else if (again.ToLower() == "s")
		{
			Console.Clear();
			Select();
		}
		else if (again.ToLower() == "q")
		{
			Console.WriteLine("Stopping in 3");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("Stopping in 2");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("Stopping in 1");
			System.Threading.Thread.Sleep(1000);
			Environment.Exit(0);
		}
		else 
		{
			Console.WriteLine("Invalid input please try again");
			WINRPS();
		}
	}
	
	//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
	//----------------------------------------------------------------------------------------------------------------------------------------------------------------------


	public static void TTT() // Tic Tac Toe Code
	{
		//grid string
		string[] grid = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
		//player turns loop
		bool end = false;
		Console.WriteLine("You are now playing Tic Tac Toe against another person");
		while (end == false)
		{
			//player 1 turn
			if (end == false)
			{
				Console.Clear();
				P1TURN(grid, end);
			}
			//checkwin
			if ((grid[0] == grid[4] && grid[4] == grid[8] && grid[0] == "X") || //left to right diagonal
				(grid[2] == grid[4] && grid[4] == grid[6] && grid[2] == "X") || //right to left diagonal
				(grid[0] == grid[3] && grid[3] == grid[6] && grid[0] == "X") || //first column
				(grid[1] == grid[4] && grid[4] == grid[7] && grid[1] == "X") || //second column
				(grid[2] == grid[5] && grid[5] == grid[8] && grid[2] == "X") || //third column
				(grid[0] == grid[1] && grid[1] == grid[2] && grid[0] == "X") || //first row
				(grid[3] == grid[4] && grid[4] == grid[5] && grid[3] == "X") || //second row
				(grid[6] == grid[7] && grid[7] == grid[8] && grid[6] == "X"))   // third row
			   
			{
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("Player 1 Wins!");
				end = true;
			}
			if ((grid[0] == grid[4] && grid[4] == grid[8] && grid[0] == "O") || //left to right diagonal
				(grid[2] == grid[4] && grid[4] == grid[6] && grid[2] == "O") || //right to left diagonal
				(grid[0] == grid[3] && grid[3] == grid[6] && grid[0] == "O") || //first column
				(grid[1] == grid[4] && grid[4] == grid[7] && grid[1] == "O") || //second column
				(grid[2] == grid[5] && grid[5] == grid[8] && grid[2] == "O") || //third column
				(grid[0] == grid[1] && grid[1] == grid[2] && grid[0] == "O") || //first row
				(grid[3] == grid[4] && grid[4] == grid[5] && grid[3] == "O") || //second row
				(grid[6] == grid[7] && grid[7] == grid[8] && grid[6] == "O"))   // third row
			   
			{	
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("Player 2 Wins!");
				end = true;
			}
			else if (grid[0] != "1" && //checks box 1
					 grid[1] != "2" && //checks box 2
					 grid[2] != "3" && //checks box 3
					 grid[3] != "4" && //checks box 4
					 grid[4] != "5" && //checks box 5
					 grid[5] != "6" && //checks box 6
					 grid[6] != "7" && //checks box 7
					 grid[7] != "8" && //checks box 8
					 grid[8] != "9")   //checks box 9
			{
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("The game has ended in a draw");
				end = true;
			}
			if (end == false)
			{
				Console.Clear();
				P2TURN(grid, end);
			} 
			// check win
			if ((grid[0] == grid[4] && grid[4] == grid[8] && grid[0] == "O") || //left to right diagonal
				(grid[2] == grid[4] && grid[4] == grid[6] && grid[2] == "O") || //right to left diagonal
				(grid[0] == grid[3] && grid[3] == grid[6] && grid[0] == "O") || //first column
				(grid[1] == grid[4] && grid[4] == grid[7] && grid[1] == "O") || //second column
				(grid[2] == grid[5] && grid[5] == grid[8] && grid[2] == "O") || //third column
				(grid[0] == grid[1] && grid[1] == grid[2] && grid[0] == "O") || //first row
				(grid[3] == grid[4] && grid[4] == grid[5] && grid[3] == "O") || //second row
				(grid[6] == grid[7] && grid[7] == grid[8] && grid[6] == "O"))   // third row
			   
			{	
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("Player 2 Wins!");
				end = true;
			}
			else if ((grid[0] == grid[4] && grid[4] == grid[8] && grid[0] == "X") || //left to right diagonal
				(grid[2] == grid[4] && grid[4] == grid[6] && grid[2] == "X") || //right to left diagonal
				(grid[0] == grid[3] && grid[3] == grid[6] && grid[0] == "X") || //first column
				(grid[1] == grid[4] && grid[4] == grid[7] && grid[1] == "X") || //second column
				(grid[2] == grid[5] && grid[5] == grid[8] && grid[2] == "X") || //third column
				(grid[0] == grid[1] && grid[1] == grid[2] && grid[0] == "X") || //first row
				(grid[3] == grid[4] && grid[4] == grid[5] && grid[3] == "X") || //second row
				(grid[6] == grid[7] && grid[7] == grid[8] && grid[6] == "X"))   // third row
			   
			{
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("Player 1 Wins!");
				end = true;
			}
			else if (grid[0] != "1" && //checks box 1
					 grid[1] != "2" && //checks box 2
					 grid[2] != "3" && //checks box 3
					 grid[3] != "4" && //checks box 4
					 grid[4] != "5" && //checks box 5
					 grid[5] != "6" && //checks box 6
					 grid[6] != "7" && //checks box 7
					 grid[7] != "8" && //checks box 8
					 grid[8] != "9")   //checks box 9
			{
				Console.Clear();
				DRAWGRID(grid);
				Console.WriteLine("The game has ended in a draw");
				end = true;
			}
		}
		WINTTT();
	}
	static void WINTTT()
	{
		string again;
		Console.WriteLine("What would you like to do? Have a rematch (R) Select a new game (S) or quit (Q)");
		again = Console.ReadLine();
		if (again.ToLower() == "r")
		{
			Console.Clear();
			Console.WriteLine("Restarting..");
			TTT();
		}
		else if (again.ToLower() == "s")
		{
			Console.Clear();
			Select();
		}
		else if (again.ToLower() == "q")
		{
			Console.WriteLine("Stopping in 3");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("Stopping in 2");
			System.Threading.Thread.Sleep(1000);
			Console.WriteLine("Stopping in 1");
			System.Threading.Thread.Sleep(1000);
			Environment.Exit(0);
		}
		else 
		{
			Console.WriteLine("Invalid input please try again");
			WINTTT();
		}
	}
	
	
	
	// Player One Turn Code
	
	public static void P1TURN(string[] grid, bool end)
	{
		DRAWGRID(grid);
		Console.WriteLine("Player 1 turn, please select which box you would like to place in (1 to 9)");
		string turn1;
		turn1 = Console.ReadLine();
		try
		{
			int result = Int32.Parse(turn1);
			if (0 <= -1 + result && -1 + result <= 8 && grid[-1 + result] != "X" && grid[-1 + result] != "O")
			{
				grid[-1 + result] = "X";
			}
			else if (0 <= -1 + result && -1 + result <= 8)
			{
				if (grid[-1 + result] == "X" || grid[-1 + result] == "O")
				{
					Console.Clear();
					Console.WriteLine("Box is already occupied, try again");
					//try again
					P1TURN(grid, end);
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid box, try again");
				//try again
				P1TURN(grid, end);
			}
		}
		catch (FormatException)
		{
			Console.Clear();
			Console.WriteLine("Invalid box, try again");
			//try again
			P1TURN(grid, end);
		}
	}
	
	// Player Two Turn Code
	
	public static void P2TURN(string[] grid, bool end)
	{
		DRAWGRID(grid);
		Console.WriteLine("Player 2 turn, please select which box you would like to place in (1 to 9)");
		string turn2;
		turn2 = Console.ReadLine();
		try
		{
			int result = Int32.Parse(turn2);
			if (0 <= -1 + result && -1 + result <= 8 && grid[-1 + result] != "X" && grid[-1 + result] != "O")
			{
				grid[-1 + result] = "O";
			}
			else if (0 <= -1 + result && -1 + result <= 8)
			{
				if (grid[-1 + result] == "X" || grid[-1 + result] == "O")
				{
					Console.Clear();
					Console.WriteLine("Box is already occupied, try again");
					P2TURN(grid, end);
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid box, try again");
				P2TURN(grid, end);
			}
		}
		catch (FormatException)
		{
			Console.Clear();
			Console.WriteLine("Invalid box, try again");
			P2TURN(grid, end);
		}
		//check if win
		//if (grid[0] == grid[4] && grid[4] == grid [8])
		//{
		//	Console.WriteLine("Player two has won the game!");
		//	end = true;
		//}

	}
	public static void CHECKWIN(bool end, string[] grid)
	{
		Console.WriteLine("Half Half Workds");
		if (grid[0] == grid[4] && grid[4] == grid [8])
		{
			Console.WriteLine("Code Half Works");	
			end = true;
		}
	}
	
	//Draws Tic Tac Toe Grid
	static void DRAWGRID(string[] grid)
	{
		Console.WriteLine("     |     |     ");
		Console.WriteLine("  " + grid[0] + "  |  " + grid[1] + "  |  " + grid[2] + "  ");
		Console.WriteLine("_____|_____|_____");
		Console.WriteLine("     |     |     ");
		Console.WriteLine("  " + grid[3] + "  |  " + grid[4] + "  |  " + grid[5] + "  ");
		Console.WriteLine("_____|_____|_____");
		Console.WriteLine("     |     |     ");
		Console.WriteLine("  " + grid[6] + "  |  " + grid[7] + "  |  " + grid[8] + "  ");
		Console.WriteLine("     |     |     ");
	}
	
	//Draws Logo
	static void LOGO()
	{
		Console.WriteLine("       +####        .############     .###########.      #####        ############     ############ ");
		Console.WriteLine("      ### +##       .##        ###   ###.               ### ###       ##+       ###.   ##-          ");
		Console.WriteLine("     -##.  ###      .##        ###  ###                ###   ###      ##+        ###   ##-          ");
		Console.WriteLine("    +##.    ###     .############-  ###               ###     ###     ##+         ##.  ############ ");
		Console.WriteLine("   .###      ###    .#########-     ###              +##+     .###    ##+        ###   ##-          ");
		Console.WriteLine("  .##############   .##     ###+     ###.           ###############   ##+       ###    ##-          ");
		Console.WriteLine("  ###          ###  .##       ###.    .########### -##-         .##-  ###########+     ############ ");
	}
}
