using EncyrptionAndDecryption.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyrptionAndDecryption
{
    public partial class frmsql : Form
    {
        public frmsql()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var password = txtPass.Text;

            using(var context = new UserContext())
            {

                if(name.Contains("'") || password.Contains("'"))
                {
                    lblresult.Text = "Invalid Input";
                    return;
                }

                var result =  context.Users.FromSqlRaw($"Select * from Users where UserName = '{name}' and Password = '{password}'").FirstOrDefault();
             
                if (result != null )
                {
                  lblresult.Text = $"Registration completed successfully ";
                }
                else
                {
                    lblresult.Text = $" Username or Password is Wrong ";
                }
            }


        }
    }
}
