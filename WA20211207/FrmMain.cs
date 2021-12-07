using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA20211207
{
    public partial class FrmMain : Form
    {
        public Button[,] Palya { get; set; }
        public int Meret { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            Palya = new Button[10, 10];
            Meret = 50;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int oszlop  = 0; oszlop < Palya.GetLength(0); oszlop++)
            {
                for (int sor = 0; sor < Palya.GetLength(1); sor++)
                {
                    Palya[oszlop, sor] = new Button()
                    {
                        Bounds = new Rectangle()
                        {
                            X = oszlop * Meret,
                            Y = sor * Meret,
                            Height = Meret,
                            Width = Meret,
                        },
                        Text = $"s: {sor}; o:{oszlop}",
                    };
                    Palya[oszlop, sor].MouseDown += FrmMain_MouseDown;
                    Controls.Add(Palya[oszlop, sor]);
                        
                }
            }
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {           
                (sender as Button).BackColor =
                    e.Button == MouseButtons.Left ?
                    Color.Green : Color.Red;
            
            
        }
    }
}
