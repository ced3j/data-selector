namespace BerGEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(29, 42);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(306, 227);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(393, 42);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(306, 227);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(301, 287);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 30);
            maskedTextBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(316, 338);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(490, 287);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 5;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 6;
            label1.Text = "Primary Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 9);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 7;
            label2.Text = "Secondary Data";
            // 
            // button4
            // 
            button4.Location = new Point(113, 287);
            button4.Name = "button4";
            button4.Size = new Size(136, 28);
            button4.TabIndex = 8;
            button4.Text = "Load Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(738, 393);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerGEN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Button button4;
    }
}
