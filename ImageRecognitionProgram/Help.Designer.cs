namespace ImageIdentifier
{
    partial class Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helper));
            this.tabHelper = new System.Windows.Forms.TabControl();
            this.pgWelcome = new System.Windows.Forms.TabPage();
            this.rtxtWelcome = new System.Windows.Forms.RichTextBox();
            this.pgTemplatesTut = new System.Windows.Forms.TabPage();
            this.rtxtTemplates = new System.Windows.Forms.RichTextBox();
            this.pgAnalyseTut = new System.Windows.Forms.TabPage();
            this.rtxtAnalyse = new System.Windows.Forms.RichTextBox();
            this.pgTips = new System.Windows.Forms.TabPage();
            this.rtxtTips = new System.Windows.Forms.RichTextBox();
            this.pgNotes = new System.Windows.Forms.TabPage();
            this.rtxtImportant = new System.Windows.Forms.RichTextBox();
            this.pgSigmoid = new System.Windows.Forms.TabPage();
            this.rtxtSigmoid = new System.Windows.Forms.RichTextBox();
            this.pgHash = new System.Windows.Forms.TabPage();
            this.btnCopyHash = new System.Windows.Forms.Button();
            this.rtxtHash = new System.Windows.Forms.RichTextBox();
            this.tabHelper.SuspendLayout();
            this.pgWelcome.SuspendLayout();
            this.pgTemplatesTut.SuspendLayout();
            this.pgAnalyseTut.SuspendLayout();
            this.pgTips.SuspendLayout();
            this.pgNotes.SuspendLayout();
            this.pgSigmoid.SuspendLayout();
            this.pgHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHelper
            // 
            this.tabHelper.Controls.Add(this.pgWelcome);
            this.tabHelper.Controls.Add(this.pgTemplatesTut);
            this.tabHelper.Controls.Add(this.pgAnalyseTut);
            this.tabHelper.Controls.Add(this.pgTips);
            this.tabHelper.Controls.Add(this.pgNotes);
            this.tabHelper.Controls.Add(this.pgSigmoid);
            this.tabHelper.Controls.Add(this.pgHash);
            this.tabHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabHelper.ItemSize = new System.Drawing.Size(90, 25);
            this.tabHelper.Location = new System.Drawing.Point(8, 8);
            this.tabHelper.Margin = new System.Windows.Forms.Padding(2);
            this.tabHelper.Name = "tabHelper";
            this.tabHelper.SelectedIndex = 0;
            this.tabHelper.Size = new System.Drawing.Size(638, 355);
            this.tabHelper.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabHelper.TabIndex = 0;
            this.tabHelper.SelectedIndexChanged += new System.EventHandler(this.tabHelper_SelectedIndexChanged);
            // 
            // pgWelcome
            // 
            this.pgWelcome.Controls.Add(this.rtxtWelcome);
            this.pgWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgWelcome.Location = new System.Drawing.Point(4, 29);
            this.pgWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.pgWelcome.Name = "pgWelcome";
            this.pgWelcome.Padding = new System.Windows.Forms.Padding(2);
            this.pgWelcome.Size = new System.Drawing.Size(630, 322);
            this.pgWelcome.TabIndex = 0;
            this.pgWelcome.Text = "Welcome";
            this.pgWelcome.UseVisualStyleBackColor = true;
            // 
            // rtxtWelcome
            // 
            this.rtxtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtWelcome.Location = new System.Drawing.Point(4, 4);
            this.rtxtWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtWelcome.Name = "rtxtWelcome";
            this.rtxtWelcome.ReadOnly = true;
            this.rtxtWelcome.Size = new System.Drawing.Size(622, 316);
            this.rtxtWelcome.TabIndex = 0;
            this.rtxtWelcome.Text = "";
            // 
            // pgTemplatesTut
            // 
            this.pgTemplatesTut.Controls.Add(this.rtxtTemplates);
            this.pgTemplatesTut.Location = new System.Drawing.Point(4, 29);
            this.pgTemplatesTut.Margin = new System.Windows.Forms.Padding(2);
            this.pgTemplatesTut.Name = "pgTemplatesTut";
            this.pgTemplatesTut.Size = new System.Drawing.Size(630, 322);
            this.pgTemplatesTut.TabIndex = 4;
            this.pgTemplatesTut.Text = "Templates";
            this.pgTemplatesTut.UseVisualStyleBackColor = true;
            // 
            // rtxtTemplates
            // 
            this.rtxtTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTemplates.Location = new System.Drawing.Point(4, 4);
            this.rtxtTemplates.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtTemplates.Name = "rtxtTemplates";
            this.rtxtTemplates.ReadOnly = true;
            this.rtxtTemplates.Size = new System.Drawing.Size(624, 316);
            this.rtxtTemplates.TabIndex = 2;
            this.rtxtTemplates.Text = "";
            // 
            // pgAnalyseTut
            // 
            this.pgAnalyseTut.Controls.Add(this.rtxtAnalyse);
            this.pgAnalyseTut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgAnalyseTut.Location = new System.Drawing.Point(4, 29);
            this.pgAnalyseTut.Margin = new System.Windows.Forms.Padding(2);
            this.pgAnalyseTut.Name = "pgAnalyseTut";
            this.pgAnalyseTut.Padding = new System.Windows.Forms.Padding(2);
            this.pgAnalyseTut.Size = new System.Drawing.Size(630, 322);
            this.pgAnalyseTut.TabIndex = 1;
            this.pgAnalyseTut.Text = "Analysing";
            this.pgAnalyseTut.UseVisualStyleBackColor = true;
            // 
            // rtxtAnalyse
            // 
            this.rtxtAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtAnalyse.Location = new System.Drawing.Point(4, 4);
            this.rtxtAnalyse.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtAnalyse.Name = "rtxtAnalyse";
            this.rtxtAnalyse.ReadOnly = true;
            this.rtxtAnalyse.Size = new System.Drawing.Size(622, 316);
            this.rtxtAnalyse.TabIndex = 1;
            this.rtxtAnalyse.Text = "";
            // 
            // pgTips
            // 
            this.pgTips.Controls.Add(this.rtxtTips);
            this.pgTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgTips.Location = new System.Drawing.Point(4, 29);
            this.pgTips.Margin = new System.Windows.Forms.Padding(2);
            this.pgTips.Name = "pgTips";
            this.pgTips.Size = new System.Drawing.Size(630, 322);
            this.pgTips.TabIndex = 2;
            this.pgTips.Text = "Tips";
            this.pgTips.UseVisualStyleBackColor = true;
            // 
            // rtxtTips
            // 
            this.rtxtTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtTips.Location = new System.Drawing.Point(4, 4);
            this.rtxtTips.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtTips.Name = "rtxtTips";
            this.rtxtTips.ReadOnly = true;
            this.rtxtTips.Size = new System.Drawing.Size(624, 316);
            this.rtxtTips.TabIndex = 1;
            this.rtxtTips.Text = "";
            // 
            // pgNotes
            // 
            this.pgNotes.Controls.Add(this.rtxtImportant);
            this.pgNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgNotes.Location = new System.Drawing.Point(4, 29);
            this.pgNotes.Margin = new System.Windows.Forms.Padding(2);
            this.pgNotes.Name = "pgNotes";
            this.pgNotes.Size = new System.Drawing.Size(630, 322);
            this.pgNotes.TabIndex = 3;
            this.pgNotes.Text = "Important";
            this.pgNotes.UseVisualStyleBackColor = true;
            // 
            // rtxtImportant
            // 
            this.rtxtImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtImportant.Location = new System.Drawing.Point(4, 4);
            this.rtxtImportant.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtImportant.Name = "rtxtImportant";
            this.rtxtImportant.ReadOnly = true;
            this.rtxtImportant.Size = new System.Drawing.Size(624, 316);
            this.rtxtImportant.TabIndex = 1;
            this.rtxtImportant.Text = "";
            // 
            // pgSigmoid
            // 
            this.pgSigmoid.Controls.Add(this.rtxtSigmoid);
            this.pgSigmoid.Location = new System.Drawing.Point(4, 29);
            this.pgSigmoid.Name = "pgSigmoid";
            this.pgSigmoid.Padding = new System.Windows.Forms.Padding(3);
            this.pgSigmoid.Size = new System.Drawing.Size(630, 322);
            this.pgSigmoid.TabIndex = 5;
            this.pgSigmoid.Text = "Sigmoid";
            this.pgSigmoid.UseVisualStyleBackColor = true;
            // 
            // rtxtSigmoid
            // 
            this.rtxtSigmoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtxtSigmoid.Location = new System.Drawing.Point(3, 3);
            this.rtxtSigmoid.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtSigmoid.Name = "rtxtSigmoid";
            this.rtxtSigmoid.ReadOnly = true;
            this.rtxtSigmoid.Size = new System.Drawing.Size(624, 317);
            this.rtxtSigmoid.TabIndex = 2;
            this.rtxtSigmoid.Text = "";
            // 
            // pgHash
            // 
            this.pgHash.Controls.Add(this.btnCopyHash);
            this.pgHash.Controls.Add(this.rtxtHash);
            this.pgHash.Location = new System.Drawing.Point(4, 29);
            this.pgHash.Name = "pgHash";
            this.pgHash.Padding = new System.Windows.Forms.Padding(3);
            this.pgHash.Size = new System.Drawing.Size(630, 322);
            this.pgHash.TabIndex = 6;
            this.pgHash.Text = "Hash";
            this.pgHash.UseVisualStyleBackColor = true;
            // 
            // btnCopyHash
            // 
            this.btnCopyHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHash.Location = new System.Drawing.Point(526, 287);
            this.btnCopyHash.Name = "btnCopyHash";
            this.btnCopyHash.Size = new System.Drawing.Size(101, 32);
            this.btnCopyHash.TabIndex = 4;
            this.btnCopyHash.Text = "Copy Hash";
            this.btnCopyHash.UseVisualStyleBackColor = true;
            this.btnCopyHash.Click += new System.EventHandler(this.btnCopyHash_Click);
            // 
            // rtxtHash
            // 
            this.rtxtHash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxtHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtHash.Location = new System.Drawing.Point(3, 3);
            this.rtxtHash.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtHash.Name = "rtxtHash";
            this.rtxtHash.ReadOnly = true;
            this.rtxtHash.Size = new System.Drawing.Size(624, 317);
            this.rtxtHash.TabIndex = 3;
            this.rtxtHash.Text = "";
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 371);
            this.Controls.Add(this.tabHelper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Helper";
            this.Text = "Help";
            this.tabHelper.ResumeLayout(false);
            this.pgWelcome.ResumeLayout(false);
            this.pgTemplatesTut.ResumeLayout(false);
            this.pgAnalyseTut.ResumeLayout(false);
            this.pgTips.ResumeLayout(false);
            this.pgNotes.ResumeLayout(false);
            this.pgSigmoid.ResumeLayout(false);
            this.pgHash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHelper;
        private System.Windows.Forms.TabPage pgWelcome;
        private System.Windows.Forms.TabPage pgAnalyseTut;
        private System.Windows.Forms.TabPage pgTips;
        private System.Windows.Forms.TabPage pgNotes;
        private System.Windows.Forms.RichTextBox rtxtWelcome;
        private System.Windows.Forms.RichTextBox rtxtAnalyse;
        private System.Windows.Forms.RichTextBox rtxtTips;
        private System.Windows.Forms.RichTextBox rtxtImportant;
        private System.Windows.Forms.TabPage pgTemplatesTut;
        private System.Windows.Forms.RichTextBox rtxtTemplates;
        private System.Windows.Forms.TabPage pgSigmoid;
        private System.Windows.Forms.TabPage pgHash;
        private System.Windows.Forms.RichTextBox rtxtSigmoid;
        private System.Windows.Forms.RichTextBox rtxtHash;
        private System.Windows.Forms.Button btnCopyHash;
    }
}