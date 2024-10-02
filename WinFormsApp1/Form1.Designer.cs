namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            btnSort = new Button();
            btnSerialize = new Button();
            btnDeserialize = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(24, 398);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(169, 40);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(212, 398);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(169, 40);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(399, 398);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(169, 40);
            btnSerialize.TabIndex = 2;
            btnSerialize.Text = "Serialize";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(585, 398);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(169, 40);
            btnDeserialize.TabIndex = 3;
            btnDeserialize.Text = "Deserialize";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(24, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(730, 364);
            listBox.TabIndex = 4;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(btnDeserialize);
            Controls.Add(btnSerialize);
            Controls.Add(btnSort);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnSort;
        private Button btnSerialize;
        private Button btnDeserialize;
        private ListBox listBox;
    }
}
