namespace DictionaryApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            btXoa = new Button();
            btLuu = new Button();
            btSua = new Button();
            btTimKiem = new Button();
            txtShortVN = new TextBox();
            txtEnglish = new TextBox();
            txtVN = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(txtOutput);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(btXoa);
            groupBox1.Controls.Add(btLuu);
            groupBox1.Controls.Add(btSua);
            groupBox1.Controls.Add(btTimKiem);
            groupBox1.Controls.Add(txtShortVN);
            groupBox1.Controls.Add(txtEnglish);
            groupBox1.Controls.Add(txtVN);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm Từ Mới";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(481, 85);
            txtOutput.Name = "txtOutput";
            txtOutput.PlaceholderText = "Nghĩa tiếng Việt";
            txtOutput.Size = new Size(180, 23);
            txtOutput.TabIndex = 8;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(481, 42);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Nhập từ tiếng Anh";
            txtInput.Size = new Size(180, 23);
            txtInput.TabIndex = 8;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(692, 128);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(96, 49);
            btXoa.TabIndex = 6;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(468, 128);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(96, 49);
            btLuu.TabIndex = 7;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(581, 128);
            btSua.Name = "btSua";
            btSua.Size = new Size(96, 49);
            btSua.TabIndex = 5;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btTimKiem
            // 
            btTimKiem.Location = new Point(692, 34);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(83, 37);
            btTimKiem.TabIndex = 4;
            btTimKiem.Text = "Tìm Kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // txtShortVN
            // 
            txtShortVN.Location = new Point(146, 130);
            txtShortVN.Name = "txtShortVN";
            txtShortVN.PlaceholderText = "Nhập nghĩa tiếng Việt";
            txtShortVN.Size = new Size(125, 23);
            txtShortVN.TabIndex = 2;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(146, 85);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.PlaceholderText = "Nhập tiếng Anh";
            txtEnglish.Size = new Size(125, 23);
            txtEnglish.TabIndex = 1;
            // 
            // txtVN
            // 
            txtVN.Location = new Point(290, 58);
            txtVN.Multiline = true;
            txtVN.Name = "txtVN";
            txtVN.PlaceholderText = "Nhập nghĩa chi tiết";
            txtVN.ScrollBars = ScrollBars.Horizontal;
            txtVN.Size = new Size(161, 119);
            txtVN.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(146, 42);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Nhập ID";
            txtID.Size = new Size(125, 23);
            txtID.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 0;
            label3.Text = "Dịch nghĩa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "English:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(289, 34);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 0;
            label4.Text = "Dịch Nghĩa Chi Tiết:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsvDanhSach);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Từ Đã Có";
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvDanhSach.Dock = DockStyle.Fill;
            lsvDanhSach.FullRowSelect = true;
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(3, 19);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(794, 226);
            lsvDanhSach.TabIndex = 0;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "English";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ShortVN";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "VN";
            columnHeader4.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tra Từ Điển Anh-Việt";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtShortVN;
        private TextBox txtEnglish;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Button btXoa;
        private Button btLuu;
        private Button btSua;
        private Button btTimKiem;
        private TextBox txtVN;
        private Label label4;
        private ListView lsvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtOutput;
        private TextBox txtInput;
    }
}