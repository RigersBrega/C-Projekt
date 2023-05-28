namespace ProjectLogin
{
    partial class Porosite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Porosite));
            this.porositeDG = new System.Windows.Forms.DataGridView();
            this.productsDG = new System.Windows.Forms.DataGridView();
            this.poroLabel = new System.Windows.Forms.Label();
            this.prdlabel = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.goback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.porositeDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // porositeDG
            // 
            this.porositeDG.AllowUserToAddRows = false;
            this.porositeDG.AllowUserToDeleteRows = false;
            this.porositeDG.AllowUserToResizeColumns = false;
            this.porositeDG.AllowUserToResizeRows = false;
            this.porositeDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.porositeDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.porositeDG.Location = new System.Drawing.Point(29, 95);
            this.porositeDG.Name = "porositeDG";
            this.porositeDG.Size = new System.Drawing.Size(319, 340);
            this.porositeDG.TabIndex = 0;
            this.porositeDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.porositeDG_CellContentClick);
            // 
            // productsDG
            // 
            this.productsDG.AllowUserToAddRows = false;
            this.productsDG.AllowUserToDeleteRows = false;
            this.productsDG.AllowUserToResizeColumns = false;
            this.productsDG.AllowUserToResizeRows = false;
            this.productsDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDG.Location = new System.Drawing.Point(425, 95);
            this.productsDG.Name = "productsDG";
            this.productsDG.Size = new System.Drawing.Size(319, 340);
            this.productsDG.TabIndex = 1;
            this.productsDG.SelectionChanged += new System.EventHandler(this.productsDG_SelectionChanged);
            // 
            // poroLabel
            // 
            this.poroLabel.AutoSize = true;
            this.poroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poroLabel.Location = new System.Drawing.Point(25, 68);
            this.poroLabel.Name = "poroLabel";
            this.poroLabel.Size = new System.Drawing.Size(78, 24);
            this.poroLabel.TabIndex = 2;
            this.poroLabel.Text = "Porosite";
            // 
            // prdlabel
            // 
            this.prdlabel.AutoSize = true;
            this.prdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdlabel.Location = new System.Drawing.Point(421, 68);
            this.prdlabel.Name = "prdlabel";
            this.prdlabel.Size = new System.Drawing.Size(89, 24);
            this.prdlabel.TabIndex = 3;
            this.prdlabel.Text = "Produktet";
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.Location = new System.Drawing.Point(25, 450);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(65, 24);
            this.totLabel.TabIndex = 4;
            this.totLabel.Text = "Totali: ";
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.Location = new System.Drawing.Point(81, 450);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(0, 24);
            this.totalField.TabIndex = 5;
            // 
            // goback
            // 
            this.goback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback.Location = new System.Drawing.Point(28, 12);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(75, 27);
            this.goback.TabIndex = 6;
            this.goback.Text = "Mbrapa";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goBack_Click);
            // 
            // Porosite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.totLabel);
            this.Controls.Add(this.prdlabel);
            this.Controls.Add(this.poroLabel);
            this.Controls.Add(this.productsDG);
            this.Controls.Add(this.porositeDG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Porosite";
            this.Text = "Porosite";
            this.Load += new System.EventHandler(this.Porosite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.porositeDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView porositeDG;
        private System.Windows.Forms.DataGridView productsDG;
        private System.Windows.Forms.Label poroLabel;
        private System.Windows.Forms.Label prdlabel;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Button goback;
    }
}