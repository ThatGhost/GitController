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
            string branchName = "master"; // Replace with your branch name

            try
            {
                // Open the repository
                using var repo = new Repository(repoPath);

                // Stage all changes
                Commands.Stage(repo, "*");

                // Check if there are staged changes
                var author = new Signature("ThatGhost", "stargamer.me@gmail.com", DateTime.Now);
                var committer = author; // Same as the author
                repo.Commit(commitMessage, author, committer);
                Console.WriteLine("Changes committed successfully!");

                // Pull latest changes
                var remote = repo.Network.Remotes["origin"];
                var pullOptions = new PullOptions
                {
                    FetchOptions = new FetchOptions()
                };

                repo.Network.Push(remote, @"refs/heads/" + branchName, new PushOptions());
                Console.WriteLine("Pushed changes to remote.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
