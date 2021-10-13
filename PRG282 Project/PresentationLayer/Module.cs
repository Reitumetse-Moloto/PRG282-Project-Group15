using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmModule : Form
    {
        public frmModule()
        {
            InitializeComponent();
        }
        DataHandler h = new DataHandler();

        private void Module_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = h.DisplayModule();

        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            h.InsertModule(txtModuleCode.Text, txtModName.Text, txtDescription.Text, txtLink.Text);
            MessageBox.Show("Data inserted successfully");
        }

        private void btnUpdateMod_Click(object sender, EventArgs e)
        {
            h.UpdateModule(txtModuleCode.Text, txtModName.Text, txtDescription.Text, txtLink.Text);
            MessageBox.Show("Module updated successfully");

        }

        private void btnDeleteMod_Click(object sender, EventArgs e)
        {
            h.DeleteModule(txtModuleCode.Text);
            MessageBox.Show("Module deleted successfully");

        }

        private void btnSearchMod_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = h.SearchModule(txtSearchModule.Text);
        }
    }
}
