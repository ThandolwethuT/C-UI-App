namespace C__UI_App
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(-7, 54);
            label1.Name = "label1";
            label1.Size = new Size(531, 50);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Favorite Phrase/ Word: ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Violet;
            textBox1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(512, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(668, 50);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(903, 277);
            button1.Name = "button1";
            button1.Size = new Size(152, 94);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.HotPink;
            button2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(903, 418);
            button2.Name = "button2";
            button2.Size = new Size(152, 94);
            button2.TabIndex = 2;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.HotPink;
            button3.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(903, 146);
            button3.Name = "button3";
            button3.Size = new Size(152, 94);
            button3.TabIndex = 2;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = Color.MistyRose;
            listBox1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 43;
            listBox1.Location = new Point(29, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(733, 520);
            listBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.BackColor = Color.HotPink;
            button4.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(903, 556);
            button4.Name = "button4";
            button4.Size = new Size(152, 89);
            button4.TabIndex = 4;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1230, 657);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fav Word/Phrase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
    }
}
