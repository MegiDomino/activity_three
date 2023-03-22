namespace WindowsFormsApplication3
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
            this.JP = new System.Windows.Forms.CheckBox();
            this.survTayt = new System.Windows.Forms.Label();
            this.quesWan = new System.Windows.Forms.Label();
            this.PH = new System.Windows.Forms.CheckBox();
            this.THAI = new System.Windows.Forms.CheckBox();
            this.INDO = new System.Windows.Forms.CheckBox();
            this.othersLable = new System.Windows.Forms.Label();
            this.othersBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.others = new System.Windows.Forms.CheckBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JP
            // 
            this.JP.AutoSize = true;
            this.JP.Location = new System.Drawing.Point(17, 77);
            this.JP.Name = "JP";
            this.JP.Size = new System.Drawing.Size(55, 17);
            this.JP.TabIndex = 0;
            this.JP.Text = "Japan";
            this.JP.UseVisualStyleBackColor = true;
            this.JP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // survTayt
            // 
            this.survTayt.AutoSize = true;
            this.survTayt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survTayt.Location = new System.Drawing.Point(12, 9);
            this.survTayt.Name = "survTayt";
            this.survTayt.Size = new System.Drawing.Size(79, 25);
            this.survTayt.TabIndex = 1;
            this.survTayt.Text = "Survey";
            // 
            // quesWan
            // 
            this.quesWan.AutoSize = true;
            this.quesWan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesWan.Location = new System.Drawing.Point(13, 54);
            this.quesWan.Name = "quesWan";
            this.quesWan.Size = new System.Drawing.Size(191, 20);
            this.quesWan.TabIndex = 2;
            this.quesWan.Text = "Where do you like to visit?";
            // 
            // PH
            // 
            this.PH.AutoSize = true;
            this.PH.Location = new System.Drawing.Point(17, 100);
            this.PH.Name = "PH";
            this.PH.Size = new System.Drawing.Size(76, 17);
            this.PH.TabIndex = 3;
            this.PH.Text = "Philippines";
            this.PH.UseVisualStyleBackColor = true;
            this.PH.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // THAI
            // 
            this.THAI.AutoSize = true;
            this.THAI.Location = new System.Drawing.Point(89, 77);
            this.THAI.Name = "THAI";
            this.THAI.Size = new System.Drawing.Size(67, 17);
            this.THAI.TabIndex = 4;
            this.THAI.Text = "Thailand";
            this.THAI.UseVisualStyleBackColor = true;
            this.THAI.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // INDO
            // 
            this.INDO.AutoSize = true;
            this.INDO.Location = new System.Drawing.Point(89, 100);
            this.INDO.Name = "INDO";
            this.INDO.Size = new System.Drawing.Size(72, 17);
            this.INDO.TabIndex = 5;
            this.INDO.Text = "Indonesia";
            this.INDO.UseVisualStyleBackColor = true;
            this.INDO.CheckedChanged += new System.EventHandler(this.checkBox4INDO_CheckedChanged);
            // 
            // othersLable
            // 
            this.othersLable.AutoSize = true;
            this.othersLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLable.Location = new System.Drawing.Point(12, 157);
            this.othersLable.Name = "othersLable";
            this.othersLable.Size = new System.Drawing.Size(180, 20);
            this.othersLable.TabIndex = 6;
            this.othersLable.Text = "If others, please specify.";
            this.othersLable.Click += new System.EventHandler(this.othersLable_Click);
            // 
            // othersBox
            // 
            this.othersBox.Location = new System.Drawing.Point(17, 180);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(100, 20);
            this.othersBox.TabIndex = 7;
            this.othersBox.TextChanged += new System.EventHandler(this.othersBox_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(103, 273);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // others
            // 
            this.others.AutoSize = true;
            this.others.Location = new System.Drawing.Point(16, 122);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(57, 17);
            this.others.TabIndex = 9;
            this.others.Text = "Others";
            this.others.UseVisualStyleBackColor = true;
            this.others.UseWaitCursor = true;
            this.others.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(198, 273);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 367);
            this.Controls.Add(this.close);
            this.Controls.Add(this.others);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.othersLable);
            this.Controls.Add(this.INDO);
            this.Controls.Add(this.THAI);
            this.Controls.Add(this.PH);
            this.Controls.Add(this.quesWan);
            this.Controls.Add(this.survTayt);
            this.Controls.Add(this.JP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox JP;
        private System.Windows.Forms.Label survTayt;
        private System.Windows.Forms.Label quesWan;
        private System.Windows.Forms.CheckBox PH;
        private System.Windows.Forms.CheckBox THAI;
        private System.Windows.Forms.CheckBox INDO;
        private System.Windows.Forms.Label othersLable;
        private System.Windows.Forms.TextBox othersBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.CheckBox others;
        private System.Windows.Forms.Button close;
    }
}

