using System;

namespace christmas_tree1
{
	class Christmas_tree
	{
		public static void Main(string[] args)
		{
			string tree_stump = "      *****";
			string line_point = "        *";//This is intended to act a the line base for the tree
			int numTri = 5;
			for (int i = 1; i <= numTri; i++)
			{
				for (int j = 0; j < i; j++)
				{
					string tree_branch = new string('*', j);
					Console.WriteLine(tree_branch.PadLeft(numTri + 3) + "*" + tree_branch);

				}

			}
			Console.WriteLine(line_point+"\n"+line_point+"\n"+line_point);
			//TODO fix the above line of code. It's poor practice for there to be this many duplications of code

			Console.WriteLine(tree_stump);
			Console.WriteLine("Merry Christmas");
		}
	}

}
