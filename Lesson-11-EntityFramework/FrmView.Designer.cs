namespace Lesson_11_EntityFramework
{
    partial class FrmView
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
            btnDataLoad = new Button();
            dvgProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            SuspendLayout();
            // 
            // btnDataLoad
            // 
            btnDataLoad.Location = new Point(25, 29);
            btnDataLoad.Name = "btnDataLoad";
            btnDataLoad.Size = new Size(131, 87);
            btnDataLoad.TabIndex = 0;
            btnDataLoad.Text = "Load";
            btnDataLoad.UseVisualStyleBackColor = true;
            btnDataLoad.Click += btnDataLoad_Click;
            // 
            // dvgProducts
            // 
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.Location = new Point(-2, 137);
            dvgProducts.Name = "dvgProducts";
            dvgProducts.RowTemplate.Height = 25;
            dvgProducts.Size = new Size(806, 316);
            dvgProducts.TabIndex = 1;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgProducts);
            Controls.Add(btnDataLoad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDataLoad;
        private DataGridView dvgProducts;
    }
}