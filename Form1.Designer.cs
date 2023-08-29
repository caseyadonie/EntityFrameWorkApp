namespace EntityFrameWorkApp
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
            this.bttnCreate = new System.Windows.Forms.Button();
            this.bttnRead = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnCreate
            // 
            this.bttnCreate.Location = new System.Drawing.Point(619, 48);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(111, 85);
            this.bttnCreate.TabIndex = 0;
            this.bttnCreate.Text = "Create";
            this.bttnCreate.UseVisualStyleBackColor = true;
            this.bttnCreate.Click += new System.EventHandler(this.bttnCreate_Click);
            // 
            // bttnRead
            // 
            this.bttnRead.Location = new System.Drawing.Point(787, 48);
            this.bttnRead.Name = "bttnRead";
            this.bttnRead.Size = new System.Drawing.Size(111, 85);
            this.bttnRead.TabIndex = 1;
            this.bttnRead.Text = "Read";
            this.bttnRead.UseVisualStyleBackColor = true;
            this.bttnRead.Click += new System.EventHandler(this.bttnRead_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(1103, 48);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(111, 85);
            this.bttnDelete.TabIndex = 3;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(935, 48);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(111, 85);
            this.bttnUpdate.TabIndex = 2;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 694);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnRead);
            this.Controls.Add(this.bttnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnCreate;
        private System.Windows.Forms.Button bttnRead;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnUpdate;
    }
}

