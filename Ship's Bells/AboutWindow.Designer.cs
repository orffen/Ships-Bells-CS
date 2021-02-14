
namespace Ships_Bells
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.tableLayoutPanelAbout = new System.Windows.Forms.TableLayoutPanel();
            this.labelAboutText = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAbout
            // 
            this.tableLayoutPanelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAbout.ColumnCount = 1;
            this.tableLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbout.Controls.Add(this.labelAboutText, 0, 0);
            this.tableLayoutPanelAbout.Controls.Add(this.buttonClose, 0, 1);
            this.tableLayoutPanelAbout.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelAbout.Name = "tableLayoutPanelAbout";
            this.tableLayoutPanelAbout.RowCount = 2;
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbout.Size = new System.Drawing.Size(471, 120);
            this.tableLayoutPanelAbout.TabIndex = 0;
            // 
            // labelAboutText
            // 
            this.labelAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAboutText.AutoSize = true;
            this.labelAboutText.Location = new System.Drawing.Point(3, 0);
            this.labelAboutText.Name = "labelAboutText";
            this.labelAboutText.Size = new System.Drawing.Size(469, 84);
            this.labelAboutText.TabIndex = 0;
            this.labelAboutText.Text = resources.GetString("labelAboutText.Text");
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.Location = new System.Drawing.Point(200, 87);
            this.buttonClose.MaximumSize = new System.Drawing.Size(75, 30);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 30);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AboutWindow
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(495, 144);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelAbout);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutWindow";
            this.TopMost = true;
            this.tableLayoutPanelAbout.ResumeLayout(false);
            this.tableLayoutPanelAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbout;
        private System.Windows.Forms.Label labelAboutText;
        private System.Windows.Forms.Button buttonClose;
    }
}