
namespace PetShop.NewFolder1
{
    partial class Frm_Questao
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
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Btm_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Questao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Questao.Location = new System.Drawing.Point(66, 27);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(252, 26);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você quer excluir o cliente?";
            this.Lbl_Questao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btm_Ok
            // 
            this.Btm_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(88)))), ((int)(((byte)(41)))));
            this.Btm_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btm_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Ok.FlatAppearance.BorderSize = 0;
            this.Btm_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Ok.ForeColor = System.Drawing.Color.White;
            this.Btm_Ok.Location = new System.Drawing.Point(236, 93);
            this.Btm_Ok.Name = "Btm_Ok";
            this.Btm_Ok.Size = new System.Drawing.Size(115, 27);
            this.Btm_Ok.TabIndex = 1;
            this.Btm_Ok.Text = "Sim. Continue";
            this.Btm_Ok.UseVisualStyleBackColor = false;
            this.Btm_Ok.Click += new System.EventHandler(this.Btm_Ok_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.Black;
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(236, 132);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(115, 27);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Não. Pare";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop.Properties.Resources.cut;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(385, 209);
            this.Controls.Add(this.Lbl_Questao);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btm_Ok);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btm_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Questao;
    }
}