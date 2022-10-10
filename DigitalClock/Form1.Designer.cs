namespace DigitalClock
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
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.LabelDay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.White;
            this.LabelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTime.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(276, 145);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(238, 98);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "00:00";
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.BackColor = System.Drawing.Color.White;
            this.LabelSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelSeconds.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeconds.Location = new System.Drawing.Point(500, 184);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(68, 51);
            this.LabelSeconds.TabIndex = 1;
            this.LabelSeconds.Text = "00";
            // 
            // LabelDay
            // 
            this.LabelDay.AutoSize = true;
            this.LabelDay.BackColor = System.Drawing.Color.White;
            this.LabelDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelDay.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDay.Location = new System.Drawing.Point(476, 289);
            this.LabelDay.Name = "LabelDay";
            this.LabelDay.Size = new System.Drawing.Size(219, 51);
            this.LabelDay.TabIndex = 2;
            this.LabelDay.Text = "WEDNESDAY";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDate.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(104, 289);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(313, 51);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "OCTOBER 5 2022";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.LabelDay);
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.LabelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Label LabelDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer;
    }
}

