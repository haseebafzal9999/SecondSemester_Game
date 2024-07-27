namespace GameProject
{
    partial class GameOver
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
            this.closebutton = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closebutton
            // 
            this.closebutton.AnimationHoverSpeed = 0.07F;
            this.closebutton.AnimationSpeed = 0.03F;
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.BaseColor = System.Drawing.Color.Cyan;
            this.closebutton.BorderColor = System.Drawing.Color.Black;
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closebutton.FocusedColor = System.Drawing.Color.Empty;
            this.closebutton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.Color.Navy;
            this.closebutton.Image = null;
            this.closebutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.closebutton.Location = new System.Drawing.Point(930, 539);
            this.closebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closebutton.Name = "closebutton";
            this.closebutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.closebutton.OnHoverImage = null;
            this.closebutton.OnPressedColor = System.Drawing.Color.Black;
            this.closebutton.Size = new System.Drawing.Size(192, 72);
            this.closebutton.TabIndex = 0;
            this.closebutton.Text = "Close";
            this.closebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 108);
            this.label1.TabIndex = 5;
            this.label1.Text = "GAME OVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(409, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCORE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(672, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 63);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameProject.Properties.Resources._1stForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}