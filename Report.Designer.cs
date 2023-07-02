namespace Cargolator
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.lbl_mc = new System.Windows.Forms.Label();
            this.lbl_heads = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_containers = new System.Windows.Forms.Label();
            this.lbl_wo = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mc
            // 
            this.lbl_mc.AutoSize = true;
            this.lbl_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mc.Location = new System.Drawing.Point(36, 52);
            this.lbl_mc.Name = "lbl_mc";
            this.lbl_mc.Size = new System.Drawing.Size(0, 17);
            this.lbl_mc.TabIndex = 0;
            this.lbl_mc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_mc.Click += new System.EventHandler(this.lbl_report_Click);
            // 
            // lbl_heads
            // 
            this.lbl_heads.AutoSize = true;
            this.lbl_heads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heads.Location = new System.Drawing.Point(12, 27);
            this.lbl_heads.Name = "lbl_heads";
            this.lbl_heads.Size = new System.Drawing.Size(47, 15);
            this.lbl_heads.TabIndex = 1;
            this.lbl_heads.Text = "label1";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.Location = new System.Drawing.Point(297, 52);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(0, 17);
            this.lbl_speed.TabIndex = 2;
            this.lbl_speed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_containers
            // 
            this.lbl_containers.AutoSize = true;
            this.lbl_containers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_containers.Location = new System.Drawing.Point(221, 52);
            this.lbl_containers.Name = "lbl_containers";
            this.lbl_containers.Size = new System.Drawing.Size(0, 17);
            this.lbl_containers.TabIndex = 3;
            this.lbl_containers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_wo
            // 
            this.lbl_wo.AutoSize = true;
            this.lbl_wo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wo.Location = new System.Drawing.Point(124, 52);
            this.lbl_wo.Name = "lbl_wo";
            this.lbl_wo.Size = new System.Drawing.Size(0, 17);
            this.lbl_wo.TabIndex = 4;
            this.lbl_wo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(384, 52);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(0, 17);
            this.lbl_cost.TabIndex = 5;
            this.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DimGray;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Location = new System.Drawing.Point(184, 517);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 32);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(463, 561);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_wo);
            this.Controls.Add(this.lbl_containers);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_heads);
            this.Controls.Add(this.lbl_mc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mc;
        private System.Windows.Forms.Label lbl_heads;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_containers;
        private System.Windows.Forms.Label lbl_wo;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Button btn_close;
    }
}