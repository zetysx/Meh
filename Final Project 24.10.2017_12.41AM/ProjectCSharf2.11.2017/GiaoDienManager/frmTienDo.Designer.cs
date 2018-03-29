namespace ProjectCSharp
{
    partial class frmTienDo
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
            this.labelProgress = new System.Windows.Forms.Label();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.Location = new System.Drawing.Point(285, 86);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(275, 40);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "Progressing.....";
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(13, 26);
            this.pgbProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(820, 55);
            this.pgbProgress.TabIndex = 2;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 149);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.pgbProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTienDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTienDo";
            this.Load += new System.EventHandler(this.frmTienDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.Timer timerCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}