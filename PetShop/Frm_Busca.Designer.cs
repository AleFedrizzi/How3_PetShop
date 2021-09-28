
namespace PetShop
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Btn_Atualiza = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Lst_Busca = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Atualiza
            // 
            this.Btn_Atualiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Atualiza.FlatAppearance.BorderSize = 0;
            this.Btn_Atualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.Btn_Atualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.Btn_Atualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atualiza.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atualiza.ForeColor = System.Drawing.Color.White;
            this.Btn_Atualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Atualiza.Location = new System.Drawing.Point(13, 17);
            this.Btn_Atualiza.Margin = new System.Windows.Forms.Padding(30);
            this.Btn_Atualiza.Name = "Btn_Atualiza";
            this.Btn_Atualiza.Size = new System.Drawing.Size(78, 67);
            this.Btn_Atualiza.TabIndex = 24;
            this.Btn_Atualiza.Text = "Selecionar";
            this.Btn_Atualiza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Atualiza.UseVisualStyleBackColor = true;
            this.Btn_Atualiza.Click += new System.EventHandler(this.Btn_Atualiza_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(32, 21);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // Lst_Busca
            // 
            this.Lst_Busca.BackColor = System.Drawing.Color.White;
            this.Lst_Busca.ForeColor = System.Drawing.Color.Black;
            this.Lst_Busca.FormattingEnabled = true;
            this.Lst_Busca.ItemHeight = 18;
            this.Lst_Busca.Location = new System.Drawing.Point(12, 90);
            this.Lst_Busca.Name = "Lst_Busca";
            this.Lst_Busca.Size = new System.Drawing.Size(337, 256);
            this.Lst_Busca.TabIndex = 26;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(302, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 37);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(111)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(361, 359);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.Lst_Busca);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.Btn_Atualiza);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Busca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Busca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button Btn_Atualiza;
        private System.Windows.Forms.ListBox Lst_Busca;
        private System.Windows.Forms.Button btnFechar;
    }
}