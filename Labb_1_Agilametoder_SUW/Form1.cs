﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
{
    public partial class Form1 : Form
    {
        List<String> Stringlist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            // Stringlist.Add("Namn     Mejl     Nummer");
            // Stringlist.Add("Bengt     benga55@gmail.com     0701234567");
            //  Stringlist.Add("Peter     ptr@hotspot.com     0701234576");
            //  Stringlist.Add("Lina     lina_w@gmail.com     0701239654");
            // Stringlist.Add("Ahmed     ahmed_ahmed@gmail.com     0707654321");
            // Stringlist.Add("Angelica     angelangelica@gmail.com     0701212125");
            //  Stringlist.Add("Olof     olof_olofsson5@gmail.com     0702223336");
            // Stringlist.Add("Clara     stensson_c@gmail.com     0730456789");
            //  Stringlist.Add("Stina     stinastinastinastina@hotmail.com     0700554412");
             //Stringlist.Add("Bertil     beritochbertil@telia.com     0700000258");

                Stringlist.Add(name.Text + " " + email.Text + " " + phone.Text);
            



        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (this.name.Text != "" && this.email.Text!="" && this.phone.Text != "") 
           {
                employeeList.Items.Add(name.Text + "     " + email.Text + "     " + phone.Text);
                Stringlist.Add(name.Text + "     " + email.Text + "     " + phone.Text);


            } else {
                MessageBox.Show("Please enter some text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.name.Focus();
                //employeeList.Items.Add(name.Text + "     " + email.Text + "     " + phone.Text);
                

            }
            //Stringlist.Add(name.Text + "     " + email.Text + "     " + phone.Text);
            Stuff();
        }
    

        private void btn_show_Click(object sender, EventArgs e)
        {
            int i = 0;while(i < Stringlist.Count)
            {
                employeeList.Items.Add(Stringlist.ElementAt(i)); i++;
            }
       Stuff();

        }

       

        private void Stuff()
        {
            name.Clear(); email.Clear(); phone.Clear();
          
        }

        private void ClearList()
        {

            employeeList.Items.Clear();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            string str = txt_search.Text;int i = 0;
            while (i < Stringlist.Count)
            {if (Stringlist.ElementAt(i).Contains(str)){    MessageBox.Show("Hittade: " + Stringlist.ElementAt(i)); i++;}else
                {MessageBox.Show("Nope"); i++; }}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ClearList();
        }
    }
}
