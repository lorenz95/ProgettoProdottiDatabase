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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string testoInserito = textBoxUser.Text;
            testoInserito = testoInserito.ToLower();

            if (testoInserito == "pippo")
            {
                MessageBox.Show("Ti sei registrato con successo ");

                List<string> returnStrings = Utility.LoadData();

                //Console.WriteLine("I dati sono ");
                //foreach (var str in returnStrings)
                //{
                //    Console.WriteLine("il dato = " + str);
                //}

                VisualizzaProdotti visualizzaProdotti = new VisualizzaProdotti(returnStrings);
                visualizzaProdotti.Show();
                Hide();
            } else
            {
                MessageBox.Show("Ritenta ");
            }

            MessageBox.Show("Bottone di login cliccato " + Name);
        }
    }
}
