using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionaryAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string perfectGeneration = TbPerfectGeneration.Text;
            if (perfectGeneration.Length > 0)
            {
                this.DGVGeneration.Rows.Clear();
                this.DGVGeneration.Visible = true;
                EvolutionaryAlgorithm evolutionaryAlgorithm = new EvolutionaryAlgorithm();
                List<Loop> loops = evolutionaryAlgorithm.InitAlgorithm(perfectGeneration);

                for (int pos=0; pos<loops.Count(); pos++)
                {
                    int r = DGVGeneration.Rows.Add();
                    DGVGeneration.Rows[r].Cells["ClGeneration"].Value = loops[pos].Generation;
                    DGVGeneration.Rows[r].Cells["ClMutation"].Value = loops[pos].Sentence;
                    DGVGeneration.Rows[r].Cells["ClScore"].Value = loops[pos].Value;
                }                              

            }
        }
    }
}
