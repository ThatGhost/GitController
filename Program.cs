using System;

using LibGit2Sharp;

namespace GitHandler
{

    class Program
    {
        private static string commitMessage = "I love turtles";
        private static int year = 2006;

        static void Main(string[] args)
        {
            string repoPath = @"C:\Users\starg\source\repos\GitControll"; // Path to your Git repository

            try
            {
                // Open the repository
                using var repo = new Repository(repoPath);

                I(repo);
                L1(repo);
                O(repo);
                V(repo);
                E1(repo);
                T1(repo);
                U(repo);
                R(repo);
                T2(repo);
                L2(repo);
                E2(repo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void I(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1);
            for (int i = 0; i < 7; i++)
            {
                commitDate = commitDate.AddDays(1);
                CommitOnDay(commitDate, repo);
            }
            Console.WriteLine($"Made the I!");
        }

        private static void L1(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(2) - 1);
            for (int i = 0; i < 7; i++)
            {
                commitDate = commitDate.AddDays(1);
                CommitOnDay(commitDate, repo);
            }
            commitDate = commitDate.AddDays(7);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(7);
            CommitOnDay(commitDate, repo);

            Console.WriteLine($"Made the L!");
        }

        private static void O(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(6));
            for (int i = 1; i < 6; i++)
            {
                commitDate = commitDate.AddDays(1);
                CommitOnDay(commitDate, repo);
            }
            commitDate = commitDate.AddDays(2);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(6);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(6);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            for (int i = 1; i < 6; i++)
            {
                commitDate = commitDate.AddDays(1);
                CommitOnDay(commitDate, repo);
            }
        }

        private static void V(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(11));
            for (int i = 0; i < 3; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(12) + 3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(13) + 5);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(14) + 3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(15));
            for (int i = 0; i < 3; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
        }

        private static void E1(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(17));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(18));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(19));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
        }

        private static void T1(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(21));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(22));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(23));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(24));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(25));
            CommitOnDay(commitDate, repo);
        }

        private static void U(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(27));
            for (int i = 0; i < 6; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }

            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(28) + 6);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(29) + 6);
            CommitOnDay(commitDate, repo);

            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(30));
            for (int i = 0; i < 6; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
        }

        private static void R(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(32));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }

            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(33));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(34));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(35) + 1);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(2);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(1);
            CommitOnDay(commitDate, repo);
        }

        private static void T2(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(37));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(38));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(39));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(40));
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(41));
            CommitOnDay(commitDate, repo);
        }

        private static void L2(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(43));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(44) + 6);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(45) + 6);
            CommitOnDay(commitDate, repo);

            Console.WriteLine($"Made the L!");
        }

        private static void E2(Repository repo)
        {
            DateTime commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(47));
            for (int i = 0; i < 7; i++)
            {
                CommitOnDay(commitDate, repo);
                commitDate = commitDate.AddDays(1);
            }
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(48));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = GetFirstSunday(year, 1).AddDays(WeeksToDays(49));
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
            commitDate = commitDate.AddDays(3);
            CommitOnDay(commitDate, repo);
        }

        private static int WeeksToDays(int weeks)
        {
            return weeks * 7;
        }

        private static void CommitOnDay(DateTime dateTime, Repository repo)
        {
            for (int j = 0; j < 8; j++)
            {
                var author = new Signature("ThatGhost", "stargamer.me@gmail.com", dateTime);
                var committer = author; // Same as the author
                repo.Commit(commitMessage, author, committer, new CommitOptions
                {
                    AllowEmptyCommit = true
                });
            }
        }

        public static DateTime GetFirstSunday(int year, int month)
        {
            DateTime firstDay = new DateTime(year, month, 1);

            // Calculate the first Sunday
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)firstDay.DayOfWeek + 7) % 7;
            DateTime firstSunday = firstDay.AddDays(daysUntilSunday);

            if (firstSunday.Year != year) throw new Exception("Out of space");

            return firstSunday.AddHours(13);
        }
    }
}
