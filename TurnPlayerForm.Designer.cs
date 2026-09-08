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
            label6 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            richTextBox2 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(112, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 210);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Blaster, the Fire Dragon's Turn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "HP: 15";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(43, 64);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 104);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 144);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(499, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opponent: Clive";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 47);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 0;
            label2.Text = "Tidal, the Ice Dragon";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 1;
            label3.Text = "HP: 10";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 144);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox2);
            groupBox3.Location = new Point(112, 351);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(931, 338);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Battle Log";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 60);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(919, 272);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // TurnPlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 741);
            Controls.Add(groupBox3);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Name = "TurnPlayerForm";
            Text = "TurnPlayerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private GroupBox groupBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private RichTextBox richTextBox2;
    }
}