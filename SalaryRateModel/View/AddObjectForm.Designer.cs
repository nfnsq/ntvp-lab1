namespace View
{
    partial class AddObjectForm
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
            this.buttonRandomData = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.objectControl = new View.ObjectControl();
            this.SuspendLayout();
            // 
            // buttonRandomData
            // 
            this.buttonRandomData.Location = new System.Drawing.Point(12, 326);
            this.buttonRandomData.Name = "buttonRandomData";
            this.buttonRandomData.Size = new System.Drawing.Size(126, 23);
            this.buttonRandomData.TabIndex = 33;
            this.buttonRandomData.Text = "Create Random Data";
            this.buttonRandomData.UseVisualStyleBackColor = true;
            this.buttonRandomData.Click += new System.EventHandler(this.ButtonRandomData_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(166, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // objectControl
            // 
            this.objectControl.Location = new System.Drawing.Point(12, 12);
            this.objectControl.Name = "objectControl";
            this.objectControl.Object = null;
            this.objectControl.ReadOnly = false;
            this.objectControl.Size = new System.Drawing.Size(327, 280);
            this.objectControl.TabIndex = 34;
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 361);
            this.Controls.Add(this.objectControl);
            this.Controls.Add(this.buttonRandomData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.Load += new System.EventHandler(this.AddObjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRandomData;
        private System.Windows.Forms.Button buttonCancel;
        private ObjectControl objectControl;
    }
}