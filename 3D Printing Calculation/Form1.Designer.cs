
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.lblFilamentPrice = new System.Windows.Forms.Label();
            this.lblUsedFilaments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filamentPriceNumber = new System.Windows.Forms.NumericUpDown();
            this.filamentUsedNumber = new System.Windows.Forms.NumericUpDown();
            this.electricityPriceNumber = new System.Windows.Forms.NumericUpDown();
            this.printingTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.lblFilamentType = new System.Windows.Forms.Label();
            this.comboBoxFilamentType = new System.Windows.Forms.ComboBox();
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
            this.lblFilamentPrice.Location = new System.Drawing.Point(37, 148);
            this.lblFilamentPrice.Name = "lblFilamentPrice";
            this.lblFilamentPrice.Size = new System.Drawing.Size(201, 25);
            this.lblFilamentPrice.TabIndex = 1;
            this.lblFilamentPrice.Text = "Filament price (€/1kg)";
            // 
            // lblUsedFilaments
            // 
            this.lblUsedFilaments.AutoSize = true;
            this.lblUsedFilaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedFilaments.Location = new System.Drawing.Point(37, 235);
            this.lblUsedFilaments.Name = "lblUsedFilaments";
            this.lblUsedFilaments.Size = new System.Drawing.Size(259, 25);
            this.lblUsedFilaments.TabIndex = 3;
            this.lblUsedFilaments.Text = "Filament used for printing (g)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time used for printing (e.g. 4.5h)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(908, 611);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(297, 91);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(34, 611);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(251, 46);
            this.lblTotalCount.TabIndex = 8;
            this.lblTotalCount.Text = "Total price: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Electricity price in c/kWh";
            // 
            // filamentPriceNumber
            // 
            this.filamentPriceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filamentPriceNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.filamentPriceNumber.Location = new System.Drawing.Point(42, 176);
            this.filamentPriceNumber.Name = "filamentPriceNumber";
            this.filamentPriceNumber.Size = new System.Drawing.Size(120, 35);
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
            this.filamentUsedNumber.Location = new System.Drawing.Point(42, 263);
            this.filamentUsedNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.filamentUsedNumber.Name = "filamentUsedNumber";
            this.filamentUsedNumber.Size = new System.Drawing.Size(120, 35);
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
            this.electricityPriceNumber.Location = new System.Drawing.Point(42, 358);
            this.electricityPriceNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.electricityPriceNumber.Name = "electricityPriceNumber";
            this.electricityPriceNumber.ReadOnly = true;
            this.electricityPriceNumber.Size = new System.Drawing.Size(120, 35);
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
            this.printingTimeNumber.Location = new System.Drawing.Point(42, 452);
            this.printingTimeNumber.Name = "printingTimeNumber";
            this.printingTimeNumber.Size = new System.Drawing.Size(120, 35);
            this.printingTimeNumber.TabIndex = 14;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(908, 514);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(297, 91);
            this.btnExportExcel.TabIndex = 15;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // lblFilamentType
            // 
            this.lblFilamentType.AutoSize = true;
            this.lblFilamentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentType.Location = new System.Drawing.Point(538, 148);
            this.lblFilamentType.Name = "lblFilamentType";
            this.lblFilamentType.Size = new System.Drawing.Size(128, 25);
            this.lblFilamentType.TabIndex = 16;
            this.lblFilamentType.Text = "Filament type";
            // 
            // comboBoxFilamentType
            // 
            this.comboBoxFilamentType.AutoCompleteCustomSource.AddRange(new string[] {
            "PLA",
            "PETG"});
            this.comboBoxFilamentType.FormattingEnabled = true;
            this.comboBoxFilamentType.Items.AddRange(new object[] {
            "PLA",
            "PETG"});
            this.comboBoxFilamentType.Location = new System.Drawing.Point(543, 176);
            this.comboBoxFilamentType.Name = "comboBoxFilamentType";
            this.comboBoxFilamentType.Size = new System.Drawing.Size(187, 28);
            this.comboBoxFilamentType.TabIndex = 17;
            this.comboBoxFilamentType.Text = "PLA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 719);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

