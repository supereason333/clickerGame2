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
            inventoryListBox = new ListBox();
            testingPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            testInvItemIDSelector = new NumericUpDown();
            testInvSlotSelecter = new NumericUpDown();
            testInvRMButton = new Button();
            testInvAddButton = new Button();
            panel1.SuspendLayout();
            testingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)testInvItemIDSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testInvSlotSelecter).BeginInit();
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
            mainButton.Click += mainButton_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 15;
            inventoryListBox.Location = new Point(12, 23);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(193, 364);
            inventoryListBox.TabIndex = 6;
            // 
            // testingPanel
            // 
            testingPanel.Controls.Add(label2);
            testingPanel.Controls.Add(label1);
            testingPanel.Controls.Add(testInvItemIDSelector);
            testingPanel.Controls.Add(testInvSlotSelecter);
            testingPanel.Controls.Add(testInvRMButton);
            testingPanel.Controls.Add(testInvAddButton);
            testingPanel.Location = new Point(222, 25);
            testingPanel.Name = "testingPanel";
            testingPanel.Size = new Size(200, 171);
            testingPanel.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 48);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 19);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 4;
            label1.Text = "Slot";
            // 
            // testInvItemIDSelector
            // 
            testInvItemIDSelector.Location = new Point(18, 46);
            testInvItemIDSelector.Name = "testInvItemIDSelector";
            testInvItemIDSelector.Size = new Size(120, 23);
            testInvItemIDSelector.TabIndex = 3;
            // 
            // testInvSlotSelecter
            // 
            testInvSlotSelecter.Location = new Point(18, 17);
            testInvSlotSelecter.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            testInvSlotSelecter.Name = "testInvSlotSelecter";
            testInvSlotSelecter.Size = new Size(120, 23);
            testInvSlotSelecter.TabIndex = 2;
            // 
            // testInvRMButton
            // 
            testInvRMButton.Location = new Point(18, 119);
            testInvRMButton.Name = "testInvRMButton";
            testInvRMButton.Size = new Size(75, 23);
            testInvRMButton.TabIndex = 1;
            testInvRMButton.Text = "Remove";
            testInvRMButton.UseVisualStyleBackColor = true;
            testInvRMButton.Click += testInvRMButton_Click;
            // 
            // testInvAddButton
            // 
            testInvAddButton.Location = new Point(18, 90);
            testInvAddButton.Name = "testInvAddButton";
            testInvAddButton.Size = new Size(75, 23);
            testInvAddButton.TabIndex = 0;
            testInvAddButton.Text = "Add";
            testInvAddButton.UseVisualStyleBackColor = true;
            testInvAddButton.Click += testInvAddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 705);
            Controls.Add(testingPanel);
            Controls.Add(inventoryListBox);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            testingPanel.ResumeLayout(false);
            testingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)testInvItemIDSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)testInvSlotSelecter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button mainButton;
        private ListBox inventoryListBox;
        private Panel testingPanel;
        private Label label2;
        private Label label1;
        private NumericUpDown testInvItemIDSelector;
        private NumericUpDown testInvSlotSelecter;
        private Button testInvRMButton;
        private Button testInvAddButton;
    }
}