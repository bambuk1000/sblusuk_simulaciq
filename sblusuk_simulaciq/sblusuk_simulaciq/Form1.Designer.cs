
namespace sblusuk_simulaciq
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
            this.Slot1 = new System.Windows.Forms.Button();
            this.Slot2 = new System.Windows.Forms.Button();
            this.Slot3 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Slot1
            // 
            this.Slot1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Slot1.Location = new System.Drawing.Point(48, 258);
            this.Slot1.Margin = new System.Windows.Forms.Padding(4);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(239, 125);
            this.Slot1.TabIndex = 3;
            this.Slot1.Text = "Slot One";
            this.Slot1.UseVisualStyleBackColor = true;
            // 
            // Slot2
            // 
            this.Slot2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Slot2.Location = new System.Drawing.Point(317, 258);
            this.Slot2.Margin = new System.Windows.Forms.Padding(4);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(239, 125);
            this.Slot2.TabIndex = 1;
            this.Slot2.Text = "Slot Two";
            this.Slot2.UseVisualStyleBackColor = true;
            // 
            // Slot3
            // 
            this.Slot3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Slot3.Location = new System.Drawing.Point(585, 258);
            this.Slot3.Margin = new System.Windows.Forms.Padding(4);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(239, 125);
            this.Slot3.TabIndex = 2;
            this.Slot3.Text = "Slot Three";
            this.Slot3.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(168, 152);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(545, 78);
            this.Title.TabIndex = 0;
            this.Title.Text = "Изберете слот";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Битка Симлулатор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Slot1;
        private System.Windows.Forms.Button Slot2;
        private System.Windows.Forms.Button Slot3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
    }
}

