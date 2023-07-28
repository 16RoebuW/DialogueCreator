namespace DialogueCreator
{
    partial class Tester
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
            this.lbxDialogue = new System.Windows.Forms.ListBox();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxDialogue
            // 
            this.lbxDialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxDialogue.FormattingEnabled = true;
            this.lbxDialogue.ItemHeight = 16;
            this.lbxDialogue.Location = new System.Drawing.Point(12, 12);
            this.lbxDialogue.Name = "lbxDialogue";
            this.lbxDialogue.Size = new System.Drawing.Size(496, 212);
            this.lbxDialogue.TabIndex = 0;
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(12, 230);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(237, 69);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = true;
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(271, 230);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(237, 69);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "button2";
            this.btnOption2.UseVisualStyleBackColor = true;
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(271, 315);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(237, 69);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "button3";
            this.btnOption4.UseVisualStyleBackColor = true;
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(12, 315);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(237, 69);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "button4";
            this.btnOption3.UseVisualStyleBackColor = true;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lbxDialogue);
            this.Name = "Tester";
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.Tester_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDialogue;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
    }
}