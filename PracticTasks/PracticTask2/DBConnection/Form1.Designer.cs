﻿namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяОтБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБазойДанныхToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБазойДанныхToolStripMenuItem
            // 
            this.работаСБазойДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБазеДанныхToolStripMenuItem,
            this.отключитьсяОтБазыДанныхToolStripMenuItem,
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem});
            this.работаСБазойДанныхToolStripMenuItem.Name = "работаСБазойДанныхToolStripMenuItem";
            this.работаСБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.работаСБазойДанныхToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // подключитьсяКБазеДанныхToolStripMenuItem
            // 
            this.подключитьсяКБазеДанныхToolStripMenuItem.Name = "подключитьсяКБазеДанныхToolStripMenuItem";
            this.подключитьсяКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.подключитьсяКБазеДанныхToolStripMenuItem.Text = "Подключиться к базе данных";
            this.подключитьсяКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКБазеДанныхToolStripMenuItem_Click);
            // 
            // отключитьсяОтБазыДанныхToolStripMenuItem
            // 
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Name = "отключитьсяОтБазыДанныхToolStripMenuItem";
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Text = "Отключиться от базы данных";
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяОтБазыДанныхToolStripMenuItem_Click);
            // 
            // асинхронноеПодключениеКБазеДанныхToolStripMenuItem
            // 
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Name = "асинхронноеПодключениеКБазеДанныхToolStripMenuItem";
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Text = "Асинхронное подключение к базе данных";
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сколько продуктов ещё раз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(329, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Список продуктов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(520, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 403);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            this.columnHeader3.Width = 98;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(978, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Транзакция";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 626);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяОтБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асинхронноеПодключениеКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button4;
    }
}

