namespace Интегралы
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
            this.e_text = new System.Windows.Forms.TextBox();
            this.a_text = new System.Windows.Forms.TextBox();
            this.b_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.n_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.step_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.func = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.simps = new System.Windows.Forms.ListBox();
            this.rectangles = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // e_text
            // 
            this.e_text.Location = new System.Drawing.Point(72, 206);
            this.e_text.Name = "e_text";
            this.e_text.Size = new System.Drawing.Size(57, 20);
            this.e_text.TabIndex = 0;
            this.e_text.Text = "0,001";
            // 
            // a_text
            // 
            this.a_text.Location = new System.Drawing.Point(72, 83);
            this.a_text.Name = "a_text";
            this.a_text.Size = new System.Drawing.Size(57, 20);
            this.a_text.TabIndex = 1;
            this.a_text.Text = "0,6";
            // 
            // b_text
            // 
            this.b_text.Location = new System.Drawing.Point(72, 142);
            this.b_text.Name = "b_text";
            this.b_text.Size = new System.Drawing.Size(57, 20);
            this.b_text.TabIndex = 2;
            this.b_text.Text = "2,2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n_text
            // 
            this.n_text.Location = new System.Drawing.Point(473, 83);
            this.n_text.Name = "n_text";
            this.n_text.ReadOnly = true;
            this.n_text.Size = new System.Drawing.Size(67, 20);
            this.n_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "e =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во шагов:";
            // 
            // step_text
            // 
            this.step_text.Location = new System.Drawing.Point(473, 142);
            this.step_text.Name = "step_text";
            this.step_text.ReadOnly = true;
            this.step_text.Size = new System.Drawing.Size(67, 20);
            this.step_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длина шага:";
            // 
            // func
            // 
            this.func.Location = new System.Drawing.Point(72, 27);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(152, 20);
            this.func.TabIndex = 11;
            this.func.Text = "cos(x)/(x^2 + 1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Функция";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Результат по методу Симпсона:";
            // 
            // simps
            // 
            this.simps.FormattingEnabled = true;
            this.simps.Location = new System.Drawing.Point(201, 366);
            this.simps.Name = "simps";
            this.simps.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.simps.Size = new System.Drawing.Size(368, 212);
            this.simps.TabIndex = 15;
            // 
            // rectangles
            // 
            this.rectangles.FormattingEnabled = true;
            this.rectangles.Location = new System.Drawing.Point(625, 366);
            this.rectangles.Name = "rectangles";
            this.rectangles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.rectangles.Size = new System.Drawing.Size(368, 212);
            this.rectangles.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Результат по методу центральных прямоугольников:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Оптимальные параметры:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 630);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rectangles);
            this.Controls.Add(this.simps);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.func);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.step_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_text);
            this.Controls.Add(this.a_text);
            this.Controls.Add(this.e_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox e_text;
        private System.Windows.Forms.TextBox a_text;
        private System.Windows.Forms.TextBox b_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox n_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox step_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox func;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox simps;
        private System.Windows.Forms.ListBox rectangles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

