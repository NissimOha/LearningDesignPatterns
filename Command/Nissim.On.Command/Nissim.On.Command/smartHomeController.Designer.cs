namespace Nissim.On.Command
{
    partial class smartHomeController
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
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.backResultPanel = new System.Windows.Forms.Panel();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.doButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.backResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(12, 183);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(187, 47);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Chartreuse;
            this.greenButton.Location = new System.Drawing.Point(12, 236);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(187, 47);
            this.greenButton.TabIndex = 1;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(12, 289);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(187, 47);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.blackButton.Location = new System.Drawing.Point(12, 342);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(187, 47);
            this.blackButton.TabIndex = 3;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // backResultPanel
            // 
            this.backResultPanel.Controls.Add(this.resultTextBox);
            this.backResultPanel.Location = new System.Drawing.Point(13, 43);
            this.backResultPanel.Name = "backResultPanel";
            this.backResultPanel.Size = new System.Drawing.Size(186, 134);
            this.backResultPanel.TabIndex = 6;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(4, 54);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(179, 20);
            this.resultTextBox.TabIndex = 0;
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(115, 12);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(84, 24);
            this.doButton.TabIndex = 5;
            this.doButton.Text = "--->";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.doButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(13, 12);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(84, 24);
            this.undoButton.TabIndex = 4;
            this.undoButton.Text = "<---";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // smartHomeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(211, 401);
            this.Controls.Add(this.backResultPanel);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "smartHomeController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Controler";
            this.backResultPanel.ResumeLayout(false);
            this.backResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.Panel backResultPanel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

