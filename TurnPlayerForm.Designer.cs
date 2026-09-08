namespace DragonBattle
{
    partial class TurnPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnPlayerForm));
            lblTitle = new Label();
            grpPlayer1 = new GroupBox();
            lblP1Name = new Label();
            txtP1Name = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            grpPlayer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(88, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DRAGON BATTLE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpPlayer1
            // 
            grpPlayer1.Controls.Add(button1);
            grpPlayer1.Controls.Add(radioButton4);
            grpPlayer1.Controls.Add(radioButton3);
            grpPlayer1.Controls.Add(radioButton2);
            grpPlayer1.Controls.Add(radioButton1);
            grpPlayer1.Controls.Add(label2);
            grpPlayer1.Controls.Add(textBox1);
            grpPlayer1.Controls.Add(label1);
            grpPlayer1.Controls.Add(txtP1Name);
            grpPlayer1.Controls.Add(lblP1Name);
            grpPlayer1.Location = new Point(78, 94);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Size = new Size(376, 324);
            grpPlayer1.TabIndex = 1;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "PLAYER 1";
            grpPlayer1.Enter += grpPlayer1_Enter;
            // 
            // lblP1Name
            // 
            lblP1Name.AutoSize = true;
            lblP1Name.Location = new Point(10, 27);
            lblP1Name.Name = "lblP1Name";
            lblP1Name.Size = new Size(115, 25);
            lblP1Name.TabIndex = 0;
            lblP1Name.Text = "Player Name:";
            // 
            // txtP1Name
            // 
            txtP1Name.Location = new Point(220, 30);
            txtP1Name.Name = "txtP1Name";
            txtP1Name.Size = new Size(150, 31);
            txtP1Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 64);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 2;
            label1.Text = "Dragon Name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(540, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 324);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "PLAYER 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 98);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 4;
            label2.Text = "Choose Your Dragon:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 126);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(124, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ice Dragon";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 161);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(130, 29);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fire Dragon";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 196);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 29);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Wind Dragon";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(10, 231);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(142, 29);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Earth Dragon";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(81, 291);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 10;
            label3.Text = "Player Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 10;
            label4.Text = "Dragon Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 98);
            label5.Name = "label5";
            label5.Size = new Size(181, 25);
            label5.TabIndex = 10;
            label5.Text = "Choose Your Dragon:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 126);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(124, 29);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "Ice Dragon";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 161);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(130, 29);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "Fire Dragon";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 196);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(144, 29);
            radioButton7.TabIndex = 10;
            radioButton7.TabStop = true;
            radioButton7.Text = "Wind Dragon";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(8, 231);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(142, 29);
            radioButton8.TabIndex = 10;
            radioButton8.TabStop = true;
            radioButton8.Text = "Earth Dragon";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(125, 266);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(88, 462);
            button3.Name = "button3";
            button3.Size = new Size(835, 34);
            button3.TabIndex = 3;
            button3.Text = "Start Game";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1031, 94);
            label7.Name = "label7";
            label7.Size = new Size(219, 600);
            label7.TabIndex = 5;
            label7.Text = resources.GetString("label7.Text");
            // 
            // TurnPlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 741);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(grpPlayer1);
            Controls.Add(lblTitle);
            Name = "TurnPlayerForm";
            Text = "TurnPlayerForm";
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpPlayer1;
        private Label lblP1Name;
        private Label label1;
        private TextBox txtP1Name;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private Button button1;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label6;
        private Label label7;
    }
}