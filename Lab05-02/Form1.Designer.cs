
namespace Lab05_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.radioXemTheoThang = new System.Windows.Forms.RadioButton();
            this.radioXemTuNgay = new System.Windows.Forms.RadioButton();
            this.dtpTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTheoThang = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTuNgay2);
            this.groupBox1.Controls.Add(this.dtpTuNgay1);
            this.groupBox1.Controls.Add(this.dtpTheoThang);
            this.groupBox1.Controls.Add(this.dtpTheoNgay);
            this.groupBox1.Controls.Add(this.radioXemTuNgay);
            this.groupBox1.Controls.Add(this.radioXemTheoThang);
            this.groupBox1.Controls.Add(this.radioXemTheoNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // radioXemTheoNgay
            // 
            this.radioXemTheoNgay.AutoSize = true;
            this.radioXemTheoNgay.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioXemTheoNgay.Location = new System.Drawing.Point(185, 44);
            this.radioXemTheoNgay.Name = "radioXemTheoNgay";
            this.radioXemTheoNgay.Size = new System.Drawing.Size(143, 24);
            this.radioXemTheoNgay.TabIndex = 1;
            this.radioXemTheoNgay.TabStop = true;
            this.radioXemTheoNgay.Text = "Xem theo ngày";
            this.radioXemTheoNgay.UseVisualStyleBackColor = true;
            this.radioXemTheoNgay.CheckedChanged += new System.EventHandler(this.radioXemTheoNgay_CheckedChanged);
            // 
            // radioXemTheoThang
            // 
            this.radioXemTheoThang.AutoSize = true;
            this.radioXemTheoThang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioXemTheoThang.Location = new System.Drawing.Point(185, 108);
            this.radioXemTheoThang.Name = "radioXemTheoThang";
            this.radioXemTheoThang.Size = new System.Drawing.Size(150, 24);
            this.radioXemTheoThang.TabIndex = 2;
            this.radioXemTheoThang.TabStop = true;
            this.radioXemTheoThang.Text = "Xem theo tháng";
            this.radioXemTheoThang.UseVisualStyleBackColor = true;
            this.radioXemTheoThang.CheckedChanged += new System.EventHandler(this.radioXemTheoThang_CheckedChanged);
            // 
            // radioXemTuNgay
            // 
            this.radioXemTuNgay.AutoSize = true;
            this.radioXemTuNgay.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioXemTuNgay.Location = new System.Drawing.Point(185, 171);
            this.radioXemTuNgay.Name = "radioXemTuNgay";
            this.radioXemTuNgay.Size = new System.Drawing.Size(126, 24);
            this.radioXemTuNgay.TabIndex = 3;
            this.radioXemTuNgay.TabStop = true;
            this.radioXemTuNgay.Text = "Xem từ ngày";
            this.radioXemTuNgay.UseVisualStyleBackColor = true;
            this.radioXemTuNgay.CheckedChanged += new System.EventHandler(this.radioXemTuNgay_CheckedChanged);
            // 
            // dtpTheoNgay
            // 
            this.dtpTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTheoNgay.Location = new System.Drawing.Point(360, 44);
            this.dtpTheoNgay.Name = "dtpTheoNgay";
            this.dtpTheoNgay.Size = new System.Drawing.Size(141, 28);
            this.dtpTheoNgay.TabIndex = 4;
            // 
            // dtpTheoThang
            // 
            this.dtpTheoThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTheoThang.Location = new System.Drawing.Point(360, 108);
            this.dtpTheoThang.Name = "dtpTheoThang";
            this.dtpTheoThang.Size = new System.Drawing.Size(141, 28);
            this.dtpTheoThang.TabIndex = 5;
            // 
            // dtpTuNgay1
            // 
            this.dtpTuNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay1.Location = new System.Drawing.Point(360, 171);
            this.dtpTuNgay1.Name = "dtpTuNgay1";
            this.dtpTuNgay1.Size = new System.Drawing.Size(141, 28);
            this.dtpTuNgay1.TabIndex = 6;
            // 
            // dtpTuNgay2
            // 
            this.dtpTuNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay2.Location = new System.Drawing.Point(559, 171);
            this.dtpTuNgay2.Name = "dtpTuNgay2";
            this.dtpTuNgay2.Size = new System.Drawing.Size(139, 28);
            this.dtpTuNgay2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "~";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(559, 218);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(139, 35);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "In/Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 277);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(958, 319);
            this.reportViewer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 599);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Xem báo cáo thống kê đơn hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay1;
        private System.Windows.Forms.DateTimePicker dtpTheoThang;
        private System.Windows.Forms.DateTimePicker dtpTheoNgay;
        private System.Windows.Forms.RadioButton radioXemTuNgay;
        private System.Windows.Forms.RadioButton radioXemTheoThang;
        private System.Windows.Forms.RadioButton radioXemTheoNgay;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShow;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

