namespace Questionnaire.Adapter.Dialoge
{
    partial class ScoreControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelYourAnswer = new System.Windows.Forms.Label();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(28, 15);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "???";
            // 
            // labelYourAnswer
            // 
            this.labelYourAnswer.AutoSize = true;
            this.labelYourAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourAnswer.Location = new System.Drawing.Point(24, 20);
            this.labelYourAnswer.Name = "labelYourAnswer";
            this.labelYourAnswer.Size = new System.Drawing.Size(30, 15);
            this.labelYourAnswer.TabIndex = 1;
            this.labelYourAnswer.Text = "your";
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoSize = true;
            this.labelCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectAnswer.Location = new System.Drawing.Point(24, 42);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(44, 15);
            this.labelCorrectAnswer.TabIndex = 2;
            this.labelCorrectAnswer.Text = "correct";
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.labelCorrectAnswer);
            this.Controls.Add(this.labelYourAnswer);
            this.Controls.Add(this.labelQuestion);
            this.MinimumSize = new System.Drawing.Size(0, 55);
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(71, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelYourAnswer;
        private System.Windows.Forms.Label labelCorrectAnswer;
    }
}
