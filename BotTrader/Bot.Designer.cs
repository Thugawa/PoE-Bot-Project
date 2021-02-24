namespace BotTrader
{
    partial class Interface
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.StartBot = new System.Windows.Forms.Button();
            this.StopBot = new System.Windows.Forms.Button();
            this.ConnectedAPI = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Label();
            this.unCheck1 = new System.Windows.Forms.PictureBox();
            this.unCheck2 = new System.Windows.Forms.PictureBox();
            this.unCheck3 = new System.Windows.Forms.PictureBox();
            this.Check3 = new System.Windows.Forms.PictureBox();
            this.Check2 = new System.Windows.Forms.PictureBox();
            this.Check1 = new System.Windows.Forms.PictureBox();
            this.Terminal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unCheck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unCheck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBot
            // 
            resources.ApplyResources(this.StartBot, "StartBot");
            this.StartBot.Name = "StartBot";
            this.StartBot.UseVisualStyleBackColor = true;
            this.StartBot.Click += new System.EventHandler(this.StartBot_Click);
            // 
            // StopBot
            // 
            this.StopBot.CausesValidation = false;
            resources.ApplyResources(this.StopBot, "StopBot");
            this.StopBot.Name = "StopBot";
            this.StopBot.UseVisualStyleBackColor = true;
            this.StopBot.Click += new System.EventHandler(this.StopBot_Click);
            // 
            // ConnectedAPI
            // 
            resources.ApplyResources(this.ConnectedAPI, "ConnectedAPI");
            this.ConnectedAPI.Name = "ConnectedAPI";
            // 
            // Logs
            // 
            resources.ApplyResources(this.Logs, "Logs");
            this.Logs.Name = "Logs";
            // 
            // Game
            // 
            resources.ApplyResources(this.Game, "Game");
            this.Game.Name = "Game";
            // 
            // unCheck1
            // 
            resources.ApplyResources(this.unCheck1, "unCheck1");
            this.unCheck1.Name = "unCheck1";
            this.unCheck1.TabStop = false;
            // 
            // unCheck2
            // 
            resources.ApplyResources(this.unCheck2, "unCheck2");
            this.unCheck2.Name = "unCheck2";
            this.unCheck2.TabStop = false;
            // 
            // unCheck3
            // 
            resources.ApplyResources(this.unCheck3, "unCheck3");
            this.unCheck3.Name = "unCheck3";
            this.unCheck3.TabStop = false;
            // 
            // Check3
            // 
            resources.ApplyResources(this.Check3, "Check3");
            this.Check3.Name = "Check3";
            this.Check3.TabStop = false;
            // 
            // Check2
            // 
            resources.ApplyResources(this.Check2, "Check2");
            this.Check2.Name = "Check2";
            this.Check2.TabStop = false;
            // 
            // Check1
            // 
            resources.ApplyResources(this.Check1, "Check1");
            this.Check1.Name = "Check1";
            this.Check1.TabStop = false;
            // 
            // Terminal
            // 
            resources.ApplyResources(this.Terminal, "Terminal");
            this.Terminal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Terminal.Name = "Terminal";
            // 
            // Interface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.Check2);
            this.Controls.Add(this.Check1);
            this.Controls.Add(this.unCheck3);
            this.Controls.Add(this.unCheck2);
            this.Controls.Add(this.unCheck1);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.ConnectedAPI);
            this.Controls.Add(this.StopBot);
            this.Controls.Add(this.StartBot);
            this.Name = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unCheck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unCheck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button StartBot;
        public System.Windows.Forms.Button StopBot;
        public System.Windows.Forms.Label ConnectedAPI;
        public System.Windows.Forms.Label Logs;
        public System.Windows.Forms.Label Game;
        public System.Windows.Forms.PictureBox unCheck1;
        public System.Windows.Forms.PictureBox unCheck2;
        public System.Windows.Forms.PictureBox unCheck3;
        public System.Windows.Forms.PictureBox Check3;
        public System.Windows.Forms.PictureBox Check2;
        public System.Windows.Forms.PictureBox Check1;
        public System.Windows.Forms.Label Terminal;

    }
}

