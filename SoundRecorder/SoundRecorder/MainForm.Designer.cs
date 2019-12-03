namespace SoundRecorder
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Recording = new System.Windows.Forms.Label();
            this.StartRecord = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Recording
            // 
            this.Recording.AutoSize = true;
            this.Recording.ForeColor = System.Drawing.Color.Crimson;
            this.Recording.Location = new System.Drawing.Point(12, 126);
            this.Recording.Name = "Recording";
            this.Recording.Size = new System.Drawing.Size(65, 13);
            this.Recording.TabIndex = 2;
            this.Recording.Text = "Recording...";
            // 
            // StartRecord
            // 
            this.StartRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartRecord.Image = global::SoundRecorder.Properties.Resources.recordIdle;
            this.StartRecord.Location = new System.Drawing.Point(12, 12);
            this.StartRecord.Name = "StartRecord";
            this.StartRecord.Size = new System.Drawing.Size(236, 111);
            this.StartRecord.TabIndex = 0;
            this.StartRecord.UseVisualStyleBackColor = true;
            this.StartRecord.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.timerLabel.Location = new System.Drawing.Point(199, 125);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 13);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 147);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.Recording);
            this.Controls.Add(this.StartRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 190);
            this.MinimumSize = new System.Drawing.Size(280, 190);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundRecorder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartRecord;
        private System.Windows.Forms.Label Recording;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

