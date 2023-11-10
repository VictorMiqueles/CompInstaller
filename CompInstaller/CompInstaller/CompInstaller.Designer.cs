namespace CompInstaller
{
    partial class CompInstaller
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
            tbMain = new TabControl();
            tbParameters = new TabPage();
            tbInstallers = new TabPage();
            dgvParameters = new DataGridView();
            tbMain.SuspendLayout();
            tbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).BeginInit();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.Controls.Add(tbParameters);
            tbMain.Controls.Add(tbInstallers);
            tbMain.Location = new Point(12, 118);
            tbMain.Name = "tbMain";
            tbMain.SelectedIndex = 0;
            tbMain.Size = new Size(864, 373);
            tbMain.TabIndex = 0;
            // 
            // tbParameters
            // 
            tbParameters.Controls.Add(dgvParameters);
            tbParameters.Location = new Point(4, 29);
            tbParameters.Name = "tbParameters";
            tbParameters.Padding = new Padding(3);
            tbParameters.Size = new Size(856, 340);
            tbParameters.TabIndex = 0;
            tbParameters.Text = "Parameters";
            tbParameters.UseVisualStyleBackColor = true;
            // 
            // tbInstallers
            // 
            tbInstallers.Location = new Point(4, 29);
            tbInstallers.Name = "tbInstallers";
            tbInstallers.Padding = new Padding(3);
            tbInstallers.Size = new Size(856, 340);
            tbInstallers.TabIndex = 1;
            tbInstallers.Text = "Installers";
            tbInstallers.UseVisualStyleBackColor = true;
            // 
            // dgvParameters
            // 
            dgvParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParameters.Location = new Point(6, 6);
            dgvParameters.Name = "dgvParameters";
            dgvParameters.RowHeadersWidth = 51;
            dgvParameters.RowTemplate.Height = 29;
            dgvParameters.Size = new Size(844, 331);
            dgvParameters.TabIndex = 0;
            // 
            // CompInstaller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 503);
            Controls.Add(tbMain);
            Name = "CompInstaller";
            Text = "Form1";
            tbMain.ResumeLayout(false);
            tbParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParameters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMain;
        private TabPage tbParameters;
        private TabPage tbInstallers;
        private DataGridView dgvParameters;
    }
}