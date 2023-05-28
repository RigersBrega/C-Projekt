namespace ProjectLogin
{
    partial class ChooseProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseProducts));
            this.insertedDG = new System.Windows.Forms.DataGridView();
            this.toInsertDG = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.insertProductsBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insertedDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toInsertDG)).BeginInit();
            this.SuspendLayout();
            // 
            // insertedDG
            // 
            this.insertedDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertedDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertedDG.Location = new System.Drawing.Point(428, 25);
            this.insertedDG.Name = "insertedDG";
            this.insertedDG.Size = new System.Drawing.Size(325, 389);
            this.insertedDG.TabIndex = 1;
            // 
            // toInsertDG
            // 
            this.toInsertDG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.toInsertDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toInsertDG.Location = new System.Drawing.Point(44, 25);
            this.toInsertDG.Name = "toInsertDG";
            this.toInsertDG.Size = new System.Drawing.Size(325, 389);
            this.toInsertDG.TabIndex = 2;
            this.toInsertDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toInsertDG_CellContentClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(375, 156);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(44, 23);
            this.add.TabIndex = 3;
            this.add.Text = "->";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(375, 236);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(44, 23);
            this.remove.TabIndex = 4;
            this.remove.Text = "<-";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // insertProductsBtn
            // 
            this.insertProductsBtn.Location = new System.Drawing.Point(669, 439);
            this.insertProductsBtn.Name = "insertProductsBtn";
            this.insertProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.insertProductsBtn.TabIndex = 5;
            this.insertProductsBtn.Text = "Shto";
            this.insertProductsBtn.UseVisualStyleBackColor = true;
            this.insertProductsBtn.Click += new System.EventHandler(this.insertProductsBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(571, 439);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Mbrapa";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ChooseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.insertProductsBtn);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.toInsertDG);
            this.Controls.Add(this.insertedDG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseProducts";
            this.Text = "Choose Products";
            ((System.ComponentModel.ISupportInitialize)(this.insertedDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toInsertDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView insertedDG;
        private System.Windows.Forms.DataGridView toInsertDG;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button insertProductsBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}