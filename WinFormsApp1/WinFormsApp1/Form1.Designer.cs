namespace WinFormsApp1
{
    partial class FrmBai1
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
            lblKetQua = new Label();
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnTong = new Button();
            btnHieu = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.FromArgb(255, 255, 192);
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Location = new Point(1, 19);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(466, 59);
            lblKetQua.TabIndex = 0;
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            lblKetQua.Click += label1_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 169);
            lblA.Name = "lblA";
            lblA.Size = new Size(156, 31);
            lblA.TabIndex = 1;
            lblA.Text = "Số Nguyên A:";
            lblA.Click += label2_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(13, 219);
            lblB.Name = "lblB";
            lblB.Size = new Size(155, 31);
            lblB.TabIndex = 1;
            lblB.Text = "Số Nguyên B:";
            lblB.Click += label3_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(192, 162);
            txtA.Name = "txtA";
            txtA.Size = new Size(159, 38);
            txtA.TabIndex = 1;
            txtA.Text = "12";
            // 
            // txtB
            // 
            txtB.Location = new Point(192, 212);
            txtB.Name = "txtB";
            txtB.Size = new Size(159, 38);
            txtB.TabIndex = 2;
            txtB.Text = "12";
            // 
            // btnTong
            // 
            btnTong.BackColor = Color.FromArgb(128, 255, 128);
            btnTong.Location = new Point(52, 343);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(94, 40);
            btnTong.TabIndex = 3;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = false;
            btnTong.Click += btnTong_Click;
            // 
            // btnHieu
            // 
            btnHieu.BackColor = Color.FromArgb(255, 192, 192);
            btnHieu.Location = new Point(186, 343);
            btnHieu.Name = "btnHieu";
            btnHieu.Size = new Size(94, 40);
            btnHieu.TabIndex = 4;
            btnHieu.Text = "Hiệu";
            btnHieu.UseVisualStyleBackColor = false;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 192, 192);
            btnReset.Location = new Point(313, 343);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 40);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(186, 400);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 40);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmBai1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(467, 526);
            Controls.Add(btnReset);
            Controls.Add(btnThoat);
            Controls.Add(btnHieu);
            Controls.Add(btnTong);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblKetQua);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmBai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKetQua;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTong;
        private Button btnHieu;
        private Button btnReset;
        private Button btnThoat;
    }
}