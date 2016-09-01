using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoserBowl.Migrations;
using LoserBowl.Models;

namespace LoserBowl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LoserBowlContext, Configuration>());
            using (var context = new LoserBowlContext())
            {
                context.Database.Initialize(true);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.LoserBowl());
        }
    }
}
