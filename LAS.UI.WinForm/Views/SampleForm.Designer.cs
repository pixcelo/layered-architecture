﻿namespace LAS.UI.WinForm.Views
{
    partial class SampleForm
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
            geButton = new Button();
            postButton = new Button();
            SuspendLayout();
            // 
            // geButton
            // 
            geButton.Location = new Point(56, 73);
            geButton.Name = "geButton";
            geButton.Size = new Size(75, 23);
            geButton.TabIndex = 0;
            geButton.Text = "get";
            geButton.UseVisualStyleBackColor = true;
            geButton.Click += getButton_Click;
            // 
            // postButton
            // 
            postButton.Location = new Point(150, 73);
            postButton.Name = "postButton";
            postButton.Size = new Size(75, 23);
            postButton.TabIndex = 1;
            postButton.Text = "post";
            postButton.UseVisualStyleBackColor = true;
            postButton.Click += postButton_Click;
            // 
            // SampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(postButton);
            Controls.Add(geButton);
            Name = "SampleForm";
            Text = "SampleForm";
            ResumeLayout(false);
        }

        #endregion

        private Button geButton;
        private Button postButton;
    }
}
