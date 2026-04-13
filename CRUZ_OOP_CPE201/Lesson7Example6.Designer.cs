namespace CRUZ_OOP_CPE201
{
    partial class Lesson7Example6
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
            this.label2 = new System.Windows.Forms.Label();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.displayListbox = new System.Windows.Forms.ListBox();
            this.numTimesDisplaytxt = new System.Windows.Forms.TextBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELECT COUNTRY TO DISPLAY AT THE LISTBOX";
            // 
            // countryCombobox
            // 
            this.countryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.Items.AddRange(new object[] {
            "South Korea",
            "Thailand",
            "Hawaii",
            "Hong Kong",
            "Canada ",
            "Japan"});
            this.countryCombobox.Location = new System.Drawing.Point(197, 180);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(400, 28);
            this.countryCombobox.TabIndex = 2;
            this.countryCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // displayListbox
            // 
            this.displayListbox.FormattingEnabled = true;
            this.displayListbox.ItemHeight = 16;
            this.displayListbox.Location = new System.Drawing.Point(197, 214);
            this.displayListbox.Name = "displayListbox";
            this.displayListbox.Size = new System.Drawing.Size(400, 180);
            this.displayListbox.TabIndex = 3;
            this.displayListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // numTimesDisplaytxt
            // 
            this.numTimesDisplaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTimesDisplaytxt.Location = new System.Drawing.Point(287, 80);
            this.numTimesDisplaytxt.Name = "numTimesDisplaytxt";
            this.numTimesDisplaytxt.Size = new System.Drawing.Size(235, 27);
            this.numTimesDisplaytxt.TabIndex = 4;
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(528, 75);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(97, 37);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "SHOW";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lesson7Example6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.numTimesDisplaytxt);
            this.Controls.Add(this.displayListbox);
            this.Controls.Add(this.countryCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lesson7Example6";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox countryCombobox;
        private System.Windows.Forms.ListBox displayListbox;
        private System.Windows.Forms.TextBox numTimesDisplaytxt;
        private System.Windows.Forms.Button showBtn;
    }
}