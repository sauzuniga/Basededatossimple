using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyectobasedatos
{
    public partial class Form1 : Form
    {
        private string action = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        public void fillDataGridView()
        {
            Account account = new Account();

            clearDataGridView();

            dtgAccount.Columns.Add("idaccount", "ID ACCOUNT");
            dtgAccount.Columns.Add("password", "PASSWORD");
            dtgAccount.Columns.Add("birthdate", "BIRTHDATE");
            dtgAccount.Columns.Add("owner", "OWNER");
            dtgAccount.Columns.Add("email", "EMAIL");

            MySqlDataReader dataReader = account.getAllAccount();

           
            while (dataReader.Read())
            {
                dtgAccount.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4)
                       );
            }
        }

        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtPassword.Enabled = false;
            dtBirthdate.Enabled = false;
            txtOwner.Enabled = false;
            txtEmail.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
       
        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtPassword.Enabled = true;
            dtBirthdate.Enabled = true;
            txtOwner.Enabled = true;
            txtEmail.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        public void clearControls()
        {
            txtId.Text = "";
            txtPassword.Text = "";
            dtBirthdate.Text = "";
            txtOwner.Text = "";
            txtEmail.Text = "";
        }
        public void clearDataGridView()
        {
            dtgAccount.Columns.Clear();
            dtgAccount.Rows.Clear();
        }

        private void lNew_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabForm);
            tabs.TabPages.Remove(tabData); 
            tabs.TabPages[0].Text = "NEW ACCOUNT"; 

            txtId.Visible = false;
            lblId.Visible = false;
            txtPassword.Focus(); 
            action = "new";
            controlsEnable();
            clearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el titulo", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus(); 

            }
            else
            {

                Account account = new Account(); 
                if (action == "edit")
                {
                    account._idAccount = Convert.ToInt32(txtId.Text);
                }


                account._password = txtPassword.Text;
                account._birthDate = dtBirthdate.Text;
                account._owner = txtOwner.Text;
                account._email = txtEmail.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    if (account.newEditAccount(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clearControls();
                    controlsDisable();
                    fillDataGridView();
                    tabs.TabPages.Remove(tabForm);
                    tabs.TabPages.Add(tabData);
                    tabs.TabPages[0].Text = "ACCOUNT LIST";
                }
                }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguró que desea cancelar?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearControls();
                controlsDisable();


                tabs.TabPages.Remove(tabForm);
                tabs.TabPages.Add(tabData);
                tabs.TabPages[0].Text = "ACCOUNT LIST";
            }
        }
    }
}
