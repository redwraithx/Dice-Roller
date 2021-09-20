namespace Dice_Roller
{
    partial class Form1
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
            this.oneDiceRollButton = new System.Windows.Forms.Button();
            this.oneDiceRadioButton = new System.Windows.Forms.RadioButton();
            this.threeDiceRadioButton = new System.Windows.Forms.RadioButton();
            this.oneDiceLowNumber = new System.Windows.Forms.TextBox();
            this.oneDiceHighNumber = new System.Windows.Forms.TextBox();
            this.oneDiceLowNumberText = new System.Windows.Forms.Label();
            this.oneDiceHighNumberText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OneDiceRollGroup = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ThreeDiceRollGroup = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.threeDiceLowNumber3 = new System.Windows.Forms.TextBox();
            this.threeDiceHighNumber3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.threeDiceLowNumber2 = new System.Windows.Forms.TextBox();
            this.threeDiceHighNumber2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.threeDiceLowNumber1 = new System.Windows.Forms.TextBox();
            this.threeDiceHighNumber1 = new System.Windows.Forms.TextBox();
            this.threeDiceRollButton = new System.Windows.Forms.Button();
            this.threeDiceHighNumberText = new System.Windows.Forms.Label();
            this.threeDiceLowNumberText = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.threeDiceRollResultTextbox2 = new System.Windows.Forms.RichTextBox();
            this.oneDiceRollResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oneDiceRollResultTextbox = new System.Windows.Forms.RichTextBox();
            this.threeDiceRollResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.threeDiceRollResultTextbox1 = new System.Windows.Forms.RichTextBox();
            this.threeDiceRollResultTextbox3 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version10100081aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.OneDiceRollGroup.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.ThreeDiceRollGroup.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.oneDiceRollResultsGroupBox.SuspendLayout();
            this.threeDiceRollResultsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneDiceRollButton
            // 
            this.oneDiceRollButton.Location = new System.Drawing.Point(21, 126);
            this.oneDiceRollButton.Name = "oneDiceRollButton";
            this.oneDiceRollButton.Size = new System.Drawing.Size(176, 33);
            this.oneDiceRollButton.TabIndex = 0;
            this.oneDiceRollButton.Text = "Roll the Dice!";
            this.oneDiceRollButton.UseVisualStyleBackColor = true;
            this.oneDiceRollButton.UseWaitCursor = true;
            this.oneDiceRollButton.Click += new System.EventHandler(this.oneDiceRollButton_Click);
            // 
            // oneDiceRadioButton
            // 
            this.oneDiceRadioButton.AutoSize = true;
            this.oneDiceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDiceRadioButton.Location = new System.Drawing.Point(25, 30);
            this.oneDiceRadioButton.Name = "oneDiceRadioButton";
            this.oneDiceRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.oneDiceRadioButton.Size = new System.Drawing.Size(62, 21);
            this.oneDiceRadioButton.TabIndex = 1;
            this.oneDiceRadioButton.TabStop = true;
            this.oneDiceRadioButton.Text = "1 Dice";
            this.oneDiceRadioButton.UseCompatibleTextRendering = true;
            this.oneDiceRadioButton.UseVisualStyleBackColor = true;
            this.oneDiceRadioButton.CheckedChanged += new System.EventHandler(this.oneDiceRadioButton_CheckedChanged);
            // 
            // threeDiceRadioButton
            // 
            this.threeDiceRadioButton.AutoSize = true;
            this.threeDiceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDiceRadioButton.Location = new System.Drawing.Point(121, 30);
            this.threeDiceRadioButton.Name = "threeDiceRadioButton";
            this.threeDiceRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.threeDiceRadioButton.Size = new System.Drawing.Size(70, 20);
            this.threeDiceRadioButton.TabIndex = 2;
            this.threeDiceRadioButton.TabStop = true;
            this.threeDiceRadioButton.Text = "3 Dice";
            this.threeDiceRadioButton.UseVisualStyleBackColor = true;
            this.threeDiceRadioButton.CheckedChanged += new System.EventHandler(this.threeDiceRadioButton_CheckedChanged);
            // 
            // oneDiceLowNumber
            // 
            this.oneDiceLowNumber.Location = new System.Drawing.Point(6, 19);
            this.oneDiceLowNumber.Name = "oneDiceLowNumber";
            this.oneDiceLowNumber.Size = new System.Drawing.Size(62, 22);
            this.oneDiceLowNumber.TabIndex = 2;
            this.oneDiceLowNumber.Text = "1";
            this.oneDiceLowNumber.UseWaitCursor = true;
            // 
            // oneDiceHighNumber
            // 
            this.oneDiceHighNumber.Location = new System.Drawing.Point(6, 48);
            this.oneDiceHighNumber.Name = "oneDiceHighNumber";
            this.oneDiceHighNumber.Size = new System.Drawing.Size(62, 22);
            this.oneDiceHighNumber.TabIndex = 2;
            this.oneDiceHighNumber.Text = "6";
            this.oneDiceHighNumber.UseWaitCursor = true;
            this.oneDiceHighNumber.TextChanged += new System.EventHandler(this.oneDiceHighNumber_TextChanged);
            this.oneDiceHighNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oneDiceHighNumber_KeyPress);
            // 
            // oneDiceLowNumberText
            // 
            this.oneDiceLowNumberText.AutoSize = true;
            this.oneDiceLowNumberText.Location = new System.Drawing.Point(18, 51);
            this.oneDiceLowNumberText.Name = "oneDiceLowNumberText";
            this.oneDiceLowNumberText.Size = new System.Drawing.Size(97, 16);
            this.oneDiceLowNumberText.TabIndex = 3;
            this.oneDiceLowNumberText.Text = "Low Number:";
            this.oneDiceLowNumberText.UseWaitCursor = true;
            // 
            // oneDiceHighNumberText
            // 
            this.oneDiceHighNumberText.AutoSize = true;
            this.oneDiceHighNumberText.Location = new System.Drawing.Point(18, 80);
            this.oneDiceHighNumberText.Name = "oneDiceHighNumberText";
            this.oneDiceHighNumberText.Size = new System.Drawing.Size(102, 16);
            this.oneDiceHighNumberText.TabIndex = 3;
            this.oneDiceHighNumberText.Text = "High Number:";
            this.oneDiceHighNumberText.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.oneDiceRadioButton);
            this.groupBox1.Controls.Add(this.threeDiceRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(144, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "# of Dice";
            // 
            // OneDiceRollGroup
            // 
            this.OneDiceRollGroup.BackColor = System.Drawing.Color.DimGray;
            this.OneDiceRollGroup.Controls.Add(this.oneDiceRollButton);
            this.OneDiceRollGroup.Controls.Add(this.oneDiceHighNumberText);
            this.OneDiceRollGroup.Controls.Add(this.groupBox7);
            this.OneDiceRollGroup.Controls.Add(this.oneDiceLowNumberText);
            this.OneDiceRollGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneDiceRollGroup.Location = new System.Drawing.Point(144, 122);
            this.OneDiceRollGroup.Name = "OneDiceRollGroup";
            this.OneDiceRollGroup.Size = new System.Drawing.Size(217, 177);
            this.OneDiceRollGroup.TabIndex = 6;
            this.OneDiceRollGroup.TabStop = false;
            this.OneDiceRollGroup.Text = "One Dice Roll";
            this.OneDiceRollGroup.UseWaitCursor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox7.Controls.Add(this.oneDiceLowNumber);
            this.groupBox7.Controls.Add(this.oneDiceHighNumber);
            this.groupBox7.Location = new System.Drawing.Point(121, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(76, 81);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "1 Dice";
            this.groupBox7.UseWaitCursor = true;
            // 
            // ThreeDiceRollGroup
            // 
            this.ThreeDiceRollGroup.BackColor = System.Drawing.Color.DimGray;
            this.ThreeDiceRollGroup.CausesValidation = false;
            this.ThreeDiceRollGroup.Controls.Add(this.groupBox6);
            this.ThreeDiceRollGroup.Controls.Add(this.groupBox5);
            this.ThreeDiceRollGroup.Controls.Add(this.groupBox4);
            this.ThreeDiceRollGroup.Controls.Add(this.threeDiceRollButton);
            this.ThreeDiceRollGroup.Controls.Add(this.threeDiceHighNumberText);
            this.ThreeDiceRollGroup.Controls.Add(this.threeDiceLowNumberText);
            this.ThreeDiceRollGroup.Enabled = false;
            this.ThreeDiceRollGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeDiceRollGroup.Location = new System.Drawing.Point(50, 123);
            this.ThreeDiceRollGroup.Name = "ThreeDiceRollGroup";
            this.ThreeDiceRollGroup.Size = new System.Drawing.Size(403, 176);
            this.ThreeDiceRollGroup.TabIndex = 6;
            this.ThreeDiceRollGroup.TabStop = false;
            this.ThreeDiceRollGroup.Text = "One Dice Roll";
            this.ThreeDiceRollGroup.UseWaitCursor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox6.Controls.Add(this.threeDiceLowNumber3);
            this.groupBox6.Controls.Add(this.threeDiceHighNumber3);
            this.groupBox6.Location = new System.Drawing.Point(295, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(76, 81);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dice #3";
            this.groupBox6.UseWaitCursor = true;
            // 
            // threeDiceLowNumber3
            // 
            this.threeDiceLowNumber3.Location = new System.Drawing.Point(6, 21);
            this.threeDiceLowNumber3.Name = "threeDiceLowNumber3";
            this.threeDiceLowNumber3.Size = new System.Drawing.Size(62, 22);
            this.threeDiceLowNumber3.TabIndex = 2;
            this.threeDiceLowNumber3.Text = "1";
            this.threeDiceLowNumber3.UseWaitCursor = true;
            // 
            // threeDiceHighNumber3
            // 
            this.threeDiceHighNumber3.Location = new System.Drawing.Point(6, 49);
            this.threeDiceHighNumber3.Name = "threeDiceHighNumber3";
            this.threeDiceHighNumber3.Size = new System.Drawing.Size(62, 22);
            this.threeDiceHighNumber3.TabIndex = 2;
            this.threeDiceHighNumber3.Text = "6";
            this.threeDiceHighNumber3.UseWaitCursor = true;
            this.threeDiceHighNumber3.TextChanged += new System.EventHandler(this.threeDiceHighNumber3_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox5.Controls.Add(this.threeDiceLowNumber2);
            this.groupBox5.Controls.Add(this.threeDiceHighNumber2);
            this.groupBox5.Location = new System.Drawing.Point(213, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(76, 81);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dice #2";
            this.groupBox5.UseWaitCursor = true;
            // 
            // threeDiceLowNumber2
            // 
            this.threeDiceLowNumber2.Location = new System.Drawing.Point(6, 21);
            this.threeDiceLowNumber2.Name = "threeDiceLowNumber2";
            this.threeDiceLowNumber2.Size = new System.Drawing.Size(62, 22);
            this.threeDiceLowNumber2.TabIndex = 2;
            this.threeDiceLowNumber2.Text = "1";
            this.threeDiceLowNumber2.UseWaitCursor = true;
            // 
            // threeDiceHighNumber2
            // 
            this.threeDiceHighNumber2.Location = new System.Drawing.Point(6, 49);
            this.threeDiceHighNumber2.Name = "threeDiceHighNumber2";
            this.threeDiceHighNumber2.Size = new System.Drawing.Size(62, 22);
            this.threeDiceHighNumber2.TabIndex = 2;
            this.threeDiceHighNumber2.Text = "6";
            this.threeDiceHighNumber2.UseWaitCursor = true;
            this.threeDiceHighNumber2.TextChanged += new System.EventHandler(this.threeDiceHighNumber2_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox4.Controls.Add(this.threeDiceLowNumber1);
            this.groupBox4.Controls.Add(this.threeDiceHighNumber1);
            this.groupBox4.Location = new System.Drawing.Point(131, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(76, 81);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dice #1";
            this.groupBox4.UseWaitCursor = true;
            // 
            // threeDiceLowNumber1
            // 
            this.threeDiceLowNumber1.Location = new System.Drawing.Point(6, 21);
            this.threeDiceLowNumber1.Name = "threeDiceLowNumber1";
            this.threeDiceLowNumber1.Size = new System.Drawing.Size(62, 22);
            this.threeDiceLowNumber1.TabIndex = 2;
            this.threeDiceLowNumber1.Text = "1";
            this.threeDiceLowNumber1.UseWaitCursor = true;
            // 
            // threeDiceHighNumber1
            // 
            this.threeDiceHighNumber1.Location = new System.Drawing.Point(6, 49);
            this.threeDiceHighNumber1.Name = "threeDiceHighNumber1";
            this.threeDiceHighNumber1.Size = new System.Drawing.Size(62, 22);
            this.threeDiceHighNumber1.TabIndex = 2;
            this.threeDiceHighNumber1.Text = "6";
            this.threeDiceHighNumber1.UseWaitCursor = true;
            this.threeDiceHighNumber1.TextChanged += new System.EventHandler(this.threeDiceHighNumber1_TextChanged);
            // 
            // threeDiceRollButton
            // 
            this.threeDiceRollButton.Location = new System.Drawing.Point(26, 126);
            this.threeDiceRollButton.Name = "threeDiceRollButton";
            this.threeDiceRollButton.Size = new System.Drawing.Size(345, 33);
            this.threeDiceRollButton.TabIndex = 0;
            this.threeDiceRollButton.Text = "Roll the Dice!";
            this.threeDiceRollButton.UseVisualStyleBackColor = true;
            this.threeDiceRollButton.UseWaitCursor = true;
            this.threeDiceRollButton.Click += new System.EventHandler(this.threeDiceRollButton_Click);
            // 
            // threeDiceHighNumberText
            // 
            this.threeDiceHighNumberText.AutoSize = true;
            this.threeDiceHighNumberText.Location = new System.Drawing.Point(23, 82);
            this.threeDiceHighNumberText.Name = "threeDiceHighNumberText";
            this.threeDiceHighNumberText.Size = new System.Drawing.Size(102, 16);
            this.threeDiceHighNumberText.TabIndex = 3;
            this.threeDiceHighNumberText.Text = "High Number:";
            this.threeDiceHighNumberText.UseWaitCursor = true;
            // 
            // threeDiceLowNumberText
            // 
            this.threeDiceLowNumberText.AutoSize = true;
            this.threeDiceLowNumberText.Location = new System.Drawing.Point(23, 54);
            this.threeDiceLowNumberText.Name = "threeDiceLowNumberText";
            this.threeDiceLowNumberText.Size = new System.Drawing.Size(97, 16);
            this.threeDiceLowNumberText.TabIndex = 3;
            this.threeDiceLowNumberText.Text = "Low Number:";
            this.threeDiceLowNumberText.UseWaitCursor = true;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Purple;
            this.MessageLabel.Location = new System.Drawing.Point(88, 514);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(325, 25);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "[ Get Random # from 1 to  1- 99 ]";
            // 
            // threeDiceRollResultTextbox2
            // 
            this.threeDiceRollResultTextbox2.DetectUrls = false;
            this.threeDiceRollResultTextbox2.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDiceRollResultTextbox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.threeDiceRollResultTextbox2.Location = new System.Drawing.Point(143, 45);
            this.threeDiceRollResultTextbox2.MaxLength = 2;
            this.threeDiceRollResultTextbox2.Multiline = false;
            this.threeDiceRollResultTextbox2.Name = "threeDiceRollResultTextbox2";
            this.threeDiceRollResultTextbox2.ReadOnly = true;
            this.threeDiceRollResultTextbox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.threeDiceRollResultTextbox2.ShortcutsEnabled = false;
            this.threeDiceRollResultTextbox2.Size = new System.Drawing.Size(114, 121);
            this.threeDiceRollResultTextbox2.TabIndex = 7;
            this.threeDiceRollResultTextbox2.Text = "";
            this.threeDiceRollResultTextbox2.WordWrap = false;
            // 
            // oneDiceRollResultsGroupBox
            // 
            this.oneDiceRollResultsGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.oneDiceRollResultsGroupBox.Controls.Add(this.label4);
            this.oneDiceRollResultsGroupBox.Controls.Add(this.oneDiceRollResultTextbox);
            this.oneDiceRollResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDiceRollResultsGroupBox.Location = new System.Drawing.Point(144, 319);
            this.oneDiceRollResultsGroupBox.Name = "oneDiceRollResultsGroupBox";
            this.oneDiceRollResultsGroupBox.Size = new System.Drawing.Size(217, 178);
            this.oneDiceRollResultsGroupBox.TabIndex = 8;
            this.oneDiceRollResultsGroupBox.TabStop = false;
            this.oneDiceRollResultsGroupBox.Text = "One Dice Roll Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "One Dice";
            // 
            // oneDiceRollResultTextbox
            // 
            this.oneDiceRollResultTextbox.DetectUrls = false;
            this.oneDiceRollResultTextbox.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDiceRollResultTextbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.oneDiceRollResultTextbox.Location = new System.Drawing.Point(51, 46);
            this.oneDiceRollResultTextbox.MaxLength = 2;
            this.oneDiceRollResultTextbox.Multiline = false;
            this.oneDiceRollResultTextbox.Name = "oneDiceRollResultTextbox";
            this.oneDiceRollResultTextbox.ReadOnly = true;
            this.oneDiceRollResultTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.oneDiceRollResultTextbox.ShortcutsEnabled = false;
            this.oneDiceRollResultTextbox.Size = new System.Drawing.Size(114, 121);
            this.oneDiceRollResultTextbox.TabIndex = 7;
            this.oneDiceRollResultTextbox.Text = "";
            this.oneDiceRollResultTextbox.WordWrap = false;
            // 
            // threeDiceRollResultsGroupBox
            // 
            this.threeDiceRollResultsGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.threeDiceRollResultsGroupBox.Controls.Add(this.threeDiceRollResultTextbox2);
            this.threeDiceRollResultsGroupBox.Controls.Add(this.label3);
            this.threeDiceRollResultsGroupBox.Controls.Add(this.label2);
            this.threeDiceRollResultsGroupBox.Controls.Add(this.label1);
            this.threeDiceRollResultsGroupBox.Controls.Add(this.threeDiceRollResultTextbox1);
            this.threeDiceRollResultsGroupBox.Controls.Add(this.threeDiceRollResultTextbox3);
            this.threeDiceRollResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDiceRollResultsGroupBox.Location = new System.Drawing.Point(50, 321);
            this.threeDiceRollResultsGroupBox.Name = "threeDiceRollResultsGroupBox";
            this.threeDiceRollResultsGroupBox.Size = new System.Drawing.Size(405, 177);
            this.threeDiceRollResultsGroupBox.TabIndex = 8;
            this.threeDiceRollResultsGroupBox.TabStop = false;
            this.threeDiceRollResultsGroupBox.Text = "Three Dice Roll Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "3rd Dice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "2nd Dice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "1st Dice";
            // 
            // threeDiceRollResultTextbox1
            // 
            this.threeDiceRollResultTextbox1.DetectUrls = false;
            this.threeDiceRollResultTextbox1.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDiceRollResultTextbox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.threeDiceRollResultTextbox1.Location = new System.Drawing.Point(12, 44);
            this.threeDiceRollResultTextbox1.MaxLength = 2;
            this.threeDiceRollResultTextbox1.Multiline = false;
            this.threeDiceRollResultTextbox1.Name = "threeDiceRollResultTextbox1";
            this.threeDiceRollResultTextbox1.ReadOnly = true;
            this.threeDiceRollResultTextbox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.threeDiceRollResultTextbox1.ShortcutsEnabled = false;
            this.threeDiceRollResultTextbox1.Size = new System.Drawing.Size(114, 121);
            this.threeDiceRollResultTextbox1.TabIndex = 7;
            this.threeDiceRollResultTextbox1.Text = "";
            this.threeDiceRollResultTextbox1.WordWrap = false;
            // 
            // threeDiceRollResultTextbox3
            // 
            this.threeDiceRollResultTextbox3.DetectUrls = false;
            this.threeDiceRollResultTextbox3.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDiceRollResultTextbox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.threeDiceRollResultTextbox3.Location = new System.Drawing.Point(274, 45);
            this.threeDiceRollResultTextbox3.MaxLength = 2;
            this.threeDiceRollResultTextbox3.Multiline = false;
            this.threeDiceRollResultTextbox3.Name = "threeDiceRollResultTextbox3";
            this.threeDiceRollResultTextbox3.ReadOnly = true;
            this.threeDiceRollResultTextbox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.threeDiceRollResultTextbox3.ShortcutsEnabled = false;
            this.threeDiceRollResultTextbox3.Size = new System.Drawing.Size(114, 121);
            this.threeDiceRollResultTextbox3.TabIndex = 7;
            this.threeDiceRollResultTextbox3.Text = "";
            this.threeDiceRollResultTextbox3.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aboutToolStripMenuItem.Checked = true;
            this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version10100081aToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aboutToolStripMenuItem.Text = "Information";
            // 
            // version10100081aToolStripMenuItem
            // 
            this.version10100081aToolStripMenuItem.Name = "version10100081aToolStripMenuItem";
            this.version10100081aToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.version10100081aToolStripMenuItem.Text = "About";
            this.version10100081aToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(513, 545);
            this.Controls.Add(this.oneDiceRollResultsGroupBox);
            this.Controls.Add(this.threeDiceRollResultsGroupBox);
            this.Controls.Add(this.OneDiceRollGroup);
            this.Controls.Add(this.ThreeDiceRollGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller App by Brian Purdy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OneDiceRollGroup.ResumeLayout(false);
            this.OneDiceRollGroup.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ThreeDiceRollGroup.ResumeLayout(false);
            this.ThreeDiceRollGroup.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.oneDiceRollResultsGroupBox.ResumeLayout(false);
            this.oneDiceRollResultsGroupBox.PerformLayout();
            this.threeDiceRollResultsGroupBox.ResumeLayout(false);
            this.threeDiceRollResultsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneDiceRollButton;
        private System.Windows.Forms.RadioButton oneDiceRadioButton;
        private System.Windows.Forms.RadioButton threeDiceRadioButton;
        private System.Windows.Forms.TextBox oneDiceLowNumber;
        private System.Windows.Forms.TextBox oneDiceHighNumber;
        private System.Windows.Forms.Label oneDiceLowNumberText;
        private System.Windows.Forms.Label oneDiceHighNumberText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox OneDiceRollGroup;
        private System.Windows.Forms.GroupBox ThreeDiceRollGroup;
        private System.Windows.Forms.Button threeDiceRollButton;
        private System.Windows.Forms.TextBox threeDiceLowNumber1;
        private System.Windows.Forms.TextBox threeDiceHighNumber1;
        private System.Windows.Forms.Label threeDiceHighNumberText;
        private System.Windows.Forms.Label threeDiceLowNumberText;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox threeDiceLowNumber3;
        private System.Windows.Forms.TextBox threeDiceHighNumber3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox threeDiceLowNumber2;
        private System.Windows.Forms.TextBox threeDiceHighNumber2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox threeDiceRollResultTextbox2;
        private System.Windows.Forms.GroupBox oneDiceRollResultsGroupBox;
        private System.Windows.Forms.GroupBox threeDiceRollResultsGroupBox;
        private System.Windows.Forms.RichTextBox threeDiceRollResultTextbox1;
        private System.Windows.Forms.RichTextBox threeDiceRollResultTextbox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox oneDiceRollResultTextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version10100081aToolStripMenuItem;
    }
}

