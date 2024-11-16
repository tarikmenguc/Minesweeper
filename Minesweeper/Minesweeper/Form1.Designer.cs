namespace MinesWeeper
{
    partial class Form1
    {
        /// <summary>
        ///  Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar atılacaksa <c>true</c>; aksi halde <c>false</c>.</param>
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
        ///  Tasarım desteği için gerekli metot.
        ///  Bu metodun içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFlagCount = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // panelGameArea
            this.panelGameArea.Location = new System.Drawing.Point(30, 30);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(600, 600);
            this.panelGameArea.TabIndex = 0;
            this.panelGameArea.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Koyu arka plan
            this.panelGameArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(650, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(28, 151, 234);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // lblFlagCount
            this.lblFlagCount.AutoSize = true;
            this.lblFlagCount.Location = new System.Drawing.Point(650, 80);
            this.lblFlagCount.Name = "lblFlagCount";
            this.lblFlagCount.Size = new System.Drawing.Size(150, 20);
            this.lblFlagCount.TabIndex = 2;
            this.lblFlagCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFlagCount.ForeColor = System.Drawing.Color.White;
            this.lblFlagCount.Text = "🚩 Kalan Bayrak: 0";

            // lblTimer
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(650, 120);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(120, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Text = "🕒 Süre: 00:00";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFlagCount);
            this.Controls.Add(this.lblTimer);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38); // Koyu arka plan
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFlagCount;
        private System.Windows.Forms.Label lblTimer;
    }
}
