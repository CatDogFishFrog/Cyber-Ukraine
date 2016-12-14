namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Paste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.меню1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меню2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.DataGridView();
            this.VarF = new System.Windows.Forms.TextBox();
            this.VarS = new System.Windows.Forms.TextBox();
            this.Outp = new System.Windows.Forms.TextBox();
            this.Build = new System.Windows.Forms.Button();
            this.VarCol = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(95, 80);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(75, 23);
            this.Paste.TabIndex = 2;
            this.Paste.Text = "Склеить";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество переменных";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.меню1ToolStripMenuItem,
            this.меню2ToolStripMenuItem,
            this.менюnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // меню1ToolStripMenuItem
            // 
            this.меню1ToolStripMenuItem.Name = "меню1ToolStripMenuItem";
            this.меню1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.меню1ToolStripMenuItem.Text = "Меню 1";
            // 
            // меню2ToolStripMenuItem
            // 
            this.меню2ToolStripMenuItem.Name = "меню2ToolStripMenuItem";
            this.меню2ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.меню2ToolStripMenuItem.Text = "Меню 2";
            // 
            // менюnToolStripMenuItem
            // 
            this.менюnToolStripMenuItem.Name = "менюnToolStripMenuItem";
            this.менюnToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.менюnToolStripMenuItem.Text = "Меню \"n\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Карта Карно";
            // 
            // Map
            // 
            this.Map.AllowUserToAddRows = false;
            this.Map.AllowUserToDeleteRows = false;
            this.Map.BackgroundColor = System.Drawing.Color.Khaki;
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Map.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Map.GridColor = System.Drawing.SystemColors.Highlight;
            this.Map.Location = new System.Drawing.Point(37, 129);
            this.Map.Name = "Map";
            this.Map.RowHeadersWidth = 60;
            this.Map.Size = new System.Drawing.Size(877, 205);
            this.Map.TabIndex = 5;
            // 
            // VarF
            // 
            this.VarF.Location = new System.Drawing.Point(32, 103);
            this.VarF.Name = "VarF";
            this.VarF.Size = new System.Drawing.Size(100, 20);
            this.VarF.TabIndex = 6;
            // 
            // VarS
            // 
            this.VarS.Location = new System.Drawing.Point(12, 129);
            this.VarS.Multiline = true;
            this.VarS.Name = "VarS";
            this.VarS.Size = new System.Drawing.Size(19, 94);
            this.VarS.TabIndex = 7;
            // 
            // Outp
            // 
            this.Outp.Location = new System.Drawing.Point(225, 27);
            this.Outp.Multiline = true;
            this.Outp.Name = "Outp";
            this.Outp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Outp.Size = new System.Drawing.Size(545, 96);
            this.Outp.TabIndex = 8;
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(95, 51);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(75, 23);
            this.Build.TabIndex = 9;
            this.Build.Text = "Построить";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // VarCol
            // 
            this.VarCol.Location = new System.Drawing.Point(12, 53);
            this.VarCol.Name = "VarCol";
            this.VarCol.Size = new System.Drawing.Size(77, 20);
            this.VarCol.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 346);
            this.Controls.Add(this.VarCol);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Outp);
            this.Controls.Add(this.VarS);
            this.Controls.Add(this.VarF);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Минимизация карты Карно";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem меню1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem меню2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюnToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Map;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.TextBox VarF;
        private System.Windows.Forms.TextBox VarS;
        private System.Windows.Forms.TextBox Outp;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.TextBox VarCol;
    }
}

