namespace nBackApp
{
    partial class SpielForm
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
            this.labelReiz = new System.Windows.Forms.Label();
            this.progressBarReizFortschritt = new System.Windows.Forms.ProgressBar();
            this.progressBarReizDauer = new System.Windows.Forms.ProgressBar();
            this.buttonErkannt = new System.Windows.Forms.Button();
            this.buttonÜberspringen = new System.Windows.Forms.Button();
            this.labelFortschritt = new System.Windows.Forms.Label();
            this.timerTimeout = new System.Windows.Forms.Timer(this.components);
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelReiz
            // 
            this.labelReiz.AutoSize = true;
            this.labelReiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReiz.Location = new System.Drawing.Point(64, 9);
            this.labelReiz.Name = "labelReiz";
            this.labelReiz.Size = new System.Drawing.Size(76, 73);
            this.labelReiz.TabIndex = 0;
            this.labelReiz.Text = "A";
            // 
            // progressBarReizFortschritt
            // 
            this.progressBarReizFortschritt.Location = new System.Drawing.Point(46, 102);
            this.progressBarReizFortschritt.Name = "progressBarReizFortschritt";
            this.progressBarReizFortschritt.Size = new System.Drawing.Size(100, 23);
            this.progressBarReizFortschritt.TabIndex = 1;
            // 
            // progressBarReizDauer
            // 
            this.progressBarReizDauer.Location = new System.Drawing.Point(146, 34);
            this.progressBarReizDauer.Name = "progressBarReizDauer";
            this.progressBarReizDauer.Size = new System.Drawing.Size(100, 20);
            this.progressBarReizDauer.TabIndex = 2;
            // 
            // buttonErkannt
            // 
            this.buttonErkannt.Location = new System.Drawing.Point(12, 144);
            this.buttonErkannt.Name = "buttonErkannt";
            this.buttonErkannt.Size = new System.Drawing.Size(75, 23);
            this.buttonErkannt.TabIndex = 3;
            this.buttonErkannt.Text = "Erkannt";
            this.buttonErkannt.UseVisualStyleBackColor = true;
            this.buttonErkannt.Click += new System.EventHandler(this.buttonErkannt_Click);
            // 
            // buttonÜberspringen
            // 
            this.buttonÜberspringen.Location = new System.Drawing.Point(97, 144);
            this.buttonÜberspringen.Name = "buttonÜberspringen";
            this.buttonÜberspringen.Size = new System.Drawing.Size(86, 23);
            this.buttonÜberspringen.TabIndex = 4;
            this.buttonÜberspringen.Text = "Überspringen";
            this.buttonÜberspringen.UseVisualStyleBackColor = true;
            this.buttonÜberspringen.Click += new System.EventHandler(this.buttonÜberspringen_Click);
            // 
            // labelFortschritt
            // 
            this.labelFortschritt.AutoSize = true;
            this.labelFortschritt.Location = new System.Drawing.Point(74, 128);
            this.labelFortschritt.Name = "labelFortschritt";
            this.labelFortschritt.Size = new System.Drawing.Size(45, 13);
            this.labelFortschritt.TabIndex = 5;
            this.labelFortschritt.Text = "0 von N";
            // 
            // timerTimeout
            // 
            this.timerTimeout.Interval = 50;
            this.timerTimeout.Tick += new System.EventHandler(this.timerTimeout_Tick);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 200;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // SpielForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 193);
            this.Controls.Add(this.labelFortschritt);
            this.Controls.Add(this.buttonÜberspringen);
            this.Controls.Add(this.buttonErkannt);
            this.Controls.Add(this.progressBarReizDauer);
            this.Controls.Add(this.progressBarReizFortschritt);
            this.Controls.Add(this.labelReiz);
            this.Name = "SpielForm";
            this.Text = "Spiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReiz;
        private System.Windows.Forms.ProgressBar progressBarReizFortschritt;
        private System.Windows.Forms.ProgressBar progressBarReizDauer;
        private System.Windows.Forms.Button buttonErkannt;
        private System.Windows.Forms.Button buttonÜberspringen;
        private System.Windows.Forms.Label labelFortschritt;
        private System.Windows.Forms.Timer timerTimeout;
        private System.Windows.Forms.Timer timerCountdown;
    }
}

