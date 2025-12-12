namespace Responsi2
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
            groupBox1 = new GroupBox();
            cb_statusKontrak = new ComboBox();
            cb_proyek = new ComboBox();
            tb_namaDeveloper = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            tb_jumlahBug = new TextBox();
            tb_fiturSelesai = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btn_insert = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            groupBox3 = new GroupBox();
            dgvData = new DataGridView();
            btn_load = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 0;
            label1.Text = "Project Management App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 52);
            label2.Name = "label2";
            label2.Size = new Size(324, 25);
            label2.TabIndex = 1;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_statusKontrak);
            groupBox1.Controls.Add(cb_proyek);
            groupBox1.Controls.Add(tb_namaDeveloper);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // cb_statusKontrak
            // 
            cb_statusKontrak.FormattingEnabled = true;
            cb_statusKontrak.Location = new Point(123, 76);
            cb_statusKontrak.Name = "cb_statusKontrak";
            cb_statusKontrak.Size = new Size(147, 25);
            cb_statusKontrak.TabIndex = 8;
            cb_statusKontrak.SelectedIndexChanged += cb_statusKontrak_SelectedIndexChanged;
            // 
            // cb_proyek
            // 
            cb_proyek.FormattingEnabled = true;
            cb_proyek.Location = new Point(123, 51);
            cb_proyek.Name = "cb_proyek";
            cb_proyek.Size = new Size(147, 25);
            cb_proyek.TabIndex = 7;
            cb_proyek.SelectedIndexChanged += cb_proyek_SelectedIndexChanged;
            // 
            // tb_namaDeveloper
            // 
            tb_namaDeveloper.Location = new Point(123, 24);
            tb_namaDeveloper.Name = "tb_namaDeveloper";
            tb_namaDeveloper.Size = new Size(147, 25);
            tb_namaDeveloper.TabIndex = 3;
            tb_namaDeveloper.TextChanged += tb_namaDeveloper_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 81);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 2;
            label5.Text = "Status Kontrak :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 56);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 1;
            label4.Text = "Pilih Proyek :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 30);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 0;
            label3.Text = "Nama Developer :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tb_jumlahBug);
            groupBox2.Controls.Add(tb_fiturSelesai);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(27, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 90);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(206, 56);
            label9.Name = "label9";
            label9.Size = new Size(166, 15);
            label9.TabIndex = 6;
            label9.Text = "(Jumlah bug yang ditemukan)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 29);
            label6.Name = "label6";
            label6.Size = new Size(164, 15);
            label6.TabIndex = 5;
            label6.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // tb_jumlahBug
            // 
            tb_jumlahBug.Location = new Point(123, 51);
            tb_jumlahBug.Name = "tb_jumlahBug";
            tb_jumlahBug.Size = new Size(69, 25);
            tb_jumlahBug.TabIndex = 4;
            // 
            // tb_fiturSelesai
            // 
            tb_fiturSelesai.Location = new Point(123, 24);
            tb_fiturSelesai.Name = "tb_fiturSelesai";
            tb_fiturSelesai.Size = new Size(69, 25);
            tb_fiturSelesai.TabIndex = 3;
            tb_fiturSelesai.TextChanged += tb_fiturSelesai_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 56);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 1;
            label7.Text = "Jumlah Bug :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 30);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 0;
            label8.Text = "Fitur Selesai :";
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(69, 315);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(75, 23);
            btn_insert.TabIndex = 7;
            btn_insert.Text = "INSERT";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(456, 315);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(324, 315);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 9;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvData);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(27, 354);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(566, 112);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(3, 21);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(557, 85);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(203, 315);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(75, 23);
            btn_load.TabIndex = 10;
            btn_load.Text = "LOAD";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 77);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 490);
            Controls.Add(pictureBox1);
            Controls.Add(btn_load);
            Controls.Add(groupBox3);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_insert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox tb_namaDeveloper;
        private GroupBox groupBox2;
        private TextBox tb_jumlahBug;
        private TextBox tb_fiturSelesai;
        private Label label7;
        private Label label8;
        private ComboBox cb_proyek;
        private Label label9;
        private Label label6;
        private ComboBox cb_statusKontrak;
        private Button btn_insert;
        private Button btn_delete;
        private Button btn_update;
        private GroupBox groupBox3;
        private DataGridView dgvData;
        private Button btn_load;
        private PictureBox pictureBox1;
    }
}
