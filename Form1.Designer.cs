namespace Caesar_Code
{
    partial class form
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
            this.input = new System.Windows.Forms.TextBox();
            this.output_code = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Button();
            this.Smart_Decode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shift = new System.Windows.Forms.TextBox();
            this.cls = new System.Windows.Forms.Button();
            this.cls_all = new System.Windows.Forms.Button();
            this.decode_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 25);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(355, 122);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // output_code
            // 
            this.output_code.Location = new System.Drawing.Point(433, 25);
            this.output_code.Multiline = true;
            this.output_code.Name = "output_code";
            this.output_code.ReadOnly = true;
            this.output_code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_code.Size = new System.Drawing.Size(355, 122);
            this.output_code.TabIndex = 1;
            // 
            // code
            // 
            this.code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.code.Location = new System.Drawing.Point(373, 12);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(54, 23);
            this.code.TabIndex = 2;
            this.code.Text = "Code";
            this.code.UseVisualStyleBackColor = true;
            this.code.Click += new System.EventHandler(this.code_Click);
            // 
            // Smart_Decode
            // 
            this.Smart_Decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Smart_Decode.Location = new System.Drawing.Point(373, 42);
            this.Smart_Decode.Name = "Smart_Decode";
            this.Smart_Decode.Size = new System.Drawing.Size(54, 34);
            this.Smart_Decode.TabIndex = 3;
            this.Smart_Decode.Text = "Smart decode";
            this.Smart_Decode.UseVisualStyleBackColor = true;
            this.Smart_Decode.Click += new System.EventHandler(this.Smart_Decode_Click);
            // 
            // decode
            // 
            this.decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decode.Location = new System.Drawing.Point(373, 124);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(54, 23);
            this.decode.TabIndex = 4;
            this.decode.Text = "Decode";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Converted text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shift:";
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(407, 150);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(20, 20);
            this.shift.TabIndex = 8;
            this.shift.Text = "0";
            this.shift.TextChanged += new System.EventHandler(this.shift_TextChanged);
            // 
            // cls
            // 
            this.cls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cls.Location = new System.Drawing.Point(12, 153);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(75, 23);
            this.cls.TabIndex = 9;
            this.cls.Text = "Clear";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // cls_all
            // 
            this.cls_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cls_all.Location = new System.Drawing.Point(93, 153);
            this.cls_all.Name = "cls_all";
            this.cls_all.Size = new System.Drawing.Size(75, 23);
            this.cls_all.TabIndex = 10;
            this.cls_all.Text = "Clear all";
            this.cls_all.UseVisualStyleBackColor = true;
            this.cls_all.Click += new System.EventHandler(this.cls_all_Click);
            // 
            // decode_all
            // 
            this.decode_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decode_all.Location = new System.Drawing.Point(373, 82);
            this.decode_all.Name = "decode_all";
            this.decode_all.Size = new System.Drawing.Size(54, 36);
            this.decode_all.TabIndex = 11;
            this.decode_all.Text = "Decode all";
            this.decode_all.UseVisualStyleBackColor = true;
            this.decode_all.Click += new System.EventHandler(this.decode_all_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.decode_all);
            this.Controls.Add(this.cls_all);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.Smart_Decode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.output_code);
            this.Controls.Add(this.input);
            this.Name = "form";
            this.ShowIcon = false;
            this.Text = "Caesar\'s code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output_code;
        private System.Windows.Forms.Button code;
        private System.Windows.Forms.Button Smart_Decode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shift;
        private System.Windows.Forms.Button cls;
        private System.Windows.Forms.Button cls_all;
        private System.Windows.Forms.Button decode_all;
    }
}

