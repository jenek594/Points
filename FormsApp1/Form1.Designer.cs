namespace FormsApp1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(36, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(747, 340);
            this.listBox1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(36, 381);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(174, 44);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(229, 381);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(174, 44);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(418, 381);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(174, 44);
            this.btnSerialize.TabIndex = 3;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(609, 381);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(174, 44);
            this.btnDeserialize.TabIndex = 4;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
    }
}

