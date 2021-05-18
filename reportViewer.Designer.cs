namespace ETIQUETADO_ARTICULOS
{
    partial class reportViewer
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
            this.ViewEtiqueta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ViewEtiqueta
            // 
            this.ViewEtiqueta.ActiveViewIndex = -1;
            this.ViewEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewEtiqueta.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewEtiqueta.DisplayStatusBar = false;
            this.ViewEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEtiqueta.Location = new System.Drawing.Point(0, 0);
            this.ViewEtiqueta.Name = "ViewEtiqueta";
            this.ViewEtiqueta.Size = new System.Drawing.Size(487, 326);
            this.ViewEtiqueta.TabIndex = 0;
            this.ViewEtiqueta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 326);
            this.Controls.Add(this.ViewEtiqueta);
            this.Name = "reportViewer";
            this.Text = "reportViewer";
            this.Load += new System.EventHandler(this.reportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewEtiqueta;
    }
}