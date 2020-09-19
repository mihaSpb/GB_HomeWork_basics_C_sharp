namespace Ex72
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
            this.lblEnterTheNumber = new System.Windows.Forms.Label();
            this.tboxUserAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblStepText = new System.Windows.Forms.Label();
            this.lblStepCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterTheNumber
            // 
            this.lblEnterTheNumber.AutoSize = true;
            this.lblEnterTheNumber.Location = new System.Drawing.Point(119, 37);
            this.lblEnterTheNumber.Name = "lblEnterTheNumber";
            this.lblEnterTheNumber.Size = new System.Drawing.Size(46, 17);
            this.lblEnterTheNumber.TabIndex = 0;
            this.lblEnterTheNumber.Text = "label1";
            // 
            // tboxUserAnswer
            // 
            this.tboxUserAnswer.Location = new System.Drawing.Point(27, 69);
            this.tboxUserAnswer.Name = "tboxUserAnswer";
            this.tboxUserAnswer.Size = new System.Drawing.Size(290, 22);
            this.tboxUserAnswer.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(102, 106);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 34);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // lblStepText
            // 
            this.lblStepText.AutoSize = true;
            this.lblStepText.Location = new System.Drawing.Point(24, 150);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(46, 17);
            this.lblStepText.TabIndex = 3;
            this.lblStepText.Text = "label2";
            // 
            // lblStepCount
            // 
            this.lblStepCount.AutoSize = true;
            this.lblStepCount.Location = new System.Drawing.Point(271, 150);
            this.lblStepCount.Name = "lblStepCount";
            this.lblStepCount.Size = new System.Drawing.Size(46, 17);
            this.lblStepCount.TabIndex = 4;
            this.lblStepCount.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 225);
            this.Controls.Add(this.lblStepCount);
            this.Controls.Add(this.lblStepText);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tboxUserAnswer);
            this.Controls.Add(this.lblEnterTheNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTheNumber;
        private System.Windows.Forms.TextBox tboxUserAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStepText;
        private System.Windows.Forms.Label lblStepCount;
    }
}

