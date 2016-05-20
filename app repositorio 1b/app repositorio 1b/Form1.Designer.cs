namespace app_repositorio_1b
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
            this.bMensaje = new System.Windows.Forms.Button();
            this.bLoco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bMensaje
            // 
            this.bMensaje.Location = new System.Drawing.Point(356, 67);
            this.bMensaje.Name = "bMensaje";
            this.bMensaje.Size = new System.Drawing.Size(94, 73);
            this.bMensaje.TabIndex = 0;
            this.bMensaje.Text = "Mensaje";
            this.bMensaje.UseVisualStyleBackColor = true;
            this.bMensaje.Click += new System.EventHandler(this.bMensaje_Click);
            // 
            // bLoco
            // 
            this.bLoco.BackColor = System.Drawing.Color.Red;
            this.bLoco.Location = new System.Drawing.Point(375, 178);
            this.bLoco.Name = "bLoco";
            this.bLoco.Size = new System.Drawing.Size(75, 59);
            this.bLoco.TabIndex = 1;
            this.bLoco.Text = "Locura";
            this.bLoco.UseVisualStyleBackColor = false;
            this.bLoco.Click += new System.EventHandler(this.bLoco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.bLoco);
            this.Controls.Add(this.bMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMensaje;
        private System.Windows.Forms.Button bLoco;
    }
}

