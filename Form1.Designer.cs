namespace PrimeNumbers
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
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber1.Location = new System.Drawing.Point(40, 118);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(116, 41);
            this.tbNumber1.TabIndex = 0;
            
            // 
            // tbNumber2
            // 
            this.tbNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber2.Location = new System.Drawing.Point(324, 118);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(116, 41);
            this.tbNumber2.TabIndex = 1;
            
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(34, 297);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(400, 170);
            this.lbResult.TabIndex = 2;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStart.Location = new System.Drawing.Point(96, 60);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(300, 36);
            this.lbStart.TabIndex = 3;
            this.lbStart.Text = "Введите два числа:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(65, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(347, 50);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Получить простые числа";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 492);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Button btnCalculate;
    }
}

