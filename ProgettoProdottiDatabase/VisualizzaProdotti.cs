using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoProdottiDatabase
{
    public partial class VisualizzaProdotti : Form
    {
        public List<string> ReturnStrings { get; }
        public VisualizzaProdotti(List<string> returnStrings)
        {
            InitializeComponent();
            ReturnStrings = returnStrings;
        }

        public VisualizzaProdotti()
        {
        }

        private void VisualizzaProdotti_Load(object sender, EventArgs e)
        {
            foreach (var item in ReturnStrings)
            {
                ListView.Items.Add(item);
            }
        }
    }
}
