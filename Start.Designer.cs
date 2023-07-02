namespace Cargolator
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btn_newShipment = new System.Windows.Forms.Button();
            this.btn_deleteWo = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cypher = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.BackColor = System.Drawing.Color.DimGray;
            this.btn_newShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newShipment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_newShipment.Location = new System.Drawing.Point(36, 97);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(154, 48);
            this.btn_newShipment.TabIndex = 1;
            this.btn_newShipment.Text = "New Shipment";
            this.btn_newShipment.UseVisualStyleBackColor = false;
            this.btn_newShipment.Click += new System.EventHandler(this.btn_newShipment_Click);
            // 
            // btn_deleteWo
            // 
            this.btn_deleteWo.BackColor = System.Drawing.Color.DimGray;
            this.btn_deleteWo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteWo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteWo.Location = new System.Drawing.Point(196, 97);
            this.btn_deleteWo.Name = "btn_deleteWo";
            this.btn_deleteWo.Size = new System.Drawing.Size(154, 48);
            this.btn_deleteWo.TabIndex = 2;
            this.btn_deleteWo.Text = "Delete Shipment";
            this.btn_deleteWo.UseVisualStyleBackColor = false;
            this.btn_deleteWo.Click += new System.EventHandler(this.btn_deleteWo_Click);
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.DimGray;
            this.btn_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_status.Location = new System.Drawing.Point(36, 205);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(314, 48);
            this.btn_status.TabIndex = 3;
            this.btn_status.Text = "Status Report";
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DimGray;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(584, 241);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 29);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cargo Ship Manager";
            // 
            // btn_cypher
            // 
            this.btn_cypher.BackColor = System.Drawing.Color.DimGray;
            this.btn_cypher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cypher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cypher.Location = new System.Drawing.Point(196, 151);
            this.btn_cypher.Name = "btn_cypher";
            this.btn_cypher.Size = new System.Drawing.Size(154, 48);
            this.btn_cypher.TabIndex = 10;
            this.btn_cypher.Text = "Encryption Center";
            this.btn_cypher.UseVisualStyleBackColor = false;
            this.btn_cypher.Click += new System.EventHandler(this.btn_cypher_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.BackColor = System.Drawing.Color.DimGray;
            this.btn_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_mc.Location = new System.Drawing.Point(36, 151);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(154, 48);
            this.btn_mc.TabIndex = 11;
            this.btn_mc.Text = "Military Contracts";
            this.btn_mc.UseVisualStyleBackColor = false;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cargolator.Properties.Resources._2259_589da40ca54;
            this.pictureBox1.Location = new System.Drawing.Point(-124, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 282);
            this.Controls.Add(this.btn_mc);
            this.Controls.Add(this.btn_cypher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.btn_deleteWo);
            this.Controls.Add(this.btn_newShipment);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newShipment;
        private System.Windows.Forms.Button btn_deleteWo;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cypher;
        private System.Windows.Forms.Button btn_mc;
    }
}