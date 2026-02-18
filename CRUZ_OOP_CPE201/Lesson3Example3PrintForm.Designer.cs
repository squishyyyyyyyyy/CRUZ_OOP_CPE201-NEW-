namespace CRUZ_OOP_CPE201
{
    partial class Lesson3Example3PrintForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.printDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "JABILEE FOOD CORP. ORDERING APPLICATION";
            // 
            // printDisplayListbox
            // 
            this.printDisplayListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDisplayListbox.FormattingEnabled = true;
            this.printDisplayListbox.ItemHeight = 25;
            this.printDisplayListbox.Location = new System.Drawing.Point(12, 114);
            this.printDisplayListbox.Name = "printDisplayListbox";
            this.printDisplayListbox.Size = new System.Drawing.Size(776, 529);
            this.printDisplayListbox.TabIndex = 1;
            // 
            // Lesson3Example3PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.printDisplayListbox);
            this.Controls.Add(this.label1);
            this.Name = "Lesson3Example3PrintForm";
            this.Text = "Transaction Receipt";
            this.Load += new System.EventHandler(this.Lesson3Example3PrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox printDisplayListbox;
    }
}