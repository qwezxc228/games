namespace games
{
    partial class Fight
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
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 177);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 2;
            label3.Text = "Sword: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 220);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 3;
            label2.Text = "Money: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 139);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 4;
            label5.Text = "Armor: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 108);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 5;
            label6.Text = "HP: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 78);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 6;
            label4.Text = "Damage: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 7;
            label1.Text = "name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(500, 179);
            label10.Name = "label10";
            label10.Size = new Size(81, 30);
            label10.TabIndex = 12;
            label10.Text = "Sword: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(500, 141);
            label13.Name = "label13";
            label13.Size = new Size(82, 30);
            label13.TabIndex = 13;
            label13.Text = "Armor: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(498, 110);
            label14.Name = "label14";
            label14.Size = new Size(45, 30);
            label14.TabIndex = 14;
            label14.Text = "HP:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(498, 80);
            label15.Name = "label15";
            label15.Size = new Size(102, 30);
            label15.TabIndex = 15;
            label15.Text = "Damage: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(500, 46);
            label16.Name = "label16";
            label16.Size = new Size(150, 30);
            label16.TabIndex = 17;
            label16.Text = "Name: Zombie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(325, 129);
            label7.Name = "label7";
            label7.Size = new Size(57, 45);
            label7.TabIndex = 11;
            label7.Text = "VS";
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Location = new Point(692, 378);
            button2.Name = "button2";
            button2.Size = new Size(96, 60);
            button2.TabIndex = 19;
            button2.Text = "назад";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Fight";
            Text = "Fight";
            Load += Fight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label7;
        private Button button2;
    }
}