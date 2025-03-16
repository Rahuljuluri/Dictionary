namespace DD
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
            label1 = new Label();
            resultBox = new TextBox();
            insertBox = new TextBox();
            insertbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 27);
            label1.Name = "label1";
            label1.Size = new Size(276, 46);
            label1.TabIndex = 0;
            label1.Text = "My Dictionary";
            // 
            // resultBox
            // 
            resultBox.BackColor = Color.LightYellow;
            resultBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(34, 241);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(714, 178);
            resultBox.TabIndex = 1;
            // 
            // insertBox
            // 
            insertBox.BackColor = Color.AntiqueWhite;
            insertBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertBox.Location = new Point(112, 171);
            insertBox.Multiline = true;
            insertBox.Name = "insertBox";
            insertBox.Size = new Size(291, 42);
            insertBox.TabIndex = 2;
            // 
            // insertbtn
            // 
            insertbtn.BackColor = Color.FromArgb(255, 128, 128);
            insertbtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertbtn.Location = new Point(494, 171);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(117, 42);
            insertbtn.TabIndex = 3;
            insertbtn.Text = "Search";
            insertbtn.UseVisualStyleBackColor = false;
            insertbtn.Click += insertbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(insertbtn);
            Controls.Add(insertBox);
            Controls.Add(resultBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox resultBox;
        private TextBox insertBox;
        private Button insertbtn;
    }
}
