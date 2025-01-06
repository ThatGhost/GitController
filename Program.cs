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
                var author = new Signature("ThatGhost", "stargamer.me@gmail.com", DateTime.Now);
                var committer = author; // Same as the author
                repo.Commit(commitMessage, author, committer, new CommitOptions
                {
                    AllowEmptyCommit = true
                });
                Console.WriteLine("Changes committed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
