using System;

using LibGit2Sharp;

namespace GitHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            string repoPath = @"C:\path\to\your\repo"; // Path to your Git repository
            string commitMessage = "Your commit message";
            string branchName = "main"; // Replace with your branch name

            try
            {
                // Open the repository
                using var repo = new Repository(repoPath);

                // Stage all changes
                Commands.Stage(repo, "*");

                // Check if there are staged changes
                if (repo.RetrieveStatus().IsDirty)
                {
                    // Commit the changes
                    var author = new Signature("Your Name", "your.email@example.com", DateTime.Now);
                    var committer = author; // Same as the author
                    repo.Commit(commitMessage, author, committer);
                    Console.WriteLine("Changes committed successfully!");
                }
                else
                {
                    Console.WriteLine("No changes to commit.");
                }

                // Pull latest changes
                var remote = repo.Network.Remotes["origin"];
                var pullOptions = new PullOptions
                {
                    FetchOptions = new FetchOptions()
                };

                Commands.Pull(repo, new Signature("Your Name", "your.email@example.com", DateTimeOffset.Now), pullOptions);
                Console.WriteLine("Pulled latest changes from remote.");

                // Push changes to remote
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
