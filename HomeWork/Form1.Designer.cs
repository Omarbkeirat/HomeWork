namespace HomeWork
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
            this.btnnumberofcontrolsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumberofcontrols = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnldy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnnumberofcontrolsButton
            // 
            this.btnnumberofcontrolsButton.Location = new System.Drawing.Point(48, 162);
            this.btnnumberofcontrolsButton.Name = "btnnumberofcontrolsButton";
            this.btnnumberofcontrolsButton.Size = new System.Drawing.Size(100, 38);
            this.btnnumberofcontrolsButton.TabIndex = 0;
            this.btnnumberofcontrolsButton.Text = "Creat Controls Button";
            this.btnnumberofcontrolsButton.UseVisualStyleBackColor = true;
            this.btnnumberofcontrolsButton.Click += new System.EventHandler(this.btnnumberofcontrolsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controls Type";
            // 
            // txtnumberofcontrols
            // 
            this.txtnumberofcontrols.Location = new System.Drawing.Point(150, 114);
            this.txtnumberofcontrols.Name = "txtnumberofcontrols";
            this.txtnumberofcontrols.Size = new System.Drawing.Size(172, 20);
            this.txtnumberofcontrols.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buttons",
            "TextBox",
            "Label"});
            this.comboBox1.Location = new System.Drawing.Point(150, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Controls Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create Control TextBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnldy
            // 
            this.pnldy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldy.Location = new System.Drawing.Point(48, 215);
            this.pnldy.Name = "pnldy";
            this.pnldy.Size = new System.Drawing.Size(335, 297);
            this.pnldy.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.pnldy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtnumberofcontrols);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnumberofcontrolsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnumberofcontrolsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumberofcontrols;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnldy;
    }
}

