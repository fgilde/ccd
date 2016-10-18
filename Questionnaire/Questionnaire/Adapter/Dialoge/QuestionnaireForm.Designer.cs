using System;

namespace Questionnaire.Adapter.Dialoge
{
    partial class QuestionnaireForm
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
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowScore.Location = new System.Drawing.Point(227, 312);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(130, 23);
            this.buttonShowScore.TabIndex = 0;
            this.buttonShowScore.Text = "Show my score...";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScroll.AutoScroll = true;
            this.panelScroll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelScroll.Location = new System.Drawing.Point(12, 12);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(345, 294);
            this.panelScroll.TabIndex = 2;
            this.panelScroll.WrapContents = false;
            // 
            // QuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 347);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.buttonShowScore);
            this.MinimumSize = new System.Drawing.Size(385, 385);
            this.Name = "QuestionnaireForm";
            this.Text = "Questionnaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.FlowLayoutPanel panelScroll;
    }
}

