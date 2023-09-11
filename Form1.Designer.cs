namespace Account_Registration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            StudentDesign = new TextBox();
            LastNameDesign = new TextBox();
            FirstNameDesign = new TextBox();
            MiddleNameDesign = new TextBox();
            AgeDesign = new TextBox();
            ContactNoDesign = new TextBox();
            AddressDesign = new RichTextBox();
            button1 = new Button();
            ProgramDesign = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 40);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Program";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 121);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 121);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 3;
            label4.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 121);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 4;
            label5.Text = "Middle name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 211);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 202);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 319);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            // 
            // StudentDesign
            // 
            StudentDesign.Location = new Point(30, 77);
            StudentDesign.Name = "StudentDesign";
            StudentDesign.Size = new Size(150, 31);
            StudentDesign.TabIndex = 8;
            // 
            // LastNameDesign
            // 
            LastNameDesign.Location = new Point(30, 149);
            LastNameDesign.Name = "LastNameDesign";
            LastNameDesign.Size = new Size(150, 31);
            LastNameDesign.TabIndex = 9;
            // 
            // FirstNameDesign
            // 
            FirstNameDesign.Location = new Point(262, 149);
            FirstNameDesign.Name = "FirstNameDesign";
            FirstNameDesign.Size = new Size(150, 31);
            FirstNameDesign.TabIndex = 10;
            // 
            // MiddleNameDesign
            // 
            MiddleNameDesign.Location = new Point(520, 149);
            MiddleNameDesign.Name = "MiddleNameDesign";
            MiddleNameDesign.Size = new Size(150, 31);
            MiddleNameDesign.TabIndex = 11;
            MiddleNameDesign.TextChanged += textBox4_TextChanged;
            // 
            // AgeDesign
            // 
            AgeDesign.Location = new Point(30, 239);
            AgeDesign.Name = "AgeDesign";
            AgeDesign.Size = new Size(150, 31);
            AgeDesign.TabIndex = 12;
            // 
            // ContactNoDesign
            // 
            ContactNoDesign.Location = new Point(262, 239);
            ContactNoDesign.Name = "ContactNoDesign";
            ContactNoDesign.Size = new Size(150, 31);
            ContactNoDesign.TabIndex = 13;
            // 
            // AddressDesign
            // 
            AddressDesign.Location = new Point(30, 365);
            AddressDesign.Name = "AddressDesign";
            AddressDesign.Size = new Size(626, 118);
            AddressDesign.TabIndex = 14;
            AddressDesign.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(300, 538);
            button1.Name = "button1";
            button1.Size = new Size(112, 31);
            button1.TabIndex = 15;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProgramDesign
            // 
            ProgramDesign.FormattingEnabled = true;
            ProgramDesign.Location = new Point(262, 77);
            ProgramDesign.Name = "ProgramDesign";
            ProgramDesign.Size = new Size(150, 33);
            ProgramDesign.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(ProgramDesign);
            Controls.Add(button1);
            Controls.Add(AddressDesign);
            Controls.Add(ContactNoDesign);
            Controls.Add(AgeDesign);
            Controls.Add(MiddleNameDesign);
            Controls.Add(FirstNameDesign);
            Controls.Add(LastNameDesign);
            Controls.Add(StudentDesign);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frm Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox StudentDesign;
        private TextBox LastNameDesign;
        private TextBox FirstNameDesign;
        private TextBox MiddleNameDesign;
        private TextBox AgeDesign;
        private TextBox ContactNoDesign;
        private RichTextBox AddressDesign;
        private Button button1;
        private ComboBox ProgramDesign;
    }
}