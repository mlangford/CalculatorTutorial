namespace CalculatorTutorial
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMadd = new System.Windows.Forms.Button();
            this.btnMsub = new System.Windows.Forms.Button();
            this.btnMrec = new System.Windows.Forms.Button();
            this.btmMclr = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDP = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBksp = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtDisplay.Location = new System.Drawing.Point(22, 22);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(440, 45);
            this.txtDisplay.TabIndex = 24;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 249);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 45);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(113, 249);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 45);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(204, 249);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 45);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 193);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 45);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(113, 193);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 45);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(204, 193);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 45);
            this.btn6.TabIndex = 30;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 140);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 45);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(113, 140);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 45);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(204, 140);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 45);
            this.btn9.TabIndex = 33;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMadd
            // 
            this.btnMadd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMadd.Location = new System.Drawing.Point(22, 87);
            this.btnMadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMadd.Name = "btnMadd";
            this.btnMadd.Size = new System.Drawing.Size(64, 45);
            this.btnMadd.TabIndex = 34;
            this.btnMadd.Text = "M+";
            this.btnMadd.UseVisualStyleBackColor = false;
            this.btnMadd.Click += new System.EventHandler(this.btnMadd_Click);
            // 
            // btnMsub
            // 
            this.btnMsub.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsub.Location = new System.Drawing.Point(113, 87);
            this.btnMsub.Margin = new System.Windows.Forms.Padding(4);
            this.btnMsub.Name = "btnMsub";
            this.btnMsub.Size = new System.Drawing.Size(64, 45);
            this.btnMsub.TabIndex = 35;
            this.btnMsub.Text = "M-";
            this.btnMsub.UseVisualStyleBackColor = false;
            this.btnMsub.Click += new System.EventHandler(this.btnMsub_Click);
            // 
            // btnMrec
            // 
            this.btnMrec.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMrec.Location = new System.Drawing.Point(204, 87);
            this.btnMrec.Margin = new System.Windows.Forms.Padding(4);
            this.btnMrec.Name = "btnMrec";
            this.btnMrec.Size = new System.Drawing.Size(64, 45);
            this.btnMrec.TabIndex = 36;
            this.btnMrec.Text = "MR";
            this.btnMrec.UseVisualStyleBackColor = false;
            this.btnMrec.Click += new System.EventHandler(this.btnMrec_Click);
            // 
            // btmMclr
            // 
            this.btmMclr.BackColor = System.Drawing.Color.PowderBlue;
            this.btmMclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMclr.Location = new System.Drawing.Point(295, 87);
            this.btmMclr.Margin = new System.Windows.Forms.Padding(4);
            this.btmMclr.Name = "btmMclr";
            this.btmMclr.Size = new System.Drawing.Size(64, 45);
            this.btmMclr.TabIndex = 37;
            this.btmMclr.Text = "MC";
            this.btmMclr.UseVisualStyleBackColor = false;
            this.btmMclr.Click += new System.EventHandler(this.btmMclr_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(295, 140);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(64, 45);
            this.btnDiv.TabIndex = 38;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(295, 193);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(64, 45);
            this.btnMult.TabIndex = 39;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(295, 249);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(64, 45);
            this.btnSub.TabIndex = 40;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(22, 305);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(155, 45);
            this.btn0.TabIndex = 41;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDP
            // 
            this.btnDP.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDP.Location = new System.Drawing.Point(204, 305);
            this.btnDP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(64, 45);
            this.btnDP.TabIndex = 42;
            this.btnDP.Text = "n";
            this.btnDP.UseVisualStyleBackColor = true;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(295, 305);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 45);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.Khaki;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(398, 87);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(64, 45);
            this.btnFormat.TabIndex = 44;
            this.btnFormat.Text = "+/-";
            this.btnFormat.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(398, 140);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 45);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBksp
            // 
            this.btnBksp.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBksp.Location = new System.Drawing.Point(398, 193);
            this.btnBksp.Margin = new System.Windows.Forms.Padding(4);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(64, 45);
            this.btnBksp.TabIndex = 46;
            this.btnBksp.Text = "f";
            this.btnBksp.UseVisualStyleBackColor = true;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(398, 249);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(64, 98);
            this.btnEquals.TabIndex = 47;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 388);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDP);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btmMclr);
            this.Controls.Add(this.btnMrec);
            this.Controls.Add(this.btnMsub);
            this.Controls.Add(this.btnMadd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDisplay;
        internal System.Windows.Forms.Button btn1;
        internal System.Windows.Forms.Button btn2;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button btn4;
        internal System.Windows.Forms.Button btn5;
        internal System.Windows.Forms.Button btn6;
        internal System.Windows.Forms.Button btn7;
        internal System.Windows.Forms.Button btn8;
        internal System.Windows.Forms.Button btn9;
        internal System.Windows.Forms.Button btnMadd;
        internal System.Windows.Forms.Button btnMsub;
        internal System.Windows.Forms.Button btnMrec;
        internal System.Windows.Forms.Button btmMclr;
        internal System.Windows.Forms.Button btnDiv;
        internal System.Windows.Forms.Button btnMult;
        internal System.Windows.Forms.Button btnSub;
        internal System.Windows.Forms.Button btn0;
        internal System.Windows.Forms.Button btnDP;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnFormat;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnBksp;
        internal System.Windows.Forms.Button btnEquals;
    }
}

