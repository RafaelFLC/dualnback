﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dualnBack.controllers;

namespace dualnBack
{
    public partial class AdminFrm : Form
    {
        private static AdminFrm instancia;

        private AdminFrm()
        {
            InitializeComponent();
        }

        public static AdminFrm New
        {
            get
            {
                if(instancia == null)
                    instancia = new AdminFrm();

                return instancia;
            }
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            dGUsers.DataSource = AdminController.New.getUsers();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = dGUsers.CurrentCell.RowIndex;
            var user = dGUsers[1, row].Value.ToString();
            dGUsers.DataSource = AdminController.New.deleteUser(user);
            dGUsers.Update();
        }
    }
}
