﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Operation);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Operation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Operation);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(155, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operation);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(305, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sin";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(293, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "ln";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(293, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 50);
            this.button8.TabIndex = 10;
            this.button8.Text = "e";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(293, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 50);
            this.button9.TabIndex = 11;
            this.button9.Text = "tg";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(426, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 50);
            this.button10.TabIndex = 12;
            this.button10.Text = "log";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Operation);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(426, 135);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 50);
            this.button11.TabIndex = 13;
            this.button11.Text = "x^2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(426, 209);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 50);
            this.button12.TabIndex = 14;
            this.button12.Text = "ctg";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(562, 61);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 50);
            this.button13.TabIndex = 15;
            this.button13.Text = "log10";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SingleOperation);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(562, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 50);
            this.button14.TabIndex = 16;
            this.button14.Text = "a^x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Operation);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(562, 209);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 50);
            this.button15.TabIndex = 17;
            this.button15.Text = "sqrt";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SingleOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 278);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}

