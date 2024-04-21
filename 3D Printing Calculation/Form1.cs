using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using static ApiResponseDTO;

#region Power consumption description - Artillery Sidewinder X1
/*
3D printing calculation for Artillery Sidewinder X1 printer.

Electricity:
Artillery Sidewinder X1 Power consumption 100-240V 700W max
Power (W) = 700W
Printing time = 5h
Energy consumed per hour (Wh) = Power x Time = 700W x 5h = 3500Wh
kWh = 3500 Wh / 1000 = 3.5 kWh
Total energy consumed = kWh x h
3.5 kWh x 5h = 17.5 kWh
17.5 kWh x pörssisähköhinta (e.g. 2,65 c/kWh) =  0,46€
*/
#endregion

namespace _3D_Printing_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getElectricityPeakAPI();
        }

        private decimal price, filamentUsed, timeUsed;
        private double convertedPrice, totalSum, profitTotal, countWorkAndProfitMargin;
        private const int decimalPlaces = 2, profitMargin = 30, workEffort = 20, startingPrice = 2, postProcessing = 2;
        private const string spotURL = "https://api.epossu.fi/v2/marketData";

        DateTime date = DateTime.Today;

        // Get the current time
        DateTime now = DateTime.Now;

        #region Buttons
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var newForm = new Settings();
            newForm.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        #endregion

        #region Excel setup
        private string ExportToExcel()
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Path.Combine(downloadsPath, "Downloads", "PrintingCalculation.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Printing Calculation");

                worksheet.Cell("A1").Value = "Field";
                worksheet.Cell("B1").Value = "Value";

                int row = 2;
                AddCellValue(worksheet, "Date", date.ToString("dd/MM/yyyy"), row++);
                AddCellValue(worksheet, "Filament type", comboBoxFilamentType.Text, row++);
                AddCellValue(worksheet, "Filament Price 1kg", price + "€", row++);
                AddCellValue(worksheet, "Filament Used", filamentUsed + "g", row++);
                AddCellValue(worksheet, "Electricity (SPOT average price)", electricityPriceNumber.Value + " c/kWh", row++);
                AddCellValue(worksheet, "Printing Time", timeUsed + "h", row++);
                AddCellValue(worksheet, "Starting price", startingPrice + "€", row++);
                AddCellValue(worksheet, "Margin", profitMargin + "%", row++);
                AddCellValue(worksheet, "Work: Modeling, slicing & testing", workEffort + "%", row++);
                AddCellValue(worksheet, "Post-processing: sanding & finishing", postProcessing + "€", row++);
                AddCellValue(worksheet, "", "", row++);
                AddCellValue(worksheet, "Total price", Math.Round(profitTotal, decimalPlaces) + "€", row++);

                workbook.SaveAs(filePath);
            }

            MessageBox.Show("Data exported to Excel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return filePath;
        }

        private void comboBoxFilamentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFilamentType_Click(object sender, EventArgs e)
        {

        }

        private void AddCellValue(IXLWorksheet worksheet, string fieldName, object value, int row)
        {
            worksheet.Cell(row, 1).Value = fieldName;
            worksheet.Cell(row, 2).Value = value?.ToString();
        }
        #endregion

        #region Electricity API
        private async Task getElectricityPeakAPI()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri(spotURL);

                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    
                    // Check if the response is successful (status code 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON string to ApiResponse object
                        ApiResponseDTO.ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO.ApiResponse>(responseBody);
                        ApiResponseDTO.Data apiData = JsonConvert.DeserializeObject<ApiResponseDTO.Data>(responseBody);
                        ApiResponseDTO.ElectricityData apiElectricity = JsonConvert.DeserializeObject<ApiResponseDTO.ElectricityData>(responseBody);
                        ApiResponseDTO.PriceInfo apiPriceInfo = JsonConvert.DeserializeObject<ApiResponseDTO.PriceInfo>(responseBody);
                        ApiResponseDTO.Options apiOptions = JsonConvert.DeserializeObject<ApiResponseDTO.Options>(responseBody);

                        if (apiResponse != null && apiResponse.Data != null)
                        {
                            // Access the "options" values for today
                            double todayAverage = apiResponse.Data.Today.Options.Average;

                            // Disable electricity price input field
                            electricityPriceNumber.ReadOnly = true;
                            electricityPriceNumber.Controls[0].Enabled = false;
                            electricityPriceNumber.Value = (decimal)todayAverage;

                            ApiResponseDTO.PriceInfo currentPrice = apiResponse.Data.Today.Prices
                                .OrderBy(p => Math.Abs((DateTime.ParseExact(p.Date, "dd.MM.yyyy HH:mm", null) - now).TotalMinutes))
                                .FirstOrDefault();

                            lblElectricityPriceNow.Text += currentPrice.Price;
                            lblElectricityPriceLowest.Text += Math.Round(apiResponse.Data.Today.Options.Lowest.Price, decimalPlaces);
                            lblElectricityPriceHighest.Text += Math.Round(apiResponse.Data.Today.Options.Highest.Price, decimalPlaces);

                            // Check for tomorrows electricity prices before/after 15 pm
                            if (apiResponse.Data.Tomorrow.Prices == null)
                            {
                                lblElectricityPriceTomorrow.Text = "Price available after 15:00 pm";
                                lblElectricityTomorrowPriceLowest.Text = "Price available after 15:00 pm";
                                lblElectricityTomorrowPriceHighest.Text = "Price available after 15:00 pm";
                            }
                            else
                            {
                                // Access the "options" values for tomorrow
                                double tomorrowAverage = apiResponse.Data.Tomorrow.Options.Average;
                                lblElectricityPriceTomorrow.Text += tomorrowAverage;
                                lblElectricityTomorrowPriceLowest.Text += Math.Round(apiResponse.Data.Tomorrow.Options.Lowest.Price, decimalPlaces);
                                lblElectricityTomorrowPriceHighest.Text += Math.Round(apiResponse.Data.Tomorrow.Options.Highest.Price, decimalPlaces);
                            }
                        }
                    }

                    else
                    {
                        electricityPriceNumber.ReadOnly = false;
                        electricityPriceNumber.Controls[0].Enabled = true;
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        #endregion

        #region Electricity consumption
        private double electricityUsed()
        {
            int power = 700;
            double electricityPrice = (double)(electricityPriceNumber.Value / 100);
            double sum = (double)(power * timeUsed);
            double kWh = sum / 1000;
            double totalEnergyConsumed = kWh * (double)timeUsed;
            return totalEnergyConsumed * electricityPrice;
        }
        #endregion

        private void Main()
        {
            if (checkEmptyFields())
            {
                return;
            }

            price = filamentPriceNumber.Value;
            filamentUsed = filamentUsedNumber.Value;
            timeUsed = printingTimeNumber.Value;

            calculatePrintingSum(price);
            totalSum = calculateFilamentUsed() + electricityUsed();

            double roundedValue = Math.Round(totalSum, decimalPlaces);
            printingTotalSum(roundedValue);
        }

        #region Error messages
        private bool checkEmptyFields()
        {
            if (filamentPriceNumber.Value == filamentPriceNumber.Minimum)
                ShowErrorMessage("Filament price");
            else if (filamentUsedNumber.Value == filamentUsedNumber.Minimum)
                ShowErrorMessage("Filament used");
            else if (electricityPriceNumber.Value == electricityPriceNumber.Minimum)
                ShowErrorMessage("Electricity price");
            else if (printingTimeNumber.Value == printingTimeNumber.Minimum)
                ShowErrorMessage("Filament used time");
            else if (comboBoxFilamentType.Text == String.Empty)
                ShowErrorMessage("Filament type");
            else
                return false;

            return true;
        }

        private void ShowErrorMessage(string fieldName)
        {
            MessageBox.Show($"{fieldName} field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Filament price
        private void calculatePrintingSum(decimal price)
        {
            // Filament price (e.g. 30€ / 1000g = 0,03)
            convertedPrice = (double)(price / 1000);
        }

        private double calculateFilamentUsed()
        {
            // Calculated printing sum x filament used (e.g. 0,03 x 80g = 2.4€)
            return convertedPrice * (double)filamentUsed;
        }
        #endregion

        #region Printing price calculation
        private void printingTotalSum(double roundedValue)
        {
            countWorkAndProfitMargin = roundedValue / 100 * (profitMargin + workEffort);
            profitTotal = roundedValue + countWorkAndProfitMargin + startingPrice + postProcessing;
            lblTotalCount.Text = $"Total price: {Math.Round(profitTotal, decimalPlaces)}€";
        }
        #endregion
    }
}
