
namespace RPS
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
            this.components = new System.ComponentModel.Container();
            this.buttonrock = new System.Windows.Forms.Button();
            this.buttonpaper = new System.Windows.Forms.Button();
            this.buttonscissors = new System.Windows.Forms.Button();
            this.buttonrestart = new System.Windows.Forms.Button();
            this.pictureplayer = new System.Windows.Forms.PictureBox();
            this.picturecpu = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Label();
            this.textscore = new System.Windows.Forms.Label();
            this.textcountdown = new System.Windows.Forms.Label();
            this.textrounds = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecpu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonrock
            // 
            this.buttonrock.Location = new System.Drawing.Point(12, 389);
            this.buttonrock.Name = "buttonrock";
            this.buttonrock.Size = new System.Drawing.Size(125, 30);
            this.buttonrock.TabIndex = 0;
            this.buttonrock.Text = "Rock";
            this.buttonrock.UseVisualStyleBackColor = true;
            this.buttonrock.Click += new System.EventHandler(this.buttonrock_Click);
            // 
            // buttonpaper
            // 
            this.buttonpaper.Location = new System.Drawing.Point(143, 389);
            this.buttonpaper.Name = "buttonpaper";
            this.buttonpaper.Size = new System.Drawing.Size(125, 30);
            this.buttonpaper.TabIndex = 1;
            this.buttonpaper.Text = "Paper";
            this.buttonpaper.UseVisualStyleBackColor = true;
            this.buttonpaper.Click += new System.EventHandler(this.buttonpaper_Click);
            // 
            // buttonscissors
            // 
            this.buttonscissors.Location = new System.Drawing.Point(277, 389);
            this.buttonscissors.Name = "buttonscissors";
            this.buttonscissors.Size = new System.Drawing.Size(125, 30);
            this.buttonscissors.TabIndex = 2;
            this.buttonscissors.Text = "Scissors";
            this.buttonscissors.UseVisualStyleBackColor = true;
            this.buttonscissors.Click += new System.EventHandler(this.buttonscissors_Click);
            // 
            // buttonrestart
            // 
            this.buttonrestart.Location = new System.Drawing.Point(650, 389);
            this.buttonrestart.Name = "buttonrestart";
            this.buttonrestart.Size = new System.Drawing.Size(125, 30);
            this.buttonrestart.TabIndex = 3;
            this.buttonrestart.Text = "Restart";
            this.buttonrestart.UseVisualStyleBackColor = true;
            this.buttonrestart.Click += new System.EventHandler(this.buttonrestart_Click);
            // 
            // pictureplayer
            // 
            this.pictureplayer.Image = global::RPS.Properties.Resources.questionmark;
            this.pictureplayer.Location = new System.Drawing.Point(12, 109);
            this.pictureplayer.Name = "pictureplayer";
            this.pictureplayer.Size = new System.Drawing.Size(258, 231);
            this.pictureplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureplayer.TabIndex = 4;
            this.pictureplayer.TabStop = false;
            // 
            // picturecpu
            // 
            this.picturecpu.Image = global::RPS.Properties.Resources.questionmark;
            this.picturecpu.Location = new System.Drawing.Point(519, 109);
            this.picturecpu.Name = "picturecpu";
            this.picturecpu.Size = new System.Drawing.Size(269, 231);
            this.picturecpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturecpu.TabIndex = 5;
            this.picturecpu.TabStop = false;
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Location = new System.Drawing.Point(101, 77);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(56, 23);
            this.player.TabIndex = 7;
            this.player.Text = "Player";
            // 
            // Computer
            // 
            this.Computer.AutoSize = true;
            this.Computer.Location = new System.Drawing.Point(609, 77);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(87, 23);
            this.Computer.TabIndex = 8;
            this.Computer.Text = "Computer";
            // 
            // textscore
            // 
            this.textscore.AutoSize = true;
            this.textscore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textscore.Location = new System.Drawing.Point(277, 109);
            this.textscore.Name = "textscore";
            this.textscore.Size = new System.Drawing.Size(236, 23);
            this.textscore.TabIndex = 9;
            this.textscore.Text = "Player Score: 0 - CPU Score: 0";
            // 
            // textcountdown
            // 
            this.textcountdown.AutoSize = true;
            this.textcountdown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcountdown.Location = new System.Drawing.Point(370, 201);
            this.textcountdown.Name = "textcountdown";
            this.textcountdown.Size = new System.Drawing.Size(19, 23);
            this.textcountdown.TabIndex = 10;
            this.textcountdown.Text = "5";
            // 
            // textrounds
            // 
            this.textrounds.AutoSize = true;
            this.textrounds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textrounds.Location = new System.Drawing.Point(335, 294);
            this.textrounds.Name = "textrounds";
            this.textrounds.Size = new System.Drawing.Size(78, 23);
            this.textrounds.TabIndex = 11;
            this.textrounds.Text = "Round: 3";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimerEvent);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(295, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 39);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Rock Paper Scissors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textrounds);
            this.Controls.Add(this.textcountdown);
            this.Controls.Add(this.textscore);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picturecpu);
            this.Controls.Add(this.pictureplayer);
            this.Controls.Add(this.buttonrestart);
            this.Controls.Add(this.buttonscissors);
            this.Controls.Add(this.buttonpaper);
            this.Controls.Add(this.buttonrock);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonrock;
        private System.Windows.Forms.Button buttonpaper;
        private System.Windows.Forms.Button buttonscissors;
        private System.Windows.Forms.Button buttonrestart;
        private System.Windows.Forms.PictureBox pictureplayer;
        private System.Windows.Forms.PictureBox picturecpu;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label Computer;
        private System.Windows.Forms.Label textscore;
        private System.Windows.Forms.Label textcountdown;
        private System.Windows.Forms.Label textrounds;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

