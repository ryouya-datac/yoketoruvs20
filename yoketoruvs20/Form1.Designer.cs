namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startbutton1 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.leftLabe = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gmaeOverlabel = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton1
            // 
            this.startbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startbutton1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startbutton1.Location = new System.Drawing.Point(278, 300);
            this.startbutton1.Name = "startbutton1";
            this.startbutton1.Size = new System.Drawing.Size(159, 63);
            this.startbutton1.TabIndex = 0;
            this.startbutton1.Text = "スタート";
            this.startbutton1.UseVisualStyleBackColor = false;
            this.startbutton1.Click += new System.EventHandler(this.startbutton1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Marker", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(217, 138);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(275, 61);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "よけとる2020";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(210, 414);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(327, 27);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright ©　2020 林　諒也";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(287, 213);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(140, 24);
            this.hiLabel.TabIndex = 3;
            this.hiLabel.Text = "HighScore 100";
            // 
            // leftLabe
            // 
            this.leftLabe.AutoSize = true;
            this.leftLabe.Font = new System.Drawing.Font("Trajan Pro 3", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabe.Location = new System.Drawing.Point(582, 54);
            this.leftLabe.Name = "leftLabe";
            this.leftLabe.Size = new System.Drawing.Size(70, 31);
            this.leftLabe.TabIndex = 4;
            this.leftLabe.Text = "★：10";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("UD デジタル 教科書体 N-B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(83, 56);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 24);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time 100";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gmaeOverlabel
            // 
            this.gmaeOverlabel.AutoSize = true;
            this.gmaeOverlabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)), true);
            this.gmaeOverlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gmaeOverlabel.Location = new System.Drawing.Point(262, 138);
            this.gmaeOverlabel.Name = "gmaeOverlabel";
            this.gmaeOverlabel.Size = new System.Drawing.Size(205, 40);
            this.gmaeOverlabel.TabIndex = 6;
            this.gmaeOverlabel.Text = "Game Over";
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearlabel.Location = new System.Drawing.Point(298, 138);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(139, 40);
            this.clearlabel.TabIndex = 7;
            this.clearlabel.Text = "CLEAR";
            // 
            // titlebutton
            // 
            this.titlebutton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlebutton.Location = new System.Drawing.Point(295, 306);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(132, 51);
            this.titlebutton.TabIndex = 8;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.gmaeOverlabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.leftLabe);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label leftLabe;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gmaeOverlabel;
        private System.Windows.Forms.Label clearlabel;
        private System.Windows.Forms.Button titlebutton;
    }
}

