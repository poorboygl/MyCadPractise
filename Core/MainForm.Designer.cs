namespace Core
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cbbOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTextstyleCount = new System.Windows.Forms.Label();
            this.lblLinetypeCount = new System.Windows.Forms.Label();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lbxTextstyle = new System.Windows.Forms.ListBox();
            this.lbxLinetype = new System.Windows.Forms.ListBox();
            this.lbxLayer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowItems);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.cbbOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Container";
            // 
            // btnShowItems
            // 
            this.btnShowItems.Location = new System.Drawing.Point(42, 339);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(75, 23);
            this.btnShowItems.TabIndex = 3;
            this.btnShowItems.Text = "Show Items";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(160, 339);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // cbbOptions
            // 
            this.cbbOptions.FormattingEnabled = true;
            this.cbbOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "LineType",
            "Textstyle"});
            this.cbbOptions.Location = new System.Drawing.Point(124, 20);
            this.cbbOptions.Name = "cbbOptions";
            this.cbbOptions.Size = new System.Drawing.Size(180, 21);
            this.cbbOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item to display:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTextstyleCount);
            this.groupBox2.Controls.Add(this.lblLinetypeCount);
            this.groupBox2.Controls.Add(this.lblLayerCount);
            this.groupBox2.Controls.Add(this.lbxTextstyle);
            this.groupBox2.Controls.Add(this.lbxLinetype);
            this.groupBox2.Controls.Add(this.lbxLayer);
            this.groupBox2.Location = new System.Drawing.Point(358, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // lblTextstyleCount
            // 
            this.lblTextstyleCount.AutoSize = true;
            this.lblTextstyleCount.Location = new System.Drawing.Point(215, 304);
            this.lblTextstyleCount.Name = "lblTextstyleCount";
            this.lblTextstyleCount.Size = new System.Drawing.Size(16, 13);
            this.lblTextstyleCount.TabIndex = 9;
            this.lblTextstyleCount.Text = "...";
            // 
            // lblLinetypeCount
            // 
            this.lblLinetypeCount.AutoSize = true;
            this.lblLinetypeCount.Location = new System.Drawing.Point(109, 304);
            this.lblLinetypeCount.Name = "lblLinetypeCount";
            this.lblLinetypeCount.Size = new System.Drawing.Size(16, 13);
            this.lblLinetypeCount.TabIndex = 8;
            this.lblLinetypeCount.Text = "...";
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(7, 304);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(16, 13);
            this.lblLayerCount.TabIndex = 7;
            this.lblLayerCount.Text = "...";
            // 
            // lbxTextstyle
            // 
            this.lbxTextstyle.FormattingEnabled = true;
            this.lbxTextstyle.Location = new System.Drawing.Point(218, 19);
            this.lbxTextstyle.Name = "lbxTextstyle";
            this.lbxTextstyle.Size = new System.Drawing.Size(100, 277);
            this.lbxTextstyle.TabIndex = 6;
            // 
            // lbxLinetype
            // 
            this.lbxLinetype.FormattingEnabled = true;
            this.lbxLinetype.Location = new System.Drawing.Point(112, 20);
            this.lbxLinetype.Name = "lbxLinetype";
            this.lbxLinetype.Size = new System.Drawing.Size(100, 277);
            this.lbxLinetype.TabIndex = 5;
            // 
            // lbxLayer
            // 
            this.lbxLayer.FormattingEnabled = true;
            this.lbxLayer.Location = new System.Drawing.Point(6, 20);
            this.lbxLayer.Name = "lbxLayer";
            this.lbxLayer.Size = new System.Drawing.Size(100, 277);
            this.lbxLayer.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbOptions;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxLinetype;
        private System.Windows.Forms.ListBox lbxLayer;
        private System.Windows.Forms.ListBox lbxTextstyle;
        private System.Windows.Forms.Label lblTextstyleCount;
        private System.Windows.Forms.Label lblLinetypeCount;
        private System.Windows.Forms.Label lblLayerCount;
    }
}