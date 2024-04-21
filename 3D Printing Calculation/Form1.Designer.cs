
namespace _3D_Printing_Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainLabel = new System.Windows.Forms.Label();
            this.lblFilamentPrice = new System.Windows.Forms.Label();
            this.lblUsedFilaments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filamentPriceNumber = new System.Windows.Forms.NumericUpDown();
            this.filamentUsedNumber = new System.Windows.Forms.NumericUpDown();
            this.electricityPriceNumber = new System.Windows.Forms.NumericUpDown();
            this.printingTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.lblFilamentType = new System.Windows.Forms.Label();
            this.comboBoxFilamentType = new System.Windows.Forms.ComboBox();
            this.lblElectricityPriceNow = new System.Windows.Forms.Label();
            this.lblElectricityPriceLowest = new System.Windows.Forms.Label();
            this.lblElectricityPriceHighest = new System.Windows.Forms.Label();
            this.lblElectricityPriceTomorrow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblElectricityTomorrowPriceHighest = new System.Windows.Forms.Label();
            this.lblElectricityTomorrowPriceLowest = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filamentPriceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filamentUsedNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityPriceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingTimeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(31, 29);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(425, 36);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "3D Printing Price Calculation";
            // 
            // lblFilamentPrice
            // 
            this.lblFilamentPrice.AutoSize = true;
            this.lblFilamentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentPrice.Location = new System.Drawing.Point(32, 258);
            this.lblFilamentPrice.Name = "lblFilamentPrice";
            this.lblFilamentPrice.Size = new System.Drawing.Size(201, 25);
            this.lblFilamentPrice.TabIndex = 1;
            this.lblFilamentPrice.Text = "Filament price (€/1kg)";
            // 
            // lblUsedFilaments
            // 
            this.lblUsedFilaments.AutoSize = true;
            this.lblUsedFilaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedFilaments.Location = new System.Drawing.Point(32, 345);
            this.lblUsedFilaments.Name = "lblUsedFilaments";
            this.lblUsedFilaments.Size = new System.Drawing.Size(259, 25);
            this.lblUsedFilaments.TabIndex = 3;
            this.lblUsedFilaments.Text = "Filament used for printing (g)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time used for printing (e.g. 4.5h)";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(29, 794);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(251, 46);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "Total price: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Average electricity price today (c/kWh)";
            // 
            // filamentPriceNumber
            // 
            this.filamentPriceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filamentPriceNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.filamentPriceNumber.Location = new System.Drawing.Point(37, 286);
            this.filamentPriceNumber.Name = "filamentPriceNumber";
            this.filamentPriceNumber.Size = new System.Drawing.Size(196, 35);
            this.filamentPriceNumber.TabIndex = 11;
            // 
            // filamentUsedNumber
            // 
            this.filamentUsedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filamentUsedNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.filamentUsedNumber.Location = new System.Drawing.Point(37, 373);
            this.filamentUsedNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.filamentUsedNumber.Name = "filamentUsedNumber";
            this.filamentUsedNumber.Size = new System.Drawing.Size(196, 35);
            this.filamentUsedNumber.TabIndex = 12;
            // 
            // electricityPriceNumber
            // 
            this.electricityPriceNumber.DecimalPlaces = 2;
            this.electricityPriceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electricityPriceNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.electricityPriceNumber.Location = new System.Drawing.Point(37, 468);
            this.electricityPriceNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.electricityPriceNumber.Name = "electricityPriceNumber";
            this.electricityPriceNumber.ReadOnly = true;
            this.electricityPriceNumber.Size = new System.Drawing.Size(196, 35);
            this.electricityPriceNumber.TabIndex = 13;
            // 
            // printingTimeNumber
            // 
            this.printingTimeNumber.DecimalPlaces = 1;
            this.printingTimeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printingTimeNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.printingTimeNumber.Location = new System.Drawing.Point(37, 562);
            this.printingTimeNumber.Name = "printingTimeNumber";
            this.printingTimeNumber.Size = new System.Drawing.Size(196, 35);
            this.printingTimeNumber.TabIndex = 14;
            // 
            // lblFilamentType
            // 
            this.lblFilamentType.AutoSize = true;
            this.lblFilamentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentType.Location = new System.Drawing.Point(32, 176);
            this.lblFilamentType.Name = "lblFilamentType";
            this.lblFilamentType.Size = new System.Drawing.Size(128, 25);
            this.lblFilamentType.TabIndex = 16;
            this.lblFilamentType.Text = "Filament type";
            this.lblFilamentType.Click += new System.EventHandler(this.lblFilamentType_Click);
            // 
            // comboBoxFilamentType
            // 
            this.comboBoxFilamentType.AutoCompleteCustomSource.AddRange(new string[] {
            "PLA",
            "PETG"});
            this.comboBoxFilamentType.FormattingEnabled = true;
            this.comboBoxFilamentType.Items.AddRange(new object[] {
            "PLA",
            "PLA+",
            "PETG",
            "ABS"});
            this.comboBoxFilamentType.Location = new System.Drawing.Point(37, 204);
            this.comboBoxFilamentType.Name = "comboBoxFilamentType";
            this.comboBoxFilamentType.Size = new System.Drawing.Size(196, 28);
            this.comboBoxFilamentType.TabIndex = 17;
            this.comboBoxFilamentType.Text = "PLA";
            this.comboBoxFilamentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilamentType_SelectedIndexChanged);
            // 
            // lblElectricityPriceNow
            // 
            this.lblElectricityPriceNow.AutoSize = true;
            this.lblElectricityPriceNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityPriceNow.Location = new System.Drawing.Point(528, 243);
            this.lblElectricityPriceNow.Name = "lblElectricityPriceNow";
            this.lblElectricityPriceNow.Size = new System.Drawing.Size(92, 36);
            this.lblElectricityPriceNow.TabIndex = 20;
            this.lblElectricityPriceNow.Text = "Now: ";
            // 
            // lblElectricityPriceLowest
            // 
            this.lblElectricityPriceLowest.AutoSize = true;
            this.lblElectricityPriceLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityPriceLowest.Location = new System.Drawing.Point(528, 286);
            this.lblElectricityPriceLowest.Name = "lblElectricityPriceLowest";
            this.lblElectricityPriceLowest.Size = new System.Drawing.Size(126, 36);
            this.lblElectricityPriceLowest.TabIndex = 21;
            this.lblElectricityPriceLowest.Text = "Lowest: ";
            // 
            // lblElectricityPriceHighest
            // 
            this.lblElectricityPriceHighest.AutoSize = true;
            this.lblElectricityPriceHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityPriceHighest.Location = new System.Drawing.Point(528, 334);
            this.lblElectricityPriceHighest.Name = "lblElectricityPriceHighest";
            this.lblElectricityPriceHighest.Size = new System.Drawing.Size(132, 36);
            this.lblElectricityPriceHighest.TabIndex = 22;
            this.lblElectricityPriceHighest.Text = "Highest: ";
            // 
            // lblElectricityPriceTomorrow
            // 
            this.lblElectricityPriceTomorrow.AutoSize = true;
            this.lblElectricityPriceTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityPriceTomorrow.Location = new System.Drawing.Point(528, 446);
            this.lblElectricityPriceTomorrow.Name = "lblElectricityPriceTomorrow";
            this.lblElectricityPriceTomorrow.Size = new System.Drawing.Size(142, 36);
            this.lblElectricityPriceTomorrow.TabIndex = 23;
            this.lblElectricityPriceTomorrow.Text = "Average: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "Today Electricity prices (c/kWh)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(485, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tomorrow Electricity prices (c/kWh)";
            // 
            // lblElectricityTomorrowPriceHighest
            // 
            this.lblElectricityTomorrowPriceHighest.AutoSize = true;
            this.lblElectricityTomorrowPriceHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityTomorrowPriceHighest.Location = new System.Drawing.Point(528, 536);
            this.lblElectricityTomorrowPriceHighest.Name = "lblElectricityTomorrowPriceHighest";
            this.lblElectricityTomorrowPriceHighest.Size = new System.Drawing.Size(132, 36);
            this.lblElectricityTomorrowPriceHighest.TabIndex = 27;
            this.lblElectricityTomorrowPriceHighest.Text = "Highest: ";
            // 
            // lblElectricityTomorrowPriceLowest
            // 
            this.lblElectricityTomorrowPriceLowest.AutoSize = true;
            this.lblElectricityTomorrowPriceLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricityTomorrowPriceLowest.Location = new System.Drawing.Point(528, 491);
            this.lblElectricityTomorrowPriceLowest.Name = "lblElectricityTomorrowPriceLowest";
            this.lblElectricityTomorrowPriceLowest.Size = new System.Drawing.Size(126, 36);
            this.lblElectricityTomorrowPriceLowest.TabIndex = 26;
            this.lblElectricityTomorrowPriceLowest.Text = "Lowest: ";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::_3D_Printing_Calculation.Properties.Resources.filter_57891;
            this.btnSettings.Location = new System.Drawing.Point(1102, 29);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(102, 104);
            this.btnSettings.TabIndex = 19;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Image = global::_3D_Printing_Calculation.Properties.Resources.excel_4954;
            this.btnExportExcel.Location = new System.Drawing.Point(949, 779);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(125, 106);
            this.btnExportExcel.TabIndex = 15;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Image = global::_3D_Printing_Calculation.Properties.Resources.accounting_14773;
            this.btnCalculate.Location = new System.Drawing.Point(1080, 779);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 106);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 897);
            this.Controls.Add(this.lblElectricityTomorrowPriceHighest);
            this.Controls.Add(this.lblElectricityTomorrowPriceLowest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblElectricityPriceTomorrow);
            this.Controls.Add(this.lblElectricityPriceHighest);
            this.Controls.Add(this.lblElectricityPriceLowest);
            this.Controls.Add(this.lblElectricityPriceNow);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.comboBoxFilamentType);
            this.Controls.Add(this.lblFilamentType);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.printingTimeNumber);
            this.Controls.Add(this.electricityPriceNumber);
            this.Controls.Add(this.filamentUsedNumber);
            this.Controls.Add(this.filamentPriceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsedFilaments);
            this.Controls.Add(this.lblFilamentPrice);
            this.Controls.Add(this.MainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Minting Printing";
            ((System.ComponentModel.ISupportInitialize)(this.filamentPriceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filamentUsedNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricityPriceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingTimeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label lblFilamentPrice;
        private System.Windows.Forms.Label lblUsedFilaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown filamentPriceNumber;
        private System.Windows.Forms.NumericUpDown filamentUsedNumber;
        private System.Windows.Forms.NumericUpDown electricityPriceNumber;
        private System.Windows.Forms.NumericUpDown printingTimeNumber;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label lblFilamentType;
        private System.Windows.Forms.ComboBox comboBoxFilamentType;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblElectricityPriceNow;
        private System.Windows.Forms.Label lblElectricityPriceLowest;
        private System.Windows.Forms.Label lblElectricityPriceHighest;
        private System.Windows.Forms.Label lblElectricityPriceTomorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblElectricityTomorrowPriceHighest;
        private System.Windows.Forms.Label lblElectricityTomorrowPriceLowest;
    }
}

