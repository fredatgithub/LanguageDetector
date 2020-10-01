namespace FormatNewLanguageText
{
    partial class FormPleaseWait
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
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.AutoSize = true;
            this.labelPleaseWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPleaseWait.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPleaseWait.Location = new System.Drawing.Point(52, 53);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(849, 60);
            this.labelPleaseWait.TabIndex = 0;
            this.labelPleaseWait.Text = "Please wait while processing data";
            // 
            // FormPleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(797, 169);
            this.ControlBox = false;
            this.Controls.Add(this.labelPleaseWait);
            this.MinimizeBox = false;
            this.Name = "FormPleaseWait";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPleaseWait;
    }
}