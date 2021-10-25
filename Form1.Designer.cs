namespace RandomBirthDate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AgeText = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.TextBox();
            this.GetRandom = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(45, 12);
            this.AgeText.MaxLength = 4;
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(100, 20);
            this.AgeText.TabIndex = 0;
            this.AgeText.Text = "0";
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(45, 54);
            this.DateText.Name = "DateText";
            this.DateText.ReadOnly = true;
            this.DateText.Size = new System.Drawing.Size(100, 20);
            this.DateText.TabIndex = 1;
            // 
            // GetRandom
            // 
            this.GetRandom.Location = new System.Drawing.Point(45, 116);
            this.GetRandom.Name = "GetRandom";
            this.GetRandom.Size = new System.Drawing.Size(119, 33);
            this.GetRandom.TabIndex = 2;
            this.GetRandom.Text = "Сгенерировать";
            this.GetRandom.UseVisualStyleBackColor = true;
            this.GetRandom.Click += new System.EventHandler(this.GetRandom_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(151, 15);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(195, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Приблизительный Возраст (0-любой)";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(151, 57);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(96, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Полученная Дата";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 189);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.GetRandom);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.AgeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RandomBD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.Button GetRandom;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox AgeText;
    }
}

