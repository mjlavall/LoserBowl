using System.Collections.Generic;
using LoserBowl.Models;

namespace LoserBowl.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoserBowlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LoserBowl.Models.LoserBowlContext context)
        {
            //if (System.Diagnostics.Debugger.IsAttached == false) System.Diagnostics.Debugger.Launch();

            context.Teams.AddOrUpdate(
                t => t.Abbreviation,
                new Team {Abbreviation = "PIT", Location = "Pittsburg", Name = "Steelers"},
                new Team {Abbreviation = "NYG", Location = "New York", Name = "Giants"},
                new Team {Abbreviation = "MIN", Location = "Minnesota", Name = "Vikings"},
                new Team {Abbreviation = "ATL", Location = "Atlanta", Name = "Falcons"},
                new Team {Abbreviation = "LA", Location = "Los Angeles", Name = "Rams"},
                new Team {Abbreviation = "DAL", Location = "Dallas", Name = "Cowboys"},
                new Team {Abbreviation = "HOU", Location = "Houston", Name = "Texans"},
                new Team {Abbreviation = "ARI", Location = "Arizona", Name = "Cardinals"},
                new Team {Abbreviation = "NE", Location = "New England", Name = "Patriots"},
                new Team {Abbreviation = "CIN", Location = "Cincinnati", Name = "Bengals"},
                new Team {Abbreviation = "JAX", Location = "Jacksonville", Name = "Jaguars"},
                new Team {Abbreviation = "TB", Location = "Tampa Bay", Name = "Buccaneers"},
                new Team {Abbreviation = "GB", Location = "Green Bay", Name = "Packers"},
                new Team {Abbreviation = "NO", Location = "New Orleans", Name = "Saints"},
                new Team {Abbreviation = "NYJ", Location = "New York", Name = "Jets"},
                new Team {Abbreviation = "SEA", Location = "Seattle", Name = "Seahawks"},
                new Team {Abbreviation = "BUF", Location = "Buffalo", Name = "Bills"},
                new Team {Abbreviation = "CHI", Location = "Chicago", Name = "Bears"},
                new Team {Abbreviation = "KC", Location = "Kansas City", Name = "Chiefs"},
                new Team {Abbreviation = "WSH", Location = "Washington", Name = "Redskins"},
                new Team {Abbreviation = "OAK", Location = "Oakland", Name = "Raiders"},
                new Team {Abbreviation = "DEN", Location = "Denver", Name = "Broncos"},
                new Team {Abbreviation = "SD", Location = "San Diego", Name = "Chargers"},
                new Team {Abbreviation = "CAR", Location = "Carolina", Name = "Panthers"},
                new Team {Abbreviation = "SF", Location = "San Fransisco", Name = "49ers"},
                new Team {Abbreviation = "IND", Location = "Indianapolis", Name = "Colts"},
                new Team {Abbreviation = "MIA", Location = "Miami", Name = "Dolphins"},
                new Team {Abbreviation = "DET", Location = "Detroit", Name = "Lions"},
                new Team {Abbreviation = "PHI", Location = "Philadelphia", Name = "Eagles"},
                new Team {Abbreviation = "TEN", Location = "Tennessee", Name = "Titans"},
                new Team {Abbreviation = "CLE", Location = "Clevland", Name = "Browns"},
                new Team {Abbreviation = "BAL", Location = "Baltimore", Name = "Ravens"});

            context.SaveChanges();
            
            // Week 1
            UpsertGame(1, "Thursday", "CAR", "DEN", context);
            UpsertGame(1, "Sunday", "TB", "ATL", context);
            UpsertGame(1, "Sunday", "MIN", "TEN", context);
            UpsertGame(1, "Sunday", "CLE", "PHI", context);
            UpsertGame(1, "Sunday", "CIN", "NYJ", context);
            UpsertGame(1, "Sunday", "OAK", "NO", context);
            UpsertGame(1, "Sunday", "SD", "KC", context);
            UpsertGame(1, "Sunday", "BUF", "BAL", context);
            UpsertGame(1, "Sunday", "CHI", "HOU", context);
            UpsertGame(1, "Sunday", "GB", "JAX", context);
            UpsertGame(1, "Sunday", "MIA", "SEA", context);
            UpsertGame(1, "Sunday", "NYG", "DAL", context);
            UpsertGame(1, "Sunday", "DET", "IND", context);
            UpsertGame(1, "Sunday", "NE", "ARI", context);
            UpsertGame(1, "Monday", "PIT", "WSH", context);
            UpsertGame(1, "Monday", "LA", "SF", context);
            // Week 2
            UpsertGame(2, "Thursday", "NYJ", "BUF", context);
            UpsertGame(2, "Sunday", "SF", "CAR", context);
            UpsertGame(2, "Sunday", "DAL", "WSH", context);
            UpsertGame(2, "Sunday", "CIN", "PIT", context);
            UpsertGame(2, "Sunday", "NO", "NYG", context);
            UpsertGame(2, "Sunday", "MIA", "NE", context);
            UpsertGame(2, "Sunday", "KC", "HOU", context);
            UpsertGame(2, "Sunday", "TEN", "DET", context);
            UpsertGame(2, "Sunday", "BAL", "CLE", context);
            UpsertGame(2, "Sunday", "SEA", "LA", context);
            UpsertGame(2, "Sunday", "TB", "ARI", context);
            UpsertGame(2, "Sunday", "JAX", "SD", context);
            UpsertGame(2, "Sunday", "ATL", "OAK", context);
            UpsertGame(2, "Sunday", "IND", "DEN", context);
            UpsertGame(2, "Sunday", "GB", "MIN", context);
            UpsertGame(2, "Monday", "PHI", "CHI", context);
            // Week 3
            UpsertGame(3, "Thursday", "HOU", "NE", context);
            UpsertGame(3, "Sunday", "ARI", "BUF", context);
            UpsertGame(3, "Sunday", "OAK", "TEN", context);
            UpsertGame(3, "Sunday", "WSH", "NYG", context);
            UpsertGame(3, "Sunday", "CLE", "MIA", context);
            UpsertGame(3, "Sunday", "BAL", "JAX", context);
            UpsertGame(3, "Sunday", "DET", "GB", context);
            UpsertGame(3, "Sunday", "DEN", "CIN", context);
            UpsertGame(3, "Sunday", "MIN", "CAR", context);
            UpsertGame(3, "Sunday", "LA", "TB", context);
            UpsertGame(3, "Sunday", "SF", "SEA", context);
            UpsertGame(3, "Sunday", "NYJ", "KC", context);
            UpsertGame(3, "Sunday", "SD", "IND", context);
            UpsertGame(3, "Sunday", "PIT", "PHI", context);
            UpsertGame(3, "Sunday", "CHI", "DAL", context);
            UpsertGame(3, "Monday", "ATL", "NO", context);
            // Week 4
            UpsertGame(4, "Thursday", "MIA", "CIN", context);
            UpsertGame(4, "Sunday", "IND", "JAX", context);
            UpsertGame(4, "Sunday", "TEN", "HOU", context);
            UpsertGame(4, "Sunday", "CLE", "WSH", context);
            UpsertGame(4, "Sunday", "SEA", "NYJ", context);
            UpsertGame(4, "Sunday", "BUF", "NE", context);
            UpsertGame(4, "Sunday", "CAR", "ATL", context);
            UpsertGame(4, "Sunday", "OAK", "BAL", context);
            UpsertGame(4, "Sunday", "DET", "CHI", context);
            UpsertGame(4, "Sunday", "DEN", "TB", context);
            UpsertGame(4, "Sunday", "LA", "ARI", context);
            UpsertGame(4, "Sunday", "NO", "SD", context);
            UpsertGame(4, "Sunday", "DAL", "SF", context);
            UpsertGame(4, "Sunday", "KC", "PIT", context);
            UpsertGame(4, "Monday", "NYG", "MIN", context);
            // Week 5
            UpsertGame(5, "Thursday", "ARI", "SF", context);
            UpsertGame(5, "Sunday", "NE", "CLE", context);
            UpsertGame(5, "Sunday", "PHI", "DET", context);
            UpsertGame(5, "Sunday", "CHI", "IND", context);
            UpsertGame(5, "Sunday", "TEN", "MIA", context);
            UpsertGame(5, "Sunday", "WSH", "BAL", context);
            UpsertGame(5, "Sunday", "HOU", "MIN", context);
            UpsertGame(5, "Sunday", "NYJ", "PIT", context);
            UpsertGame(5, "Sunday", "ATL", "DEN", context);
            UpsertGame(5, "Sunday", "CIN", "DAL", context);
            UpsertGame(5, "Sunday", "BUF", "LA", context);
            UpsertGame(5, "Sunday", "SD", "OAK", context);
            UpsertGame(5, "Sunday", "NYG", "GB", context);
            UpsertGame(5, "Monday", "TB", "CAR", context);
            // Week 6
            UpsertGame(6, "Thursday", "DEN", "SD", context);
            UpsertGame(6, "Sunday", "SF", "BUF", context);
            UpsertGame(6, "Sunday", "PHI", "WSH", context);
            UpsertGame(6, "Sunday", "CLE", "TEN", context);
            UpsertGame(6, "Sunday", "BAL", "NYG", context);
            UpsertGame(6, "Sunday", "CAR", "NO", context);
            UpsertGame(6, "Sunday", "JAX", "CHI", context);
            UpsertGame(6, "Sunday", "LA", "DET", context);
            UpsertGame(6, "Sunday", "PIT", "MIA", context);
            UpsertGame(6, "Sunday", "CIN", "NE", context);
            UpsertGame(6, "Sunday", "KC", "OAK", context);
            UpsertGame(6, "Sunday", "ATL", "SEA", context);
            UpsertGame(6, "Sunday", "DAL", "GB", context);
            UpsertGame(6, "Sunday", "IND", "HOU", context);
            UpsertGame(6, "Monday", "NYJ", "ARI", context);
            // Week 7
            UpsertGame(7, "Thursday", "CHI", "GB", context);
            UpsertGame(7, "Sunday", "NYG", "LA", context);
            UpsertGame(7, "Sunday", "NO", "KC", context);
            UpsertGame(7, "Sunday", "IND", "TEN", context);
            UpsertGame(7, "Sunday", "MIN", "PHI", context);
            UpsertGame(7, "Sunday", "CLE", "CIN", context);
            UpsertGame(7, "Sunday", "WSH", "DET", context);
            UpsertGame(7, "Sunday", "OAK", "JAX", context);
            UpsertGame(7, "Sunday", "BUF", "MIA", context);
            UpsertGame(7, "Sunday", "BAL", "NYJ", context);
            UpsertGame(7, "Sunday", "TB", "SF", context);
            UpsertGame(7, "Sunday", "SD", "ATL", context);
            UpsertGame(7, "Sunday", "NE", "PIT", context);
            UpsertGame(7, "Sunday", "SEA", "ARI", context);
            UpsertGame(7, "Monday", "HOU", "DEN", context);
            // Week 8
            UpsertGame(8, "Thursday", "JAX", "TEN", context);
            UpsertGame(8, "Sunday", "WSH", "CIN", context);
            UpsertGame(8, "Sunday", "KC", "IND", context);
            UpsertGame(8, "Sunday", "OAK", "TB", context);
            UpsertGame(8, "Sunday", "SEA", "NO", context);
            UpsertGame(8, "Sunday", "DET", "HOU", context);
            UpsertGame(8, "Sunday", "NYJ", "CLE", context);
            UpsertGame(8, "Sunday", "GB", "ATL", context);
            UpsertGame(8, "Sunday", "NE", "BUF", context);
            UpsertGame(8, "Sunday", "SD", "DEN", context);
            UpsertGame(8, "Sunday", "ARI", "CAR", context);
            UpsertGame(8, "Sunday", "PHI", "DAL", context);
            UpsertGame(8, "Monday", "MIN", "CHI", context);
            // Week 9
            UpsertGame(9, "Thursday", "ATL", "TB", context);
            UpsertGame(9, "Sunday", "DET", "MIN", context);
            UpsertGame(9, "Sunday", "PHI", "NYG", context);
            UpsertGame(9, "Sunday", "NYJ", "MIA", context);
            UpsertGame(9, "Sunday", "JAX", "KC", context);
            UpsertGame(9, "Sunday", "DAL", "CLE", context);
            UpsertGame(9, "Sunday", "PIT", "BAL", context);
            UpsertGame(9, "Sunday", "NO", "SF", context);
            UpsertGame(9, "Sunday", "CAR", "LA", context);
            UpsertGame(9, "Sunday", "IND", "GB", context);
            UpsertGame(9, "Sunday", "TEN", "SD", context);
            UpsertGame(9, "Sunday", "DEN", "OAK", context);
            UpsertGame(9, "Monday", "BUF", "SEA", context);
            // Week 10
            UpsertGame(10, "Thursday", "CLE", "BAL", context);
            UpsertGame(10, "Sunday", "HOU", "JAX", context);
            UpsertGame(10, "Sunday", "DEN", "NO", context);
            UpsertGame(10, "Sunday", "LA", "NYJ", context);
            UpsertGame(10, "Sunday", "ATL", "PHI", context);
            UpsertGame(10, "Sunday", "KC", "CAR", context);
            UpsertGame(10, "Sunday", "CHI", "TB", context);
            UpsertGame(10, "Sunday", "MIN", "WSH", context);
            UpsertGame(10, "Sunday", "GB", "TEN", context);
            UpsertGame(10, "Sunday", "MIA", "SD", context);
            UpsertGame(10, "Sunday", "SF", "ARI", context);
            UpsertGame(10, "Sunday", "DAL", "PIT", context);
            UpsertGame(10, "Sunday", "SEA", "NE", context);
            UpsertGame(10, "Monday", "CIN", "NYG", context);
            // Week 11
            UpsertGame(11, "Thursday", "NO", "CAR", context);
            UpsertGame(11, "Sunday", "PIT", "CLE", context);
            UpsertGame(11, "Sunday", "BAL", "DAL", context);
            UpsertGame(11, "Sunday", "JAX", "DET", context);
            UpsertGame(11, "Sunday", "TEN", "IND", context);
            UpsertGame(11, "Sunday", "BUF", "CIN", context);
            UpsertGame(11, "Sunday", "TB", "KC", context);
            UpsertGame(11, "Sunday", "CHI", "NYG", context);
            UpsertGame(11, "Sunday", "ARI", "MIN", context);
            UpsertGame(11, "Sunday", "MIA", "LA", context);
            UpsertGame(11, "Sunday", "NE", "SF", context);
            UpsertGame(11, "Sunday", "PHI", "SEA", context);
            UpsertGame(11, "Sunday", "GB", "WSH", context);
            UpsertGame(11, "Monday", "HOU", "OAK", context);
            // Week 12
            UpsertGame(12, "Thursday", "MIN", "DET", context);
            UpsertGame(12, "Thursday", "WSH", "DAL", context);
            UpsertGame(12, "Thursday", "PIT", "IND", context);
            UpsertGame(12, "Sunday", "TEN", "CHI", context);
            UpsertGame(12, "Sunday", "JAX", "BUF", context);
            UpsertGame(12, "Sunday", "CIN", "BAL", context);
            UpsertGame(12, "Sunday", "ARI", "ATL", context);
            UpsertGame(12, "Sunday", "NYG", "CLE", context);
            UpsertGame(12, "Sunday", "LA", "NO", context);
            UpsertGame(12, "Sunday", "SF", "MIA", context);
            UpsertGame(12, "Sunday", "SD", "HOU", context);
            UpsertGame(12, "Sunday", "SEA", "TB", context);
            UpsertGame(12, "Sunday", "CAR", "OAK", context);
            UpsertGame(12, "Sunday", "KC", "DEN", context);
            UpsertGame(12, "Sunday", "NE", "NYJ", context);
            UpsertGame(12, "Monday", "GB", "PHI", context);
            // Week 13
            UpsertGame(13, "Thursday", "DAL", "MIN", context);
            UpsertGame(13, "Sunday", "KC", "ATL", context);
            UpsertGame(13, "Sunday", "DET", "NO", context);
            UpsertGame(13, "Sunday", "LA", "NE", context);
            UpsertGame(13, "Sunday", "DEN", "JAX", context);
            UpsertGame(13, "Sunday", "HOU", "GB", context);
            UpsertGame(13, "Sunday", "PHI", "CIN", context);
            UpsertGame(13, "Sunday", "MIA", "BAL", context);
            UpsertGame(13, "Sunday", "SF", "CHI", context);
            UpsertGame(13, "Sunday", "BUF", "OAK", context);
            UpsertGame(13, "Sunday", "NYG", "PIT", context);
            UpsertGame(13, "Sunday", "WSH", "ARI", context);
            UpsertGame(13, "Sunday", "TB", "SD", context);
            UpsertGame(13, "Sunday", "CAR", "SEA", context);
            UpsertGame(13, "Monday", "IND", "NYJ", context);
            // Week 14
            UpsertGame(14, "Thursday", "OAK", "KC", context);
            UpsertGame(14, "Sunday", "PIT", "BUF", context);
            UpsertGame(14, "Sunday", "DEN", "TEN", context);
            UpsertGame(14, "Sunday", "NO", "TB", context);
            UpsertGame(14, "Sunday", "WSH", "PHI", context);
            UpsertGame(14, "Sunday", "ARI", "MIA", context);
            UpsertGame(14, "Sunday", "SD", "CAR", context);
            UpsertGame(14, "Sunday", "CIN", "CLE", context);
            UpsertGame(14, "Sunday", "CHI", "DET", context);
            UpsertGame(14, "Sunday", "HOU", "IND", context);
            UpsertGame(14, "Sunday", "MIN", "JAX", context);
            UpsertGame(14, "Sunday", "NYJ", "SF", context);
            UpsertGame(14, "Sunday", "ATL", "LA", context);
            UpsertGame(14, "Sunday", "SEA", "GB", context);
            UpsertGame(14, "Sunday", "DAL", "NYG", context);
            UpsertGame(14, "Monday", "BAL", "NE", context);
            // Week 15
            UpsertGame(15, "Thursday", "LA", "SEA", context);
            UpsertGame(15, "Saturday", "MIA", "NYJ", context);
            UpsertGame(15, "Sunday", "GB", "CHI", context);
            UpsertGame(15, "Sunday", "TB", "DAL", context);
            UpsertGame(15, "Sunday", "JAX", "HOU", context);
            UpsertGame(15, "Sunday", "CLE", "BUF", context);
            UpsertGame(15, "Sunday", "PHI", "BAL", context);
            UpsertGame(15, "Sunday", "TEN", "KC", context);
            UpsertGame(15, "Sunday", "DET", "NYG", context);
            UpsertGame(15, "Sunday", "IND", "MIN", context);
            UpsertGame(15, "Sunday", "NO", "ARI", context);
            UpsertGame(15, "Sunday", "SF", "ATL", context);
            UpsertGame(15, "Sunday", "NE", "DEN", context);
            UpsertGame(15, "Sunday", "OAK", "SD", context);
            UpsertGame(15, "Sunday", "PIT", "CIN", context);
            UpsertGame(15, "Monday", "CAR", "WSH", context);
            // Week 16
            UpsertGame(16, "Thursday", "NYG", "PHI", context);
            UpsertGame(16, "Saturday", "MIA", "BUF", context);
            UpsertGame(16, "Saturday", "TB", "NO", context);
            UpsertGame(16, "Saturday", "NYJ", "NE", context);
            UpsertGame(16, "Saturday", "TEN", "JAX", context);
            UpsertGame(16, "Saturday", "MIN", "GB", context);
            UpsertGame(16, "Saturday", "SD", "CLE", context);
            UpsertGame(16, "Saturday", "WSH", "CHI", context);
            UpsertGame(16, "Saturday", "ATL", "CAR", context);
            UpsertGame(16, "Saturday", "IND", "OAK", context);
            UpsertGame(16, "Saturday", "ARI", "SEA", context);
            UpsertGame(16, "Saturday", "SF", "LA", context);
            UpsertGame(16, "Saturday", "CIN", "HOU", context);
            UpsertGame(16, "Sunday", "BAL", "PIT", context);
            UpsertGame(16, "Sunday", "DEN", "KC", context);
            UpsertGame(16, "Monday", "DET", "DAL", context);
            // Week 17
            UpsertGame(17, "Sunday", "NO", "ATL", context);
            UpsertGame(17, "Sunday", "BAL", "CIN", context);
            UpsertGame(17, "Sunday", "NYG", "WSH", context);
            UpsertGame(17, "Sunday", "HOU", "TEN", context);
            UpsertGame(17, "Sunday", "CAR", "TB", context);
            UpsertGame(17, "Sunday", "GB", "DET", context);
            UpsertGame(17, "Sunday", "JAX", "IND", context);
            UpsertGame(17, "Sunday", "NE", "MIA", context);
            UpsertGame(17, "Sunday", "CHI", "MIN", context);
            UpsertGame(17, "Sunday", "BUF", "NYJ", context);
            UpsertGame(17, "Sunday", "DAL", "PHI", context);
            UpsertGame(17, "Sunday", "CLE", "PIT", context);
            UpsertGame(17, "Sunday", "ARI", "LA", context);
            UpsertGame(17, "Sunday", "OAK", "DEN", context);
            UpsertGame(17, "Sunday", "KC", "SD", context);
            UpsertGame(17, "Sunday", "SEA", "SF", context);

            context.SaveChanges();

        }

        private static void UpsertGame(int w, string d, string a, string h, LoserBowlContext context)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(h)) return;
            var week = context.Games.Where(g => g.Week == w).ToList();
            var away = context.Teams.Single(t => t.Abbreviation == a);
            var home = context.Teams.Single(t => t.Abbreviation == h);
            var existingGame = week.SingleOrDefault(g => g.Teams.Contains(away) || g.Teams.Contains(home));
            if (existingGame != null) context.Games.Remove(existingGame);
            var game = new Game {Week = w, Day = d, HomeTeamId = home.Id, AwayTeamId = away.Id, Teams = new List<Team>()};
            game.Teams.Add(home);
            game.Teams.Add(away);
            context.Games.Add(game);
        }
    }
}
