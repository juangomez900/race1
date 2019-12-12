namespace Race_game_1
{
    partial class start_of_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_of_game));
            this.mainmenu = new System.Windows.Forms.Button();
            this.juangomez = new System.Windows.Forms.PictureBox();
            this.gameabout = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.juangomez)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenu.ForeColor = System.Drawing.Color.Black;
            this.mainmenu.Location = new System.Drawing.Point(592, 344);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(324, 124);
            this.mainmenu.TabIndex = 12;
            this.mainmenu.Text = "Race";
            this.mainmenu.UseVisualStyleBackColor = true;
            this.mainmenu.UseWaitCursor = true;
            this.mainmenu.Click += new System.EventHandler(this.mainmenu_Click);
            // 
            // juangomez
            // 
            this.juangomez.Image = ((System.Drawing.Image)(resources.GetObject("juangomez.Image")));
            this.juangomez.Location = new System.Drawing.Point(260, 12);
            this.juangomez.Name = "juangomez";
            this.juangomez.Size = new System.Drawing.Size(375, 269);
            this.juangomez.TabIndex = 13;
            this.juangomez.TabStop = false;
            // 
            // gameabout
            // 
            this.gameabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameabout.ForeColor = System.Drawing.Color.Black;
            this.gameabout.Location = new System.Drawing.Point(12, 344);
            this.gameabout.Name = "gameabout";
            this.gameabout.Size = new System.Drawing.Size(324, 124);
            this.gameabout.TabIndex = 14;
            this.gameabout.Text = "What this game is about";
            this.gameabout.UseVisualStyleBackColor = true;
            this.gameabout.UseWaitCursor = true;
            this.gameabout.Click += new System.EventHandler(this.gameabout_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 551);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Where i found how to make this game";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(359, 551);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(134, 13);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "cyprus high school website";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(730, 551);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(103, 13);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "My youtube channel";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_of_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gameabout);
            this.Controls.Add(this.juangomez);
            this.Controls.Add(this.mainmenu);
            this.Name = "start_of_game";
            this.Text = "start_of_game";
            ((System.ComponentModel.ISupportInitialize)(this.juangomez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainmenu;
        private System.Windows.Forms.PictureBox juangomez;
        private System.Windows.Forms.Button gameabout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button button1;
    }
}