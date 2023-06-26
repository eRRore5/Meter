
namespace Meter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainFileButton = new System.Windows.Forms.Button();
            this.mainFileTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalFileButton = new System.Windows.Forms.Button();
            this.AddAdditionalFileButton = new System.Windows.Forms.Button();
            this.ResFileTextBox = new System.Windows.Forms.TextBox();
            this.ResFIleButton_Click = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.SepButton = new System.Windows.Forms.Button();
            this.additionalFilesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Основной файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файлы РЭСов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Разделение по РЭС";
            // 
            // MainFileButton
            // 
            this.MainFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainFileButton.BackgroundImage")));
            this.MainFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainFileButton.Location = new System.Drawing.Point(639, 25);
            this.MainFileButton.Name = "MainFileButton";
            this.MainFileButton.Size = new System.Drawing.Size(34, 23);
            this.MainFileButton.TabIndex = 3;
            this.MainFileButton.UseVisualStyleBackColor = true;
            this.MainFileButton.Click += new System.EventHandler(this.MainFIleButton_Click);
            // 
            // mainFileTextBox
            // 
            this.mainFileTextBox.Location = new System.Drawing.Point(200, 25);
            this.mainFileTextBox.Name = "mainFileTextBox";
            this.mainFileTextBox.Size = new System.Drawing.Size(433, 22);
            this.mainFileTextBox.TabIndex = 4;
            // 
            // AdditionalFileButton
            // 
            this.AdditionalFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdditionalFileButton.BackgroundImage")));
            this.AdditionalFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdditionalFileButton.Location = new System.Drawing.Point(639, 66);
            this.AdditionalFileButton.Name = "AdditionalFileButton";
            this.AdditionalFileButton.Size = new System.Drawing.Size(34, 23);
            this.AdditionalFileButton.TabIndex = 8;
            this.AdditionalFileButton.UseVisualStyleBackColor = true;
            this.AdditionalFileButton.Click += new System.EventHandler(this.AdditionalFileButton_Click);
            // 
            // AddAdditionalFileButton
            // 
            this.AddAdditionalFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddAdditionalFileButton.BackgroundImage")));
            this.AddAdditionalFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddAdditionalFileButton.Location = new System.Drawing.Point(679, 66);
            this.AddAdditionalFileButton.Name = "AddAdditionalFileButton";
            this.AddAdditionalFileButton.Size = new System.Drawing.Size(34, 23);
            this.AddAdditionalFileButton.TabIndex = 9;
            this.AddAdditionalFileButton.UseVisualStyleBackColor = true;
            this.AddAdditionalFileButton.Click += new System.EventHandler(this.AddAdditionalFileButton_Click);
            // 
            // ResFileTextBox
            // 
            this.ResFileTextBox.Location = new System.Drawing.Point(200, 138);
            this.ResFileTextBox.Name = "ResFileTextBox";
            this.ResFileTextBox.Size = new System.Drawing.Size(433, 22);
            this.ResFileTextBox.TabIndex = 10;
            // 
            // ResFIleButton_Click
            // 
            this.ResFIleButton_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResFIleButton_Click.BackgroundImage")));
            this.ResFIleButton_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ResFIleButton_Click.Location = new System.Drawing.Point(639, 138);
            this.ResFIleButton_Click.Name = "ResFIleButton_Click";
            this.ResFIleButton_Click.Size = new System.Drawing.Size(34, 23);
            this.ResFIleButton_Click.TabIndex = 11;
            this.ResFIleButton_Click.UseVisualStyleBackColor = true;
            this.ResFIleButton_Click.Click += new System.EventHandler(this.ResFIleButton_Click_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.Location = new System.Drawing.Point(357, 94);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(102, 23);
            this.MergeButton.TabIndex = 12;
            this.MergeButton.Text = "Объединить";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // SepButton
            // 
            this.SepButton.Location = new System.Drawing.Point(357, 166);
            this.SepButton.Name = "SepButton";
            this.SepButton.Size = new System.Drawing.Size(102, 23);
            this.SepButton.TabIndex = 13;
            this.SepButton.Text = "Разделить";
            this.SepButton.UseVisualStyleBackColor = true;
            this.SepButton.Click += new System.EventHandler(this.SepButton_Click);
            // 
            // additionalFilesListBox
            // 
            this.additionalFilesListBox.FormattingEnabled = true;
            this.additionalFilesListBox.ItemHeight = 16;
            this.additionalFilesListBox.Location = new System.Drawing.Point(200, 66);
            this.additionalFilesListBox.Name = "additionalFilesListBox";
            this.additionalFilesListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.additionalFilesListBox.Size = new System.Drawing.Size(433, 20);
            this.additionalFilesListBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(722, 192);
            this.Controls.Add(this.additionalFilesListBox);
            this.Controls.Add(this.SepButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.ResFIleButton_Click);
            this.Controls.Add(this.ResFileTextBox);
            this.Controls.Add(this.AddAdditionalFileButton);
            this.Controls.Add(this.AdditionalFileButton);
            this.Controls.Add(this.mainFileTextBox);
            this.Controls.Add(this.MainFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MainFileButton;
        private System.Windows.Forms.TextBox mainFileTextBox;
        private System.Windows.Forms.Button AdditionalFileButton;
        private System.Windows.Forms.Button AddAdditionalFileButton;
        private System.Windows.Forms.TextBox ResFileTextBox;
        private System.Windows.Forms.Button ResFIleButton_Click;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Button SepButton;
        private System.Windows.Forms.ListBox additionalFilesListBox;
    }
}

