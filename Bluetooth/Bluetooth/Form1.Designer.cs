namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bpair = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 364);
            this.listBox1.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(380, 22);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(201, 48);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Wszukaj urzadzenia BT";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bpair
            // 
            this.bpair.Location = new System.Drawing.Point(599, 24);
            this.bpair.Name = "bpair";
            this.bpair.Size = new System.Drawing.Size(201, 46);
            this.bpair.TabIndex = 3;
            this.bpair.Text = "Sparuj";
            this.bpair.UseVisualStyleBackColor = true;
            this.bpair.Click += new System.EventHandler(this.bpair_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(822, 24);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(201, 46);
            this.bSend.TabIndex = 4;
            this.bSend.Text = "Wyslij plik";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 430);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bpair);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bpair;
        private System.Windows.Forms.Button bSend;
    }
}

