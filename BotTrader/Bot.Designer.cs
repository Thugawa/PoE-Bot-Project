
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
        private void InitializeComponent()
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
            // 
            // StopBot
            // 
            this.StopBot.CausesValidation = false;
            resources.ApplyResources(this.StopBot, "StopBot");
            this.StopBot.Name = "StopBot";
            this.StopBot.TabStop = false;
            this.StopBot.UseVisualStyleBackColor = true;
            // 
            // ConnectedAPI
            // 
            resources.ApplyResources(this.ConnectedAPI, "ConnectedAPI");
            this.ConnectedAPI.Name = "ConnectedAPI";
            this.ConnectedAPI.Click += new System.EventHandler(this.label1_Click);
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
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // unCheck1
            // 
            resources.ApplyResources(this.unCheck1, "unCheck1");
            this.unCheck1.Name = "unCheck1";
            this.unCheck1.TabStop = false;
            this.unCheck1.Click += new System.EventHandler(this.Check1_Click);
            // 
            // unCheck2
            // 
            resources.ApplyResources(this.unCheck2, "unCheck2");
            this.unCheck2.Name = "unCheck2";
            this.unCheck2.TabStop = false;
            this.unCheck2.Click += new System.EventHandler(this.unCheck2_Click);
            // 
            // unCheck3
            // 
            resources.ApplyResources(this.unCheck3, "unCheck3");
            this.unCheck3.Name = "unCheck3";
            this.unCheck3.TabStop = false;
            this.unCheck3.Click += new System.EventHandler(this.unCheck3_Click);
            // 
            // Check3
            // 
            resources.ApplyResources(this.Check3, "Check3");
            this.Check3.Name = "Check3";
            this.Check3.TabStop = false;
            this.Check3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Check2
            // 
            resources.ApplyResources(this.Check2, "Check2");
            this.Check2.Name = "Check2";
            this.Check2.TabStop = false;
            this.Check2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Check1
            // 
            resources.ApplyResources(this.Check1, "Check1");
            this.Check1.Name = "Check1";
            this.Check1.TabStop = false;
            this.Check1.Click += new System.EventHandler(this.pictureBox3_Click);
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

        private System.Windows.Forms.Button StartBot;
        private System.Windows.Forms.Button StopBot;
        private System.Windows.Forms.Label ConnectedAPI;
        private System.Windows.Forms.Label Logs;
        private System.Windows.Forms.Label Game;
        private System.Windows.Forms.PictureBox unCheck1;
        private System.Windows.Forms.PictureBox unCheck2;
        private System.Windows.Forms.PictureBox unCheck3;
        private System.Windows.Forms.PictureBox Check3;
        private System.Windows.Forms.PictureBox Check2;
        private System.Windows.Forms.PictureBox Check1;
        private System.Windows.Forms.Label Terminal;
    }
}

