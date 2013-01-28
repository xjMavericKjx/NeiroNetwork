namespace NeuralWin
{
    partial class UIMainForm
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
            this.UIErrorRateOnTrainingDataTextBox = new System.Windows.Forms.TextBox();
            this.UIEducationOnTrainingDataButton = new System.Windows.Forms.Button();
            this.UIReadDataButton = new System.Windows.Forms.Button();
            this.UICheckOnTrainingDataButton = new System.Windows.Forms.Button();
            this.UICheckOnValidateDataButton = new System.Windows.Forms.Button();
            this.UIErrorRateOnValidateDataTextBox = new System.Windows.Forms.TextBox();
            this.UICheckOnTestDataButton = new System.Windows.Forms.Button();
            this.UIErrorRateOnTestDataTextBox = new System.Windows.Forms.TextBox();
            this.UIEducationOnValidateDataButton = new System.Windows.Forms.Button();
            this.UIEducationOnTestDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIErrorRateOnTrainingDataTextBox
            // 
            this.UIErrorRateOnTrainingDataTextBox.Location = new System.Drawing.Point(90, 99);
            this.UIErrorRateOnTrainingDataTextBox.Name = "UIErrorRateOnTrainingDataTextBox";
            this.UIErrorRateOnTrainingDataTextBox.Size = new System.Drawing.Size(46, 20);
            this.UIErrorRateOnTrainingDataTextBox.TabIndex = 8;
            // 
            // UIEducationOnTrainingDataButton
            // 
            this.UIEducationOnTrainingDataButton.Location = new System.Drawing.Point(12, 41);
            this.UIEducationOnTrainingDataButton.Name = "UIEducationOnTrainingDataButton";
            this.UIEducationOnTrainingDataButton.Size = new System.Drawing.Size(208, 23);
            this.UIEducationOnTrainingDataButton.TabIndex = 9;
            this.UIEducationOnTrainingDataButton.Text = "Обучение на обучающей выборке";
            this.UIEducationOnTrainingDataButton.UseVisualStyleBackColor = true;
            this.UIEducationOnTrainingDataButton.Click += new System.EventHandler(this.UIEducationOnTrainingDataButton_Click);
            // 
            // UIReadDataButton
            // 
            this.UIReadDataButton.Location = new System.Drawing.Point(226, 12);
            this.UIReadDataButton.Name = "UIReadDataButton";
            this.UIReadDataButton.Size = new System.Drawing.Size(208, 23);
            this.UIReadDataButton.TabIndex = 11;
            this.UIReadDataButton.Text = "Загрузить данные";
            this.UIReadDataButton.UseVisualStyleBackColor = true;
            this.UIReadDataButton.Click += new System.EventHandler(this.UIReadDataButton_Click);
            // 
            // UICheckOnTrainingDataButton
            // 
            this.UICheckOnTrainingDataButton.Location = new System.Drawing.Point(12, 70);
            this.UICheckOnTrainingDataButton.Name = "UICheckOnTrainingDataButton";
            this.UICheckOnTrainingDataButton.Size = new System.Drawing.Size(208, 23);
            this.UICheckOnTrainingDataButton.TabIndex = 12;
            this.UICheckOnTrainingDataButton.Text = "Проверка на обучающей выборке";
            this.UICheckOnTrainingDataButton.UseVisualStyleBackColor = true;
            this.UICheckOnTrainingDataButton.Click += new System.EventHandler(this.UICheckOnTrainingDataButton_Click);
            // 
            // UICheckOnValidateDataButton
            // 
            this.UICheckOnValidateDataButton.Location = new System.Drawing.Point(226, 70);
            this.UICheckOnValidateDataButton.Name = "UICheckOnValidateDataButton";
            this.UICheckOnValidateDataButton.Size = new System.Drawing.Size(208, 23);
            this.UICheckOnValidateDataButton.TabIndex = 15;
            this.UICheckOnValidateDataButton.Text = "Проверка на валидационной выборке";
            this.UICheckOnValidateDataButton.UseVisualStyleBackColor = true;
            this.UICheckOnValidateDataButton.Click += new System.EventHandler(this.UICheckOnValidateDataButton_Click);
            // 
            // UIErrorRateOnValidateDataTextBox
            // 
            this.UIErrorRateOnValidateDataTextBox.Location = new System.Drawing.Point(309, 99);
            this.UIErrorRateOnValidateDataTextBox.Name = "UIErrorRateOnValidateDataTextBox";
            this.UIErrorRateOnValidateDataTextBox.Size = new System.Drawing.Size(46, 20);
            this.UIErrorRateOnValidateDataTextBox.TabIndex = 13;
            // 
            // UICheckOnTestDataButton
            // 
            this.UICheckOnTestDataButton.Location = new System.Drawing.Point(440, 70);
            this.UICheckOnTestDataButton.Name = "UICheckOnTestDataButton";
            this.UICheckOnTestDataButton.Size = new System.Drawing.Size(208, 23);
            this.UICheckOnTestDataButton.TabIndex = 18;
            this.UICheckOnTestDataButton.Text = "Проверка на тестовой выборке";
            this.UICheckOnTestDataButton.UseVisualStyleBackColor = true;
            this.UICheckOnTestDataButton.Click += new System.EventHandler(this.UICheckOnTestDataButton_Click);
            // 
            // UIErrorRateOnTestDataTextBox
            // 
            this.UIErrorRateOnTestDataTextBox.Location = new System.Drawing.Point(528, 99);
            this.UIErrorRateOnTestDataTextBox.Name = "UIErrorRateOnTestDataTextBox";
            this.UIErrorRateOnTestDataTextBox.Size = new System.Drawing.Size(46, 20);
            this.UIErrorRateOnTestDataTextBox.TabIndex = 16;
            // 
            // UIEducationOnValidateDataButton
            // 
            this.UIEducationOnValidateDataButton.Location = new System.Drawing.Point(226, 41);
            this.UIEducationOnValidateDataButton.Name = "UIEducationOnValidateDataButton";
            this.UIEducationOnValidateDataButton.Size = new System.Drawing.Size(208, 23);
            this.UIEducationOnValidateDataButton.TabIndex = 19;
            this.UIEducationOnValidateDataButton.Text = "Обучение на валидационной выборке";
            this.UIEducationOnValidateDataButton.UseVisualStyleBackColor = true;
            this.UIEducationOnValidateDataButton.Click += new System.EventHandler(this.UIEducationOnValidateDataButton_Click);
            // 
            // UIEducationOnTestDataButton
            // 
            this.UIEducationOnTestDataButton.Location = new System.Drawing.Point(440, 41);
            this.UIEducationOnTestDataButton.Name = "UIEducationOnTestDataButton";
            this.UIEducationOnTestDataButton.Size = new System.Drawing.Size(208, 23);
            this.UIEducationOnTestDataButton.TabIndex = 20;
            this.UIEducationOnTestDataButton.Text = "Обучение на тестовой выборке";
            this.UIEducationOnTestDataButton.UseVisualStyleBackColor = true;
            this.UIEducationOnTestDataButton.Click += new System.EventHandler(this.UIEducationOnTestDataButton_Click);
            // 
            // UIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 132);
            this.Controls.Add(this.UIEducationOnTestDataButton);
            this.Controls.Add(this.UIEducationOnValidateDataButton);
            this.Controls.Add(this.UICheckOnTestDataButton);
            this.Controls.Add(this.UIErrorRateOnTestDataTextBox);
            this.Controls.Add(this.UICheckOnValidateDataButton);
            this.Controls.Add(this.UIErrorRateOnValidateDataTextBox);
            this.Controls.Add(this.UICheckOnTrainingDataButton);
            this.Controls.Add(this.UIReadDataButton);
            this.Controls.Add(this.UIEducationOnTrainingDataButton);
            this.Controls.Add(this.UIErrorRateOnTrainingDataTextBox);
            this.Name = "UIMainForm";
            this.Text = "Нейронная сеть";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UIErrorRateOnTrainingDataTextBox;
        private System.Windows.Forms.Button UIEducationOnTrainingDataButton;
        private System.Windows.Forms.Button UIReadDataButton;
        private System.Windows.Forms.Button UICheckOnTrainingDataButton;
        private System.Windows.Forms.Button UICheckOnValidateDataButton;
        private System.Windows.Forms.TextBox UIErrorRateOnValidateDataTextBox;
        private System.Windows.Forms.Button UICheckOnTestDataButton;
        private System.Windows.Forms.TextBox UIErrorRateOnTestDataTextBox;
        private System.Windows.Forms.Button UIEducationOnValidateDataButton;
        private System.Windows.Forms.Button UIEducationOnTestDataButton;
    }
}

