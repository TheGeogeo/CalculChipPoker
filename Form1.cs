using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTotalJeton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public decimal CalculFinalEstimat()
        {
            decimal result = 0;

            result = startStackNum.Value * totalPlayerNum.Value;
            if (bountyPerPlayerNum.Value == 0)
            {
                currentJetonLabel.Text = result.ToString("N0");
                return result;
            }

            result += (bountyPerPlayerNum.Value * totalPlayerNum.Value - bountyInGameNum.Value) * valueBountyNum.Value;

            currentJetonLabel.Text = result.ToString("N0");

            return result;
        }

        public decimal CalculFinal()
        {
            decimal result = 0;
            long bountyInGame = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string jeton = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string bounty = dataGridView1.Rows[i].Cells[2].Value.ToString();
                result += long.Parse(Regex.Replace(jeton, @"\s+", ""));
                bountyInGame += long.Parse(Regex.Replace(bounty, @"\s+", ""));
            }

            jetonListLabel.Text = result.ToString("N0");
            bountyListLabel.Text = bountyInGame.ToString("N0");

            return result;
        }

        //Permet de calculer la différence selon les jetons normalement en jeton et les réel jetons en jeu
        public void CalculeDiff(decimal chipPlayer, decimal chipLogic)
        {
            decimal diff = chipPlayer - chipLogic;
            decimal pourcent = chipLogic - chipPlayer;

            if (chipLogic != 0)
            {
                pourcent = chipPlayer - chipLogic;
                pourcent = pourcent / chipLogic;
                pourcent = pourcent * 100;
            }

            if (Math.Abs(pourcent) <= (decimal)2)
            {
                if (diff >= 0)
                    calculJetonLabel.Text = "+" + diff.ToString("N0");
                else
                    calculJetonLabel.Text = diff.ToString("N0");

                calculJetonLabel.ForeColor = Color.ForestGreen;
                pourcentLabel.ForeColor = Color.ForestGreen;
                if (chipLogic != 0)
                {
                    if (diff >= 0)
                        pourcentLabel.Text = "+" + pourcent.ToString("N2") + "%";
                    else
                        pourcentLabel.Text = pourcent.ToString("N2") + "%";
                }
                else pourcentLabel.Text = "...";
            }
            else
            {
                if (diff >= 0)
                    calculJetonLabel.Text = "+" + diff.ToString("N0");
                else
                    calculJetonLabel.Text = diff.ToString("N0");

                calculJetonLabel.ForeColor = Color.DarkRed;
                pourcentLabel.ForeColor = Color.DarkRed;
                if (chipLogic != 0)
                {
                    if (diff >= 0)
                        pourcentLabel.Text = "+" + pourcent.ToString("N2") + "%";
                    else
                        pourcentLabel.Text = pourcent.ToString("N2") + "%";
                }
                else pourcentLabel.Text = "...";
            }
        }

        public void CalculFinalTotal()
        {
            decimal result = 0;

            result = startStackNum.Value * totalPlayerNum.Value;
            if (bountyPerPlayerNum.Value == 0) totalJetonLabel.Text = result.ToString("N0");

            result += bountyPerPlayerNum.Value * totalPlayerNum.Value * valueBountyNum.Value;

            totalJetonLabel.Text = result.ToString("N0");
        }

        public void WrapperCalcul()
        {
            CalculFinalTotal();
            CalculeDiff(CalculFinal(), CalculFinalEstimat());
        }

        public void AddRowManuel()
        {
            if (pseudoAddTB.Text == "") return;
            string[] row = new string[] { pseudoAddTB.Text, jetonAddNum.Value.ToString("N0"), bountyAddNum.Value.ToString("N0") };
            dataGridView1.Rows.Add(row);
            pseudoAddTB.Text = "";
            jetonAddNum.Value = 0;
            bountyAddNum.Value = 0;

            pseudoAddTB.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRowManuel();

            WrapperCalcul();
        }

        private void startStackNum_ValueChanged(object sender, EventArgs e)
        {
            WrapperCalcul();
        }

        private void totalPlayerNum_ValueChanged(object sender, EventArgs e)
        {
            bountyInGameNum.Maximum = bountyPerPlayerNum.Value * totalPlayerNum.Value;
            bountyInGameNum.Value = bountyPerPlayerNum.Value * totalPlayerNum.Value;
            WrapperCalcul();
        }

        private void bountyPerPlayerNum_ValueChanged(object sender, EventArgs e)
        {
            bountyInGameNum.Maximum = bountyPerPlayerNum.Value * totalPlayerNum.Value;
            bountyInGameNum.Value = bountyPerPlayerNum.Value * totalPlayerNum.Value;
            WrapperCalcul();
        }

        private void valueBountyNum_ValueChanged(object sender, EventArgs e)
        {
            WrapperCalcul();
        }

        private void bountyInGameNum_ValueChanged(object sender, EventArgs e)
        {
            WrapperCalcul();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            WrapperCalcul();
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {
            WrapperCalcul();
        }

        private void pseudoAddTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddRowManuel();
                WrapperCalcul();
                e.Handled = true; //coupe le son au passage le ding
            }
        }

        private void jetonAddNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddRowManuel();
                WrapperCalcul();
                e.Handled = true; //coupe le son au passage le ding
            }
        }

        private void bountyAddNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddRowManuel();
                WrapperCalcul();
                e.Handled = true; //coupe le son au passage le ding
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            WrapperCalcul();
        }
    }
}