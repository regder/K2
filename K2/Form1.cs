using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesing();
        }
        private void customDesing()
        {
            OrderPanel.Visible = false;
            servicePanel.Visible = false;
            ProdPanel.Visible = false;
        }
        private void HideSubMenu()
        {
            if(OrderPanel.Visible == true)            
                OrderPanel.Visible = false;
            if (ProdPanel.Visible == true)
                ProdPanel.Visible = false;
            if (servicePanel.Visible == true)
                servicePanel.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void servicebtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(servicePanel);
        }

        private void prodbtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ProdPanel);
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(OrderPanel);
        }
    }
}
