namespace Task2
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
            userControlTimer1 = new UserControlTimer();
            clickButton1 = new ClickButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userControlTimer21 = new UserControlTimer2();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(7, 8);
            userControlTimer1.Margin = new Padding(1);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(74, 34);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // clickButton1
            // 
            clickButton1.Location = new Point(7, 84);
            clickButton1.Margin = new Padding(2);
            clickButton1.Name = "clickButton1";
            clickButton1.Size = new Size(117, 29);
            clickButton1.TabIndex = 2;
            clickButton1.Text = "Кнопка";
            clickButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 3;
            label1.Text = "- Cоставной элемент управления";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(324, 20);
            label2.TabIndex = 4;
            label2.Text = "- Специализированный элемент управления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(266, 20);
            label3.TabIndex = 5;
            label3.Text = "- Расширенный элемент управления";
            label3.Click += label3_Click;
            // 
            // userControlTimer21
            // 
            userControlTimer21.BackColor = Color.Transparent;
            userControlTimer21.ForeColor = Color.Red;
            userControlTimer21.Location = new Point(10, 45);
            userControlTimer21.Margin = new Padding(1);
            userControlTimer21.Name = "userControlTimer21";
            userControlTimer21.Size = new Size(74, 29);
            userControlTimer21.TabIndex = 1;
            userControlTimer21.Load += userControlTimer21_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(492, 281);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clickButton1);
            Controls.Add(userControlTimer1);
            Controls.Add(userControlTimer21);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private ClickButton clickButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private UserControlTimer2 userControlTimer21;
    }
}
