namespace TestApp
{
  partial class Form1
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
      this.Auth_Username = new System.Windows.Forms.TextBox();
      this.Auth_Password = new System.Windows.Forms.MaskedTextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.Classes_List = new System.Windows.Forms.ListBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.Clients_TabPage = new System.Windows.Forms.TabPage();
      this.Clients_List = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Clients_Name = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.Clients_Lastname = new System.Windows.Forms.TextBox();
      this.Clients_Email = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.Clients_PhoneNumber = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.Clients_Status = new System.Windows.Forms.TextBox();
      this.Clients_ID = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.Auth_Host = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.Clients_TabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // Auth_Username
      // 
      this.Auth_Username.Location = new System.Drawing.Point(67, 13);
      this.Auth_Username.Name = "Auth_Username";
      this.Auth_Username.Size = new System.Drawing.Size(172, 20);
      this.Auth_Username.TabIndex = 0;
      // 
      // Auth_Password
      // 
      this.Auth_Password.Location = new System.Drawing.Point(67, 39);
      this.Auth_Password.Name = "Auth_Password";
      this.Auth_Password.Size = new System.Drawing.Size(172, 20);
      this.Auth_Password.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Auth_Host);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.Auth_Password);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.Auth_Username);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(245, 119);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Auth";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(67, 91);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(172, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Username";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.Classes_List);
      this.groupBox2.Location = new System.Drawing.Point(12, 137);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(245, 153);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Classes";
      // 
      // Classes_List
      // 
      this.Classes_List.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Classes_List.FormattingEnabled = true;
      this.Classes_List.Location = new System.Drawing.Point(3, 16);
      this.Classes_List.Name = "Classes_List";
      this.Classes_List.Size = new System.Drawing.Size(239, 134);
      this.Classes_List.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.Clients_TabPage);
      this.tabControl1.Location = new System.Drawing.Point(263, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(416, 278);
      this.tabControl1.TabIndex = 4;
      // 
      // Clients_TabPage
      // 
      this.Clients_TabPage.Controls.Add(this.Clients_ID);
      this.Clients_TabPage.Controls.Add(this.label8);
      this.Clients_TabPage.Controls.Add(this.Clients_Status);
      this.Clients_TabPage.Controls.Add(this.label7);
      this.Clients_TabPage.Controls.Add(this.Clients_PhoneNumber);
      this.Clients_TabPage.Controls.Add(this.label6);
      this.Clients_TabPage.Controls.Add(this.Clients_Email);
      this.Clients_TabPage.Controls.Add(this.label5);
      this.Clients_TabPage.Controls.Add(this.Clients_Lastname);
      this.Clients_TabPage.Controls.Add(this.label4);
      this.Clients_TabPage.Controls.Add(this.Clients_Name);
      this.Clients_TabPage.Controls.Add(this.label3);
      this.Clients_TabPage.Controls.Add(this.Clients_List);
      this.Clients_TabPage.Location = new System.Drawing.Point(4, 22);
      this.Clients_TabPage.Name = "Clients_TabPage";
      this.Clients_TabPage.Padding = new System.Windows.Forms.Padding(3);
      this.Clients_TabPage.Size = new System.Drawing.Size(408, 252);
      this.Clients_TabPage.TabIndex = 0;
      this.Clients_TabPage.Text = "Clients";
      this.Clients_TabPage.UseVisualStyleBackColor = true;
      // 
      // Clients_List
      // 
      this.Clients_List.FormattingEnabled = true;
      this.Clients_List.Location = new System.Drawing.Point(6, 6);
      this.Clients_List.Name = "Clients_List";
      this.Clients_List.Size = new System.Drawing.Size(189, 238);
      this.Clients_List.TabIndex = 0;
      this.Clients_List.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(201, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Name";
      // 
      // Clients_Name
      // 
      this.Clients_Name.Location = new System.Drawing.Point(204, 22);
      this.Clients_Name.Name = "Clients_Name";
      this.Clients_Name.ReadOnly = true;
      this.Clients_Name.Size = new System.Drawing.Size(198, 20);
      this.Clients_Name.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(201, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Lastname";
      // 
      // Clients_Lastname
      // 
      this.Clients_Lastname.Location = new System.Drawing.Point(204, 61);
      this.Clients_Lastname.Name = "Clients_Lastname";
      this.Clients_Lastname.ReadOnly = true;
      this.Clients_Lastname.Size = new System.Drawing.Size(198, 20);
      this.Clients_Lastname.TabIndex = 5;
      // 
      // Clients_Email
      // 
      this.Clients_Email.Location = new System.Drawing.Point(204, 100);
      this.Clients_Email.Name = "Clients_Email";
      this.Clients_Email.ReadOnly = true;
      this.Clients_Email.Size = new System.Drawing.Size(198, 20);
      this.Clients_Email.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(201, 84);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(32, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Email";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(201, 123);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(78, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Phone Number";
      // 
      // Clients_PhoneNumber
      // 
      this.Clients_PhoneNumber.Location = new System.Drawing.Point(204, 139);
      this.Clients_PhoneNumber.Name = "Clients_PhoneNumber";
      this.Clients_PhoneNumber.ReadOnly = true;
      this.Clients_PhoneNumber.Size = new System.Drawing.Size(198, 20);
      this.Clients_PhoneNumber.TabIndex = 9;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(201, 162);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(37, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Status";
      // 
      // Clients_Status
      // 
      this.Clients_Status.Location = new System.Drawing.Point(204, 178);
      this.Clients_Status.Name = "Clients_Status";
      this.Clients_Status.ReadOnly = true;
      this.Clients_Status.Size = new System.Drawing.Size(198, 20);
      this.Clients_Status.TabIndex = 11;
      // 
      // Clients_ID
      // 
      this.Clients_ID.Location = new System.Drawing.Point(204, 217);
      this.Clients_ID.Name = "Clients_ID";
      this.Clients_ID.ReadOnly = true;
      this.Clients_ID.Size = new System.Drawing.Size(198, 20);
      this.Clients_ID.TabIndex = 13;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(201, 201);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(18, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "ID";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 68);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(52, 13);
      this.label9.TabIndex = 3;
      this.label9.Text = "Http Host";
      // 
      // Auth_Host
      // 
      this.Auth_Host.Location = new System.Drawing.Point(67, 65);
      this.Auth_Host.Name = "Auth_Host";
      this.Auth_Host.Size = new System.Drawing.Size(172, 20);
      this.Auth_Host.TabIndex = 4;
      this.Auth_Host.Text = "http://whmcs/";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 301);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.Clients_TabPage.ResumeLayout(false);
      this.Clients_TabPage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox Auth_Username;
    private System.Windows.Forms.MaskedTextBox Auth_Password;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox Classes_List;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage Clients_TabPage;
    private System.Windows.Forms.TextBox Clients_ID;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox Clients_Status;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox Clients_PhoneNumber;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox Clients_Email;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox Clients_Lastname;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox Clients_Name;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox Clients_List;
    private System.Windows.Forms.TextBox Auth_Host;
    private System.Windows.Forms.Label label9;
  }
}

