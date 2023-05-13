namespace BaiTapThucHanh
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
            this.gt_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gt_2 = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PythonRun = new System.Windows.Forms.Button();
            this.btn_javaRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textTranOut = new System.Windows.Forms.TextBox();
            this.textTranIn = new System.Windows.Forms.TextBox();
            this.msg_textBox = new System.Windows.Forms.TextBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gt_1
            // 
            this.gt_1.Location = new System.Drawing.Point(48, 28);
            this.gt_1.Name = "gt_1";
            this.gt_1.Size = new System.Drawing.Size(123, 20);
            this.gt_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số 2";
            // 
            // gt_2
            // 
            this.gt_2.Location = new System.Drawing.Point(48, 63);
            this.gt_2.Name = "gt_2";
            this.gt_2.Size = new System.Drawing.Size(123, 20);
            this.gt_2.TabIndex = 2;
            // 
            // kq
            // 
            this.kq.BackColor = System.Drawing.Color.DimGray;
            this.kq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kq.ForeColor = System.Drawing.SystemColors.Info;
            this.kq.Location = new System.Drawing.Point(60, 279);
            this.kq.Multiline = true;
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(659, 132);
            this.kq.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Window Log:";
            // 
            // btn_PythonRun
            // 
            this.btn_PythonRun.Location = new System.Drawing.Point(94, 168);
            this.btn_PythonRun.Name = "btn_PythonRun";
            this.btn_PythonRun.Size = new System.Drawing.Size(86, 40);
            this.btn_PythonRun.TabIndex = 6;
            this.btn_PythonRun.Text = "Text to sound";
            this.btn_PythonRun.UseVisualStyleBackColor = true;
            this.btn_PythonRun.Click += new System.EventHandler(this.btn_PythonRun_Click);
            // 
            // btn_javaRun
            // 
            this.btn_javaRun.Location = new System.Drawing.Point(90, 101);
            this.btn_javaRun.Name = "btn_javaRun";
            this.btn_javaRun.Size = new System.Drawing.Size(81, 40);
            this.btn_javaRun.TabIndex = 6;
            this.btn_javaRun.Text = "Execute";
            this.btn_javaRun.UseVisualStyleBackColor = true;
            this.btn_javaRun.Click += new System.EventHandler(this.btn_javaRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gt_1);
            this.groupBox1.Controls.Add(this.btn_javaRun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gt_2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Java";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textTranOut);
            this.groupBox2.Controls.Add(this.textTranIn);
            this.groupBox2.Controls.Add(this.msg_textBox);
            this.groupBox2.Controls.Add(this.btn_Translate);
            this.groupBox2.Controls.Add(this.btn_PythonRun);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 224);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Python";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textTranOut
            // 
            this.textTranOut.Location = new System.Drawing.Point(222, 147);
            this.textTranOut.Multiline = true;
            this.textTranOut.Name = "textTranOut";
            this.textTranOut.Size = new System.Drawing.Size(166, 48);
            this.textTranOut.TabIndex = 8;
            // 
            // textTranIn
            // 
            this.textTranIn.Location = new System.Drawing.Point(222, 50);
            this.textTranIn.Multiline = true;
            this.textTranIn.Name = "textTranIn";
            this.textTranIn.Size = new System.Drawing.Size(166, 48);
            this.textTranIn.TabIndex = 8;
            // 
            // msg_textBox
            // 
            this.msg_textBox.Location = new System.Drawing.Point(19, 28);
            this.msg_textBox.Multiline = true;
            this.msg_textBox.Name = "msg_textBox";
            this.msg_textBox.Size = new System.Drawing.Size(161, 125);
            this.msg_textBox.TabIndex = 7;
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(413, 104);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(71, 40);
            this.btn_Translate.TabIndex = 6;
            this.btn_Translate.Text = "Translate";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kq);
            this.Name = "Form1";
            this.Text = "Bài tập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gt_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gt_2;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PythonRun;
        private System.Windows.Forms.Button btn_javaRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox msg_textBox;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.TextBox textTranOut;
        private System.Windows.Forms.TextBox textTranIn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

