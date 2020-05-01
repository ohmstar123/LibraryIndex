namespace LibraryIndex
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.referenceNumberInput = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linearSearchOutput = new System.Windows.Forms.Label();
            this.binarySearchOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Children\'s Classics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER THE REFERENCE #:";
            // 
            // referenceNumberInput
            // 
            this.referenceNumberInput.Location = new System.Drawing.Point(386, 101);
            this.referenceNumberInput.Name = "referenceNumberInput";
            this.referenceNumberInput.Size = new System.Drawing.Size(100, 26);
            this.referenceNumberInput.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(536, 98);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(115, 32);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find It!";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Linear Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Binary Search:";
            // 
            // linearSearchOutput
            // 
            this.linearSearchOutput.BackColor = System.Drawing.Color.White;
            this.linearSearchOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linearSearchOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.linearSearchOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearSearchOutput.Location = new System.Drawing.Point(190, 211);
            this.linearSearchOutput.Name = "linearSearchOutput";
            this.linearSearchOutput.Size = new System.Drawing.Size(385, 25);
            this.linearSearchOutput.TabIndex = 8;
            this.linearSearchOutput.Text = "OUTPUT";
            // 
            // binarySearchOutput
            // 
            this.binarySearchOutput.BackColor = System.Drawing.Color.White;
            this.binarySearchOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binarySearchOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.binarySearchOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binarySearchOutput.Location = new System.Drawing.Point(190, 294);
            this.binarySearchOutput.Name = "binarySearchOutput";
            this.binarySearchOutput.Size = new System.Drawing.Size(385, 25);
            this.binarySearchOutput.TabIndex = 9;
            this.binarySearchOutput.Text = "OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.binarySearchOutput);
            this.Controls.Add(this.linearSearchOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.referenceNumberInput);
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
        private System.Windows.Forms.TextBox referenceNumberInput;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label linearSearchOutput;
        private System.Windows.Forms.Label binarySearchOutput;
    }
}

