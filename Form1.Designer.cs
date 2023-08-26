namespace clickerGame2
{
    partial class Form1
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
            panel1 = new Panel();
            mainButton = new Button();
            hotbarSlotButton1 = new Button();
            hotbarSlotButton2 = new Button();
            hotbarSlotButton3 = new Button();
            hotbarSlotButton4 = new Button();
            hotbarSlotButton5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainButton);
            panel1.Location = new Point(320, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 211);
            panel1.TabIndex = 0;
            // 
            // mainButton
            // 
            mainButton.Location = new Point(78, 67);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(130, 89);
            mainButton.TabIndex = 0;
            mainButton.Text = "thing idk";
            mainButton.UseVisualStyleBackColor = true;
            // 
            // hotbarSlotButton1
            // 
            hotbarSlotButton1.Location = new Point(12, 12);
            hotbarSlotButton1.Name = "hotbarSlotButton1";
            hotbarSlotButton1.Size = new Size(71, 60);
            hotbarSlotButton1.TabIndex = 1;
            hotbarSlotButton1.Text = "HOtbar1";
            hotbarSlotButton1.UseVisualStyleBackColor = true;
            // 
            // hotbarSlotButton2
            // 
            hotbarSlotButton2.Location = new Point(89, 12);
            hotbarSlotButton2.Name = "hotbarSlotButton2";
            hotbarSlotButton2.Size = new Size(71, 60);
            hotbarSlotButton2.TabIndex = 2;
            hotbarSlotButton2.Text = "Hotbar2";
            hotbarSlotButton2.UseVisualStyleBackColor = true;
            // 
            // hotbarSlotButton3
            // 
            hotbarSlotButton3.Location = new Point(166, 12);
            hotbarSlotButton3.Name = "hotbarSlotButton3";
            hotbarSlotButton3.Size = new Size(71, 60);
            hotbarSlotButton3.TabIndex = 3;
            hotbarSlotButton3.Text = "Hotbar3";
            hotbarSlotButton3.UseVisualStyleBackColor = true;
            // 
            // hotbarSlotButton4
            // 
            hotbarSlotButton4.Location = new Point(243, 12);
            hotbarSlotButton4.Name = "hotbarSlotButton4";
            hotbarSlotButton4.Size = new Size(71, 60);
            hotbarSlotButton4.TabIndex = 4;
            hotbarSlotButton4.Text = "Hotbar4";
            hotbarSlotButton4.UseVisualStyleBackColor = true;
            // 
            // hotbarSlotButton5
            // 
            hotbarSlotButton5.Location = new Point(320, 12);
            hotbarSlotButton5.Name = "hotbarSlotButton5";
            hotbarSlotButton5.Size = new Size(71, 60);
            hotbarSlotButton5.TabIndex = 5;
            hotbarSlotButton5.Text = "hotbar5?";
            hotbarSlotButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 705);
            Controls.Add(hotbarSlotButton5);
            Controls.Add(hotbarSlotButton4);
            Controls.Add(hotbarSlotButton3);
            Controls.Add(hotbarSlotButton2);
            Controls.Add(hotbarSlotButton1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainButton;
        private Button hotbarSlotButton1;
        private Button hotbarSlotButton2;
        private Button hotbarSlotButton3;
        private Button hotbarSlotButton4;
        private Button hotbarSlotButton5;
    }
}