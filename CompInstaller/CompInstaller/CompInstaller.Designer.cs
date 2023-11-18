namespace CompInstaller
{
    partial class Form1
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
            tabControl = new TabControl();
            tbParameters = new TabPage();
            dgvParameters = new DataGridView();
            tbInstallers = new TabPage();
            btnLoadComps = new Button();
            tabControl.SuspendLayout();
            tbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tbParameters);
            tabControl.Controls.Add(tbInstallers);
            tabControl.Location = new Point(12, 118);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(864, 373);
            tabControl.TabIndex = 0;
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
            // btnLoadComps
            // 
            btnLoadComps.Location = new Point(20, 15);
            btnLoadComps.Name = "btnLoadComps";
            btnLoadComps.Size = new Size(100, 29);
            btnLoadComps.TabIndex = 1;
            btnLoadComps.Text = "Load Comps";
            btnLoadComps.TextAlign = ContentAlignment.MiddleLeft;
            btnLoadComps.UseVisualStyleBackColor = true;
            btnLoadComps.Click += btnLoadComps_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 503);
            Controls.Add(btnLoadComps);
            Controls.Add(tabControl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompInstaller";
            Load += Form1_Load;
            Shown += Form1_Shown;
            tabControl.ResumeLayout(false);
            tbParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParameters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tbParameters;
        private TabPage tbInstallers;
        private DataGridView dgvParameters;
        private Button btnLoadComps;
    }
}