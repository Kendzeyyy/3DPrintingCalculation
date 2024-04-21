
namespace _3D_Printing_Calculation
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.upDownWorkEffort = new System.Windows.Forms.NumericUpDown();
            this.lblWorkEffort = new System.Windows.Forms.Label();
            this.upDownProfitMargin = new System.Windows.Forms.NumericUpDown();
            this.lblProfitMargin = new System.Windows.Forms.Label();
            this.upDownStartingPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStartingPrice = new System.Windows.Forms.Label();
            this.upDownPostProcessing = new System.Windows.Forms.NumericUpDown();
            this.lblPostProcessing = new System.Windows.Forms.Label();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWorkEffort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownProfitMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPostProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // upDownWorkEffort
            // 
            this.upDownWorkEffort.DecimalPlaces = 1;
            this.upDownWorkEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownWorkEffort.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownWorkEffort.Location = new System.Drawing.Point(37, 140);
            this.upDownWorkEffort.Name = "upDownWorkEffort";
            this.upDownWorkEffort.Size = new System.Drawing.Size(196, 35);
            this.upDownWorkEffort.TabIndex = 16;
            this.upDownWorkEffort.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblWorkEffort
            // 
            this.lblWorkEffort.AutoSize = true;
            this.lblWorkEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkEffort.Location = new System.Drawing.Point(32, 112);
            this.lblWorkEffort.Name = "lblWorkEffort";
            this.lblWorkEffort.Size = new System.Drawing.Size(144, 25);
            this.lblWorkEffort.TabIndex = 15;
            this.lblWorkEffort.Text = "Work effort (%)";
            // 
            // upDownProfitMargin
            // 
            this.upDownProfitMargin.DecimalPlaces = 1;
            this.upDownProfitMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownProfitMargin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownProfitMargin.Location = new System.Drawing.Point(37, 49);
            this.upDownProfitMargin.Name = "upDownProfitMargin";
            this.upDownProfitMargin.Size = new System.Drawing.Size(196, 35);
            this.upDownProfitMargin.TabIndex = 18;
            this.upDownProfitMargin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblProfitMargin
            // 
            this.lblProfitMargin.AutoSize = true;
            this.lblProfitMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitMargin.Location = new System.Drawing.Point(32, 21);
            this.lblProfitMargin.Name = "lblProfitMargin";
            this.lblProfitMargin.Size = new System.Drawing.Size(157, 25);
            this.lblProfitMargin.TabIndex = 17;
            this.lblProfitMargin.Text = "Profit margin (%)";
            // 
            // upDownStartingPrice
            // 
            this.upDownStartingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownStartingPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownStartingPrice.Location = new System.Drawing.Point(37, 229);
            this.upDownStartingPrice.Name = "upDownStartingPrice";
            this.upDownStartingPrice.Size = new System.Drawing.Size(196, 35);
            this.upDownStartingPrice.TabIndex = 20;
            this.upDownStartingPrice.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblStartingPrice
            // 
            this.lblStartingPrice.AutoSize = true;
            this.lblStartingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingPrice.Location = new System.Drawing.Point(32, 201);
            this.lblStartingPrice.Name = "lblStartingPrice";
            this.lblStartingPrice.Size = new System.Drawing.Size(156, 25);
            this.lblStartingPrice.TabIndex = 19;
            this.lblStartingPrice.Text = "Starting price (€)";
            // 
            // upDownPostProcessing
            // 
            this.upDownPostProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownPostProcessing.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDownPostProcessing.Location = new System.Drawing.Point(37, 326);
            this.upDownPostProcessing.Name = "upDownPostProcessing";
            this.upDownPostProcessing.Size = new System.Drawing.Size(196, 35);
            this.upDownPostProcessing.TabIndex = 22;
            this.upDownPostProcessing.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPostProcessing
            // 
            this.lblPostProcessing.AutoSize = true;
            this.lblPostProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostProcessing.Location = new System.Drawing.Point(32, 298);
            this.lblPostProcessing.Name = "lblPostProcessing";
            this.lblPostProcessing.Size = new System.Drawing.Size(181, 25);
            this.lblPostProcessing.TabIndex = 21;
            this.lblPostProcessing.Text = "Post processing (€)";
            this.lblPostProcessing.UseMnemonic = false;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingsSave.FlatAppearance.BorderSize = 0;
            this.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsSave.Image = global::_3D_Printing_Calculation.Properties.Resources.save_file_5341;
            this.btnSettingsSave.Location = new System.Drawing.Point(490, 287);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(94, 86);
            this.btnSettingsSave.TabIndex = 23;
            this.btnSettingsSave.UseVisualStyleBackColor = false;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.btnSettingsSave);
            this.Controls.Add(this.upDownPostProcessing);
            this.Controls.Add(this.lblPostProcessing);
            this.Controls.Add(this.upDownStartingPrice);
            this.Controls.Add(this.lblStartingPrice);
            this.Controls.Add(this.upDownProfitMargin);
            this.Controls.Add(this.lblProfitMargin);
            this.Controls.Add(this.upDownWorkEffort);
            this.Controls.Add(this.lblWorkEffort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.upDownWorkEffort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownProfitMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPostProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upDownWorkEffort;
        private System.Windows.Forms.Label lblWorkEffort;
        private System.Windows.Forms.NumericUpDown upDownProfitMargin;
        private System.Windows.Forms.Label lblProfitMargin;
        private System.Windows.Forms.NumericUpDown upDownStartingPrice;
        private System.Windows.Forms.Label lblStartingPrice;
        private System.Windows.Forms.NumericUpDown upDownPostProcessing;
        private System.Windows.Forms.Label lblPostProcessing;
        private System.Windows.Forms.Button btnSettingsSave;
    }
}