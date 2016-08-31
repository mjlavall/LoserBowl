using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoserBowl.Models;

namespace LoserBowl.Forms
{
    public partial class LoserBowl : Form
    {
        private readonly LoserBowlContext _context = new LoserBowlContext();

        public LoserBowl()
        {
            InitializeComponent();
        }
    }
}
