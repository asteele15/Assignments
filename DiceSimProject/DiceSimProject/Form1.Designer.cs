namespace DiceSimProject
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
        public void InitializeComponent()
        {
            this.Roll = new System.Windows.Forms.Button();
            this.oneDi = new System.Windows.Forms.RadioButton();
            this.twoDice = new System.Windows.Forms.RadioButton();
            this.threeDice = new System.Windows.Forms.RadioButton();
            this.fourDice = new System.Windows.Forms.RadioButton();
            this.fiveDice = new System.Windows.Forms.RadioButton();
            this.sixDice = new System.Windows.Forms.RadioButton();
            this.numberDice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oneResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sixResult = new System.Windows.Forms.Label();
            this.fiveResult = new System.Windows.Forms.Label();
            this.fourResult = new System.Windows.Forms.Label();
            this.threeResult = new System.Windows.Forms.Label();
            this.twoResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numberDice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(174, 192);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 1;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // oneDi
            // 
            this.oneDi.AutoSize = true;
            this.oneDi.Location = new System.Drawing.Point(6, 31);
            this.oneDi.Name = "oneDi";
            this.oneDi.Size = new System.Drawing.Size(31, 17);
            this.oneDi.TabIndex = 2;
            this.oneDi.TabStop = true;
            this.oneDi.Text = "1";
            this.oneDi.UseVisualStyleBackColor = true;
            // 
            // twoDice
            // 
            this.twoDice.AutoSize = true;
            this.twoDice.Location = new System.Drawing.Point(6, 54);
            this.twoDice.Name = "twoDice";
            this.twoDice.Size = new System.Drawing.Size(31, 17);
            this.twoDice.TabIndex = 3;
            this.twoDice.TabStop = true;
            this.twoDice.Text = "2";
            this.twoDice.UseVisualStyleBackColor = true;
            // 
            // threeDice
            // 
            this.threeDice.AutoSize = true;
            this.threeDice.Location = new System.Drawing.Point(6, 77);
            this.threeDice.Name = "threeDice";
            this.threeDice.Size = new System.Drawing.Size(31, 17);
            this.threeDice.TabIndex = 4;
            this.threeDice.TabStop = true;
            this.threeDice.Text = "3";
            this.threeDice.UseVisualStyleBackColor = true;
            // 
            // fourDice
            // 
            this.fourDice.AutoSize = true;
            this.fourDice.Location = new System.Drawing.Point(97, 31);
            this.fourDice.Name = "fourDice";
            this.fourDice.Size = new System.Drawing.Size(31, 17);
            this.fourDice.TabIndex = 5;
            this.fourDice.TabStop = true;
            this.fourDice.Text = "4";
            this.fourDice.UseVisualStyleBackColor = true;
            // 
            // fiveDice
            // 
            this.fiveDice.AutoSize = true;
            this.fiveDice.Location = new System.Drawing.Point(97, 54);
            this.fiveDice.Name = "fiveDice";
            this.fiveDice.Size = new System.Drawing.Size(31, 17);
            this.fiveDice.TabIndex = 6;
            this.fiveDice.TabStop = true;
            this.fiveDice.Text = "5";
            this.fiveDice.UseVisualStyleBackColor = true;
            // 
            // sixDice
            // 
            this.sixDice.AutoSize = true;
            this.sixDice.Location = new System.Drawing.Point(97, 77);
            this.sixDice.Name = "sixDice";
            this.sixDice.Size = new System.Drawing.Size(31, 17);
            this.sixDice.TabIndex = 7;
            this.sixDice.TabStop = true;
            this.sixDice.Text = "6";
            this.sixDice.UseVisualStyleBackColor = true;
            // 
            // numberDice
            // 
            this.numberDice.Controls.Add(this.sixDice);
            this.numberDice.Controls.Add(this.fiveDice);
            this.numberDice.Controls.Add(this.oneDi);
            this.numberDice.Controls.Add(this.twoDice);
            this.numberDice.Controls.Add(this.threeDice);
            this.numberDice.Controls.Add(this.fourDice);
            this.numberDice.Location = new System.Drawing.Point(46, 58);
            this.numberDice.Name = "numberDice";
            this.numberDice.Size = new System.Drawing.Size(203, 115);
            this.numberDice.TabIndex = 8;
            this.numberDice.TabStop = false;
            this.numberDice.Text = "Number of Dice";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many dice would you like to role? ";
            // 
            // oneResult
            // 
            this.oneResult.AutoSize = true;
            this.oneResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oneResult.Location = new System.Drawing.Point(19, 25);
            this.oneResult.Name = "oneResult";
            this.oneResult.Size = new System.Drawing.Size(39, 15);
            this.oneResult.TabIndex = 9;
            this.oneResult.Text = "Roll1: ";
            this.oneResult.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sixResult);
            this.groupBox2.Controls.Add(this.fiveResult);
            this.groupBox2.Controls.Add(this.fourResult);
            this.groupBox2.Controls.Add(this.threeResult);
            this.groupBox2.Controls.Add(this.twoResult);
            this.groupBox2.Controls.Add(this.oneResult);
            this.groupBox2.Location = new System.Drawing.Point(287, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 236);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // sixResult
            // 
            this.sixResult.AutoSize = true;
            this.sixResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sixResult.Location = new System.Drawing.Point(19, 192);
            this.sixResult.Name = "sixResult";
            this.sixResult.Size = new System.Drawing.Size(39, 15);
            this.sixResult.TabIndex = 14;
            this.sixResult.Text = "Roll6: ";
            this.sixResult.Visible = false;
            // 
            // fiveResult
            // 
            this.fiveResult.AutoSize = true;
            this.fiveResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fiveResult.Location = new System.Drawing.Point(19, 159);
            this.fiveResult.Name = "fiveResult";
            this.fiveResult.Size = new System.Drawing.Size(39, 15);
            this.fiveResult.TabIndex = 13;
            this.fiveResult.Text = "Roll5: ";
            this.fiveResult.Visible = false;
            // 
            // fourResult
            // 
            this.fourResult.AutoSize = true;
            this.fourResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourResult.Location = new System.Drawing.Point(19, 124);
            this.fourResult.Name = "fourResult";
            this.fourResult.Size = new System.Drawing.Size(39, 15);
            this.fourResult.TabIndex = 12;
            this.fourResult.Text = "Roll4: ";
            this.fourResult.Visible = false;
            // 
            // threeResult
            // 
            this.threeResult.AutoSize = true;
            this.threeResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.threeResult.Location = new System.Drawing.Point(19, 89);
            this.threeResult.Name = "threeResult";
            this.threeResult.Size = new System.Drawing.Size(39, 15);
            this.threeResult.TabIndex = 11;
            this.threeResult.Text = "Roll3: ";
            this.threeResult.Visible = false;
            // 
            // twoResult
            // 
            this.twoResult.AutoSize = true;
            this.twoResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.twoResult.Location = new System.Drawing.Point(19, 56);
            this.twoResult.Name = "twoResult";
            this.twoResult.Size = new System.Drawing.Size(39, 15);
            this.twoResult.TabIndex = 10;
            this.twoResult.Text = "Roll2: ";
            this.twoResult.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberDice);
            this.Controls.Add(this.Roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.numberDice.ResumeLayout(false);
            this.numberDice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.RadioButton oneDi;
        private System.Windows.Forms.RadioButton twoDice;
        private System.Windows.Forms.RadioButton threeDice;
        private System.Windows.Forms.RadioButton fourDice;
        private System.Windows.Forms.RadioButton fiveDice;
        private System.Windows.Forms.RadioButton sixDice;
        private System.Windows.Forms.GroupBox numberDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oneResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sixResult;
        private System.Windows.Forms.Label fiveResult;
        private System.Windows.Forms.Label fourResult;
        private System.Windows.Forms.Label threeResult;
        private System.Windows.Forms.Label twoResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

