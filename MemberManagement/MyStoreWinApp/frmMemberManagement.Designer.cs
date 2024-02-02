namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMember = new DataGridView();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            lbMemberId = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            txtMemberId = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(229, 17);
            dgvMember.Name = "dgvMember";
            dgvMember.Size = new Size(339, 274);
            dgvMember.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(24, 217);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(114, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(24, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(114, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(12, 30);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(66, 15);
            lbMemberId.TabIndex = 5;
            lbMemberId.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(12, 61);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(87, 15);
            lbMemberName.TabIndex = 6;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 90);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(12, 119);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(12, 148);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 9;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(12, 177);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(105, 27);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(118, 23);
            txtMemberId.TabIndex = 11;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(105, 58);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(118, 23);
            txtMemberName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(118, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(105, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(118, 23);
            txtPassword.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(105, 145);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(118, 23);
            txtCity.TabIndex = 15;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(105, 174);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(118, 23);
            txtCountry.TabIndex = 16;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 303);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberId);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberId);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(dgvMember);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagement";
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private Label lbMemberId;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberId;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
    }
}