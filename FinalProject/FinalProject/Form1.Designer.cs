namespace FinalProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.foodAnswer = new System.Windows.Forms.Label();
            this.labelRIT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(158, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(469, 65);
            this.title.TabIndex = 0;
            this.title.Text = "Line Length Program";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Salsa\'s",
            "The Grind",
            "Control Alt Deli",
            "Commons",
            "Crossroads",
            "Bytes",
            "Brick City",
            "RITZ",
            "Beanz",
            "Ben and Jerry\'s",
            "Nathans",
            "Gracie\'s",
            "Sol\'s Underground",
            "Midnight Oil",
            "The Cantina",
            "USB",
            "Java Wally\'s"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salsa\'s",
            "Cantina and Grill",
            "Crossroads",
            "Nathan\'s",
            "Brick City",
            "RITZ",
            "Gracie\'s",
            "Beanz",
            "College Grind",
            "Commons",
            "Midnight Oil",
            "Java Wally\'s"});
            this.comboBox1.Location = new System.Drawing.Point(279, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // foodAnswer
            // 
            this.foodAnswer.AutoSize = true;
            this.foodAnswer.Location = new System.Drawing.Point(188, 253);
            this.foodAnswer.Name = "foodAnswer";
            this.foodAnswer.Size = new System.Drawing.Size(0, 13);
            this.foodAnswer.TabIndex = 3;
            // 
            // labelRIT
            // 
            this.labelRIT.AutoSize = true;
            this.labelRIT.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRIT.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelRIT.Location = new System.Drawing.Point(12, 9);
            this.labelRIT.Name = "labelRIT";
            this.labelRIT.Size = new System.Drawing.Size(317, 43);
            this.labelRIT.TabIndex = 4;
            this.labelRIT.Text = "RIT Dining Services";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "WAHT TIME IS IT ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(444, 362);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(37, 13);
            this.debug.TabIndex = 6;
            this.debug.Text = "label2";
            this.debug.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRIT);
            this.Controls.Add(this.foodAnswer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Line Length at RIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label foodAnswer;
        private System.Windows.Forms.Label labelRIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label debug;
    }
}

