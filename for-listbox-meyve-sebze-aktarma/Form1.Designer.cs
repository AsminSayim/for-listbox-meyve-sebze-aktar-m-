namespace for_listbox_meyve_sebze_aktarma
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lslMeyve = new System.Windows.Forms.ListBox();
            this.lslSebze = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Elma",
            "Biber",
            "Karpuz",
            "Erik",
            "Patlıcan",
            "Ispanak"});
            this.listBox1.Location = new System.Drawing.Point(98, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 196);
            this.listBox1.TabIndex = 0;
            // 
            // lslMeyve
            // 
            this.lslMeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lslMeyve.FormattingEnabled = true;
            this.lslMeyve.ItemHeight = 16;
            this.lslMeyve.Location = new System.Drawing.Point(288, 127);
            this.lslMeyve.Name = "lslMeyve";
            this.lslMeyve.Size = new System.Drawing.Size(120, 196);
            this.lslMeyve.TabIndex = 1;
            // 
            // lslSebze
            // 
            this.lslSebze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lslSebze.FormattingEnabled = true;
            this.lslSebze.ItemHeight = 16;
            this.lslSebze.Location = new System.Drawing.Point(484, 127);
            this.lslSebze.Name = "lslSebze";
            this.lslSebze.Size = new System.Drawing.Size(120, 196);
            this.lslSebze.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(98, 388);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(157, 46);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 485);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lslSebze);
            this.Controls.Add(this.lslMeyve);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lslMeyve;
        private System.Windows.Forms.ListBox lslSebze;
        private System.Windows.Forms.Button btnAktar;
    }
}

