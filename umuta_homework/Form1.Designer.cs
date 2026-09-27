namespace umuta_homework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnDELETE = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "AD               ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "SOYAD         ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(37, 118);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "E-POSTA      ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(722, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(148, 74);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(161, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Location = new Point(413, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 66);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.BackColor = Color.FromArgb(255, 128, 128);
            btnDELETE.Location = new Point(413, 118);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(94, 66);
            btnDELETE.TabIndex = 8;
            btnDELETE.Text = "SİL";
            btnDELETE.UseVisualStyleBackColor = false;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.Location = new Point(525, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 66);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 128, 255);
            btnSearch.Location = new Point(525, 118);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 66);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "ARA";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDELETE);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnDELETE;
        private Button btnUpdate;
        private Button btnSearch;
    }
}
