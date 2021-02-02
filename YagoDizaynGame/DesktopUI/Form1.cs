using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Contexts;
using Entities;

namespace DesktopUI
{
    public partial class Form1 : Form
    {
        private IUserService _userManager = new UserManager();
        private ISalesService _salesManager=new SalesManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {
            _userManager.Add("@NickName", txtNickName.Text);
        }
    }
}
