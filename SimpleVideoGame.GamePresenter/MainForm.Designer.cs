using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    partial class MainForm
    {
        private PictureBox CanvasPictureBox;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanvasPictureBox = new System.Windows.Forms.PictureBox();
            this.StartGameEngineButton = new System.Windows.Forms.Button();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.MaxFPSLabel = new System.Windows.Forms.Label();
            this.MinFPSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPictureBox
            // 
            this.CanvasPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPictureBox.Location = new System.Drawing.Point(13, 42);
            this.CanvasPictureBox.Name = "CanvasPictureBox";
            this.CanvasPictureBox.Size = new System.Drawing.Size(959, 507);
            this.CanvasPictureBox.TabIndex = 0;
            this.CanvasPictureBox.TabStop = false;
            // 
            // StartGameEngineButton
            // 
            this.StartGameEngineButton.Location = new System.Drawing.Point(13, 13);
            this.StartGameEngineButton.Name = "StartGameEngineButton";
            this.StartGameEngineButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameEngineButton.TabIndex = 1;
            this.StartGameEngineButton.Text = "Start";
            this.StartGameEngineButton.UseVisualStyleBackColor = true;
            this.StartGameEngineButton.Click += new System.EventHandler(this.StartGameEngineButton_Click);
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Location = new System.Drawing.Point(94, 18);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(35, 13);
            this.FPSLabel.TabIndex = 2;
            this.FPSLabel.Text = "label1";
            // 
            // MaxFPSLabel
            // 
            this.MaxFPSLabel.AutoSize = true;
            this.MaxFPSLabel.Location = new System.Drawing.Point(333, 18);
            this.MaxFPSLabel.Name = "MaxFPSLabel";
            this.MaxFPSLabel.Size = new System.Drawing.Size(0, 13);
            this.MaxFPSLabel.TabIndex = 3;
            // 
            // MinFPSLabel
            // 
            this.MinFPSLabel.AutoSize = true;
            this.MinFPSLabel.Location = new System.Drawing.Point(241, 18);
            this.MinFPSLabel.Name = "MinFPSLabel";
            this.MinFPSLabel.Size = new System.Drawing.Size(0, 13);
            this.MinFPSLabel.TabIndex = 4;
            // 
            // MainTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MinFPSLabel);
            this.Controls.Add(this.MaxFPSLabel);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.StartGameEngineButton);
            this.Controls.Add(this.CanvasPictureBox);
            this.Name = "MainTestForm";
            this.Text = "MainTestForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartGameEngineButton;
        private Label FPSLabel;
        private Label MaxFPSLabel;
        private Label MinFPSLabel;
    }
}