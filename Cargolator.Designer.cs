namespace Cargolator
{
    partial class Cargolator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargolator));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_containers = new System.Windows.Forms.TrackBar();
            this.label_containerCount = new System.Windows.Forms.Label();
            this.btn_newShipment = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check_priority = new System.Windows.Forms.CheckBox();
            this.check_stacking = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.track_crew = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label_crew = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_military = new System.Windows.Forms.CheckBox();
            this.label_wo = new System.Windows.Forms.Label();
            this.lbl_maxCap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.track_containers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_crew)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(127, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 50);
            this.progressBar1.TabIndex = 1;
            // 
            // track_containers
            // 
            this.track_containers.LargeChange = 1;
            this.track_containers.Location = new System.Drawing.Point(58, 266);
            this.track_containers.Maximum = 40;
            this.track_containers.Name = "track_containers";
            this.track_containers.Size = new System.Drawing.Size(251, 45);
            this.track_containers.TabIndex = 2;
            this.track_containers.Scroll += new System.EventHandler(this.track_containers_Scroll);
            // 
            // label_containerCount
            // 
            this.label_containerCount.AutoSize = true;
            this.label_containerCount.Location = new System.Drawing.Point(230, 250);
            this.label_containerCount.Name = "label_containerCount";
            this.label_containerCount.Size = new System.Drawing.Size(35, 13);
            this.label_containerCount.TabIndex = 3;
            this.label_containerCount.Text = "label1";
            this.label_containerCount.Click += new System.EventHandler(this.label_containerCount_Click);
            // 
            // btn_newShipment
            // 
            this.btn_newShipment.BackColor = System.Drawing.Color.DimGray;
            this.btn_newShipment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_newShipment.Location = new System.Drawing.Point(150, 33);
            this.btn_newShipment.Name = "btn_newShipment";
            this.btn_newShipment.Size = new System.Drawing.Size(77, 49);
            this.btn_newShipment.TabIndex = 5;
            this.btn_newShipment.Text = "Apply";
            this.btn_newShipment.UseVisualStyleBackColor = false;
            this.btn_newShipment.Click += new System.EventHandler(this.btn_newShipment_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(134, 94);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
            this.label_shipLabel.TabIndex = 6;
            this.label_shipLabel.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Containers count:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // check_priority
            // 
            this.check_priority.AutoSize = true;
            this.check_priority.Location = new System.Drawing.Point(18, 28);
            this.check_priority.Name = "check_priority";
            this.check_priority.Size = new System.Drawing.Size(102, 17);
            this.check_priority.TabIndex = 9;
            this.check_priority.Text = "Priority shipment";
            this.check_priority.UseVisualStyleBackColor = true;
            this.check_priority.CheckedChanged += new System.EventHandler(this.check_priority_CheckedChanged);
            this.check_priority.MouseHover += new System.EventHandler(this.check_priority_MouseHover);
            // 
            // check_stacking
            // 
            this.check_stacking.AutoSize = true;
            this.check_stacking.Location = new System.Drawing.Point(18, 51);
            this.check_stacking.Name = "check_stacking";
            this.check_stacking.Size = new System.Drawing.Size(126, 17);
            this.check_stacking.TabIndex = 11;
            this.check_stacking.Text = "Stackable containers";
            this.check_stacking.UseVisualStyleBackColor = true;
            this.check_stacking.CheckedChanged += new System.EventHandler(this.check_stacking_CheckedChanged);
            this.check_stacking.Click += new System.EventHandler(this.check_stacking_Click);
            this.check_stacking.MouseHover += new System.EventHandler(this.check_stacking_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(85, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_preview_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(221, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save Work Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_save_click);
            // 
            // track_crew
            // 
            this.track_crew.LargeChange = 1;
            this.track_crew.Location = new System.Drawing.Point(58, 317);
            this.track_crew.Maximum = 50;
            this.track_crew.Name = "track_crew";
            this.track_crew.Size = new System.Drawing.Size(251, 45);
            this.track_crew.TabIndex = 14;
            this.track_crew.Scroll += new System.EventHandler(this.track_crew_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Crew on board:";
            // 
            // label_crew
            // 
            this.label_crew.AutoSize = true;
            this.label_crew.Location = new System.Drawing.Point(230, 301);
            this.label_crew.Name = "label_crew";
            this.label_crew.Size = new System.Drawing.Size(35, 13);
            this.label_crew.TabIndex = 16;
            this.label_crew.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_military);
            this.groupBox1.Controls.Add(this.btn_newShipment);
            this.groupBox1.Controls.Add(this.check_priority);
            this.groupBox1.Controls.Add(this.check_stacking);
            this.groupBox1.Location = new System.Drawing.Point(315, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipment settings";
            // 
            // check_military
            // 
            this.check_military.AutoSize = true;
            this.check_military.Location = new System.Drawing.Point(18, 74);
            this.check_military.Name = "check_military";
            this.check_military.Size = new System.Drawing.Size(100, 17);
            this.check_military.TabIndex = 12;
            this.check_military.Text = "Military contract";
            this.check_military.UseVisualStyleBackColor = true;
            this.check_military.MouseHover += new System.EventHandler(this.check_military_MouseHover);
            // 
            // label_wo
            // 
            this.label_wo.AutoSize = true;
            this.label_wo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_wo.Location = new System.Drawing.Point(352, 15);
            this.label_wo.Name = "label_wo";
            this.label_wo.Size = new System.Drawing.Size(70, 25);
            this.label_wo.TabIndex = 21;
            this.label_wo.Text = "label4";
            this.label_wo.Click += new System.EventHandler(this.label_wo_Click);
            // 
            // lbl_maxCap
            // 
            this.lbl_maxCap.AutoSize = true;
            this.lbl_maxCap.Location = new System.Drawing.Point(330, 94);
            this.lbl_maxCap.Name = "lbl_maxCap";
            this.lbl_maxCap.Size = new System.Drawing.Size(35, 13);
            this.lbl_maxCap.TabIndex = 23;
            this.lbl_maxCap.Text = "label2";
            this.lbl_maxCap.Click += new System.EventHandler(this.lbl_maxCap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Shipment number:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Cargolator.Properties.Resources.Aha_Soft_Free_Large_Boss_Captain;
            this.pictureBox3.Location = new System.Drawing.Point(14, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 39);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cargolator.Properties.Resources.Icons_Land_Transport_Container;
            this.pictureBox2.Location = new System.Drawing.Point(14, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cargolator.Properties.Resources.Ship;
            this.pictureBox1.Location = new System.Drawing.Point(14, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(357, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 39);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Close";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Cargolator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 441);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_maxCap);
            this.Controls.Add(this.label_wo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_crew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_crew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.label_containerCount);
            this.Controls.Add(this.track_containers);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Cargolator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargolator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_containers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_crew)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_containers;
        private System.Windows.Forms.Label label_containerCount;
        private System.Windows.Forms.Button btn_newShipment;
        private System.Windows.Forms.Label label_shipLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_priority;
        private System.Windows.Forms.CheckBox check_stacking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar track_crew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_crew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox check_military;
        private System.Windows.Forms.Label label_wo;
        private System.Windows.Forms.Label lbl_maxCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_back;
    }
}

