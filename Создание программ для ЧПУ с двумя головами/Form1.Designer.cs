﻿namespace Создание_программ_для_ЧПУ_с_двумя_головами
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxFirstProgrammName = new System.Windows.Forms.TextBox();
            this.TextBoxSecondProgrammName = new System.Windows.Forms.TextBox();
            this.TextBoxResultName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCCorrectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxFirstProgrammName
            // 
            this.TextBoxFirstProgrammName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstProgrammName.Location = new System.Drawing.Point(33, 33);
            this.TextBoxFirstProgrammName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxFirstProgrammName.Name = "TextBoxFirstProgrammName";
            this.TextBoxFirstProgrammName.Size = new System.Drawing.Size(675, 28);
            this.TextBoxFirstProgrammName.TabIndex = 0;
            // 
            // TextBoxSecondProgrammName
            // 
            this.TextBoxSecondProgrammName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondProgrammName.Location = new System.Drawing.Point(33, 105);
            this.TextBoxSecondProgrammName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxSecondProgrammName.Name = "TextBoxSecondProgrammName";
            this.TextBoxSecondProgrammName.Size = new System.Drawing.Size(675, 28);
            this.TextBoxSecondProgrammName.TabIndex = 1;
            // 
            // TextBoxResultName
            // 
            this.TextBoxResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxResultName.Location = new System.Drawing.Point(33, 196);
            this.TextBoxResultName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxResultName.Name = "TextBoxResultName";
            this.TextBoxResultName.Size = new System.Drawing.Size(675, 28);
            this.TextBoxResultName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите имя для сохранения созданной программы";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(768, 169);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 86);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выбрать папку для сохранения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Имя первой программы";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(717, 20);
            this.button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(229, 58);
            this.button.TabIndex = 13;
            this.button.Text = "Выбрать первый файл";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(717, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 69);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выбрать второй    файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "Имя второй программы";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.InitialDirectory = "resultFileName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Создание_программ_для_ЧПУ_с_двумя_головами.Properties.Resources.Безымянный_11;
            this.pictureBox1.Location = new System.Drawing.Point(33, 238);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 246);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(433, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Открыть созданный файл в NC Corrector после его создания";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПриложенииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCCorrectorToolStripMenuItem,
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // nCCorrectorToolStripMenuItem
            // 
            this.nCCorrectorToolStripMenuItem.Name = "nCCorrectorToolStripMenuItem";
            this.nCCorrectorToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.nCCorrectorToolStripMenuItem.Text = "Установка NC Corrector";
            this.nCCorrectorToolStripMenuItem.Click += new System.EventHandler(this.nCCorrectorToolStripMenuItem_Click);
            // 
            // путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem
            // 
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem.Name = "путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem";
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem.Text = "Путь к NC Corrector ";
            this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem.Click += new System.EventHandler(this.путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem_Click);
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "Путь к NC Corrector";
            // 
            // Form1
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 283);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxResultName);
            this.Controls.Add(this.TextBoxSecondProgrammName);
            this.Controls.Add(this.TextBoxFirstProgrammName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер под мультиинструмент";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFirstProgrammName;
        private System.Windows.Forms.TextBox TextBoxSecondProgrammName;
        private System.Windows.Forms.TextBox TextBoxResultName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nCCorrectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКNCCorrectorНаВашемКомпьютереToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
    }
}

