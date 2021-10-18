
namespace Proyectobasedatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.dtBirthdate = new MetroFramework.Controls.MetroDateTime();
            this.txtOwner = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lNew = new MetroFramework.Controls.MetroLink();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(-6, 38);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(823, 374);
            this.tabs.TabIndex = 34;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txtEmail);
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.btnSave);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.lblId);
            this.tabForm.Controls.Add(this.dtBirthdate);
            this.tabForm.Controls.Add(this.txtOwner);
            this.tabForm.Controls.Add(this.metroLabel2);
            this.tabForm.Controls.Add(this.metroLabel5);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.txtPassword);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(815, 336);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "ACCOUNT";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(503, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 33);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(408, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 33);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(83, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Owner";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id account";
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CustomFormat = "0000-00-00";
            this.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthdate.Location = new System.Drawing.Point(210, 115);
            this.dtBirthdate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(155, 29);
            this.dtBirthdate.TabIndex = 21;
            this.dtBirthdate.Value = new System.DateTime(1998, 12, 1, 0, 0, 0, 0);
            // 
            // txtOwner
            // 
            // 
            // 
            // 
            this.txtOwner.CustomButton.Image = null;
            this.txtOwner.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtOwner.CustomButton.Name = "";
            this.txtOwner.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOwner.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOwner.CustomButton.TabIndex = 1;
            this.txtOwner.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOwner.CustomButton.UseSelectable = true;
            this.txtOwner.CustomButton.Visible = false;
            this.txtOwner.Lines = new string[0];
            this.txtOwner.Location = new System.Drawing.Point(210, 165);
            this.txtOwner.MaxLength = 32767;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.PasswordChar = '\0';
            this.txtOwner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOwner.SelectedText = "";
            this.txtOwner.SelectionLength = 0;
            this.txtOwner.SelectionStart = 0;
            this.txtOwner.ShortcutsEnabled = true;
            this.txtOwner.Size = new System.Drawing.Size(303, 23);
            this.txtOwner.TabIndex = 19;
            this.txtOwner.UseSelectable = true;
            this.txtOwner.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOwner.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(83, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Email";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(83, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Birthdate";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(210, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(101, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(210, 69);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(303, 23);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgAccount);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(815, 336);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "ACCOUNT LIST";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // dtgAccount
            // 
            this.dtgAccount.AllowUserToAddRows = false;
            this.dtgAccount.AllowUserToDeleteRows = false;
            this.dtgAccount.AllowUserToResizeColumns = false;
            this.dtgAccount.AllowUserToResizeRows = false;
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.BackgroundColor = System.Drawing.Color.White;
            this.dtgAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgAccount.MultiSelect = false;
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgAccount.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAccount.Size = new System.Drawing.Size(772, 263);
            this.dtgAccount.TabIndex = 32;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(210, 227);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = true;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(101, 23);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lNew
            // 
            this.lNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNew.Location = new System.Drawing.Point(69, 9);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(75, 23);
            this.lNew.TabIndex = 35;
            this.lNew.Text = "| new account";
            this.lNew.UseSelectable = true;
            this.lNew.Click += new System.EventHandler(this.lNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 453);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroDateTime dtBirthdate;
        private MetroFramework.Controls.MetroTextBox txtOwner;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTabPage tabData;
        private System.Windows.Forms.DataGridView dtgAccount;
        private MetroFramework.Controls.MetroLink lNew;
    }
}

