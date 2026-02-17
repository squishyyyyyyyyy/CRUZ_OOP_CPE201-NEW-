namespace CRUZ_OOP_CPE201
{
    partial class Lesson3Example5PrintForm
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
            this.priDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // priDisplayListbox
            // 
            this.priDisplayListbox.FormattingEnabled = true;
            this.priDisplayListbox.ItemHeight = 16;
            this.priDisplayListbox.Location = new System.Drawing.Point(12, 12);
            this.priDisplayListbox.Name = "priDisplayListbox";
            this.priDisplayListbox.Size = new System.Drawing.Size(776, 580);
            this.priDisplayListbox.TabIndex = 0;
            // 
            // Lesson3Example5PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.priDisplayListbox);
            this.Name = "Lesson3Example5PrintForm";
            this.Text = "Print Form";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox priDisplayListbox;
    }
}