﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JashukProjekt
{
    public partial class ProfitOfCircAssets : Form
    {
        public ProfitOfCircAssets()
        {
            InitializeComponent();
            total.Controls[0].Visible = false;//убираем стрелки в форме total
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double NetProfit = Convert.ToDouble(net.Value);//переводим из строчной в цифры
            double Assets = Convert.ToDouble(assets.Value);//переводим из строчной в цифры

            if (Assets != 0)
            {
                double Answer = NetProfit/Assets;
                total.Text = Convert.ToString(Math.Round(Answer, 2));//вывод в форме total c округлением до двух знаков после запятой
            }
            else
            {
                Bled bled = new Bled();
                bled.Show();
            }
        }

        private void assets_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
