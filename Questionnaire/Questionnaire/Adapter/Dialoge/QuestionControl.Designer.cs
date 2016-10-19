using System;

namespace Questionnaire.Adapter.Dialoge
{
    partial class QuestionControl
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
            this.panelScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.MinimumSize = new System.Drawing.Size(100, 12);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelQuestion.Size = new System.Drawing.Size(308, 18);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question?";
            // 
            // panelScroll
            // 
            this.panelScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScroll.AutoSize = true;
            this.panelScroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelScroll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelScroll.Location = new System.Drawing.Point(3, 21);
            this.panelScroll.MinimumSize = new System.Drawing.Size(100, 10);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(100, 10);
            this.panelScroll.TabIndex = 1;
            this.panelScroll.WrapContents = false;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.labelQuestion);
            this.MinimumSize = new System.Drawing.Size(100, 20);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(308, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.FlowLayoutPanel panelScroll;
    }
}
