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
            this.Col_Variable = new System.Windows.Forms.NumericUpDown();
            this.Unit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.меню1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меню2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Map = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Col_Variable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Col_Variable
            // 
            this.Col_Variable.Location = new System.Drawing.Point(12, 51);
            this.Col_Variable.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Col_Variable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Col_Variable.Name = "Col_Variable";
            this.Col_Variable.Size = new System.Drawing.Size(33, 20);
            this.Col_Variable.TabIndex = 1;
            this.Col_Variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Variable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Col_Variable.ValueChanged += new System.EventHandler(this.Col_Variable_ValueChanged);
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(12, 77);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(75, 23);
            this.Unit.TabIndex = 2;
            this.Unit.Text = "Склеить";
            this.Unit.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
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
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Map.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Map.Location = new System.Drawing.Point(12, 106);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(841, 421);
            this.Map.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 536);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Col_Variable);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Минимизация карты Карно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Col_Variable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Col_Variable;
        private System.Windows.Forms.Button Unit;
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
    }
}

