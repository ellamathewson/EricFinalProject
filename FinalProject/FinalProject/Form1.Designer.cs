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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(253, 97);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(323, 54);
            this.title.TabIndex = 0;
            this.title.Text = "RIG · I · TONI";
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
            this.comboBox1.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salsa\'s",
            "Global Grille",
            "Crossroads",
            "Nathan\'s",
            "Brick City",
            "RITZ",
            "Gracie\'s",
            "Beanz",
            "College Grind",
            "Commons",
            "Midnight Oil",
            "Java Wally\'s",
            "Hissho Sushi",
            "Ctrl Alt DELi",
            "Artesano"});
            this.comboBox1.Location = new System.Drawing.Point(283, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 40);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // foodAnswer
            // 
            this.foodAnswer.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodAnswer.Location = new System.Drawing.Point(7, 234);
            this.foodAnswer.Name = "foodAnswer";
            this.foodAnswer.Size = new System.Drawing.Size(781, 207);
            this.foodAnswer.TabIndex = 3;
            this.foodAnswer.Text = "This is a program that calculates the wait time at restraunts all around RIT. Pic" +
    "k one in the dropdown menu!";
            this.foodAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRIT
            // 
            this.labelRIT.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelRIT.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRIT.ForeColor = System.Drawing.Color.Snow;
            this.labelRIT.Location = new System.Drawing.Point(-1, -5);
            this.labelRIT.Name = "labelRIT";
            this.labelRIT.Size = new System.Drawing.Size(800, 77);
            this.labelRIT.TabIndex = 4;
            this.labelRIT.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "WAHT TIME IS IT ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(440, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "RIT Dining Services ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

