using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    partial class MainForm
    {
        private System.Windows.Forms.PictureBox CanvasPictureBox;

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
            this.CanvasPictureBox = new System.Windows.Forms.PictureBox();
            this.StartGameEngineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPictureBox
            // 
            this.CanvasPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPictureBox.Location = new System.Drawing.Point(17, 52);
            this.CanvasPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CanvasPictureBox.Name = "CanvasPictureBox";
            this.CanvasPictureBox.Size = new System.Drawing.Size(1279, 624);
            this.CanvasPictureBox.TabIndex = 0;
            this.CanvasPictureBox.TabStop = false;
            // 
            // StartGameEngineButton
            // 
            this.StartGameEngineButton.Location = new System.Drawing.Point(17, 16);
            this.StartGameEngineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartGameEngineButton.Name = "StartGameEngineButton";
            this.StartGameEngineButton.Size = new System.Drawing.Size(100, 28);
            this.StartGameEngineButton.TabIndex = 1;
            this.StartGameEngineButton.Text = "Start";
            this.StartGameEngineButton.UseVisualStyleBackColor = true;
            this.StartGameEngineButton.Click += new System.EventHandler(this.StartGameEngineButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.StartGameEngineButton);
            this.Controls.Add(this.CanvasPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainTestForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartGameEngineButton;
    }
}

