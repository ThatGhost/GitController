using System;

using LibGit2Sharp;

namespace GitHandler
{

    class Program
    {
        static void Main(string[] args)
        {
            string repoPath = @"C:\Users\starg\source\repos\GitControll"; // Path to your Git repository
            string commitMessage = "I love turtles";

            try
            {
                // Open the repository
                using var repo = new Repository(repoPath);

                // Stage all changes
                Commands.Stage(repo, "*");

                // Check if there are staged changes
                DateTime commitDate = new DateTime(new DateOnly(2006, 1, 2), new TimeOnly(5, 5));
                for (int i = 0; i < 8; i++)
                {
                    var author = new Signature("ThatGhost", "stargamer.me@gmail.com", commitDate);
                    var committer = author; // Same as the author
                    repo.Commit(commitMessage, author, committer, new CommitOptions
                    {
                        AllowEmptyCommit = true
                    });
                }
                Console.WriteLine($"Changes committed successfully! {commitDate}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
