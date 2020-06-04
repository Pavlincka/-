namespace Курсач2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.внестиДоходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внестиРасходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущийБалансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтатьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "ДОМАШНЯЯ БУХГАЛТЕРИЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 445);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Статья";
            this.columnHeader3.Width = 156;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.внестиДоходыToolStripMenuItem,
            this.внестиРасходыToolStripMenuItem,
            this.текущийБалансToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.добавитьСтатьюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // внестиДоходыToolStripMenuItem
            // 
            this.внестиДоходыToolStripMenuItem.Name = "внестиДоходыToolStripMenuItem";
            this.внестиДоходыToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.внестиДоходыToolStripMenuItem.Text = "Внести доходы";
            this.внестиДоходыToolStripMenuItem.Click += new System.EventHandler(this.внестиДоходыToolStripMenuItem_Click);
            // 
            // внестиРасходыToolStripMenuItem
            // 
            this.внестиРасходыToolStripMenuItem.Name = "внестиРасходыToolStripMenuItem";
            this.внестиРасходыToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.внестиРасходыToolStripMenuItem.Text = "Внести расходы";
            this.внестиРасходыToolStripMenuItem.Click += new System.EventHandler(this.внестиРасходыToolStripMenuItem_Click);
            // 
            // текущийБалансToolStripMenuItem
            // 
            this.текущийБалансToolStripMenuItem.Name = "текущийБалансToolStripMenuItem";
            this.текущийБалансToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.текущийБалансToolStripMenuItem.Text = "Текущий баланс";
            this.текущийБалансToolStripMenuItem.Click += new System.EventHandler(this.текущийБалансToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // добавитьСтатьюToolStripMenuItem
            // 
            this.добавитьСтатьюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доходовToolStripMenuItem,
            this.расходовToolStripMenuItem});
            this.добавитьСтатьюToolStripMenuItem.Name = "добавитьСтатьюToolStripMenuItem";
            this.добавитьСтатьюToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.добавитьСтатьюToolStripMenuItem.Text = "Добавить статью";
            // 
            // доходовToolStripMenuItem
            // 
            this.доходовToolStripMenuItem.Name = "доходовToolStripMenuItem";
            this.доходовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доходовToolStripMenuItem.Text = "Доходов";
            this.доходовToolStripMenuItem.Click += new System.EventHandler(this.доходовToolStripMenuItem_Click);
            // 
            // расходовToolStripMenuItem
            // 
            this.расходовToolStripMenuItem.Name = "расходовToolStripMenuItem";
            this.расходовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расходовToolStripMenuItem.Text = "Расходов";
            this.расходовToolStripMenuItem.Click += new System.EventHandler(this.расходовToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(525, 140);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(481, 445);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Сумма";
            this.columnHeader5.Width = 163;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статья";
            this.columnHeader6.Width = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(182, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расходы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(719, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доходы";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 596);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашняя бухгалтерия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem внестиДоходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внестиРасходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущийБалансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтатьюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходовToolStripMenuItem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

