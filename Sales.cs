using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace CSCISystem1._1
{
    public partial class Sales: Form
    {
        public Sales()
        {
            InitializeComponent();
            ConfigureChart();
            LoadSalesData();
        }

        private void ConfigureChart()
        {
            cartesianChart1.LegendLocation = LegendLocation.Top;
            cartesianChart1.Hoverable = true;
            cartesianChart1.DataTooltip = new LiveCharts.Wpf.DefaultTooltip();

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Date",
                LabelFormatter = value => new DateTime((long)value).ToString("MMM dd"),
                // Initial min/max for X-axis to prevent zero range on first load if no data
                MinValue = 0,
                MaxValue = 1 // Small, valid range
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Quantity Sold",
                LabelFormatter = value => value.ToString("N0"),
                // Initial min/max for Y-axis to prevent zero range on first load if no data
                MinValue = 0,
                MaxValue = 1, // Small, valid range
                Separator = new Separator { Step = 1 }
            });
        }



        private void LoadSalesData()
        {
            if (salesDataGridView != null)
            {
                salesDataGridView.DataSource = InventoryReport.GetSoldItemsTable();
            }

            UpdateSalesChart();
        }

        private void UpdateSalesChart()
        {
            cartesianChart1.Series.Clear();

            var salesData = InventoryReport.GetSoldItemsTable().AsEnumerable()
                .GroupBy(row => ((DateTime)row["Date Sold"]).Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalQuantity = g.Sum(r => r.Field<int>("Quantity"))
                })
                .OrderBy(x => x.Date)
                .ToList();

            if (salesData.Any())
            {
                // X-axis: Dates
                long minDateTicks = salesData.Min(x => x.Date).Ticks;
                long maxDateTicks = salesData.Max(x => x.Date).Ticks;

                cartesianChart1.AxisX[0].Labels = salesData.Select(x => x.Date.ToString("MMM dd")).ToArray();
                cartesianChart1.AxisX[0].LabelFormatter = value => new DateTime((long)value).ToString("MMM dd");

                // If only one distinct date, extend the range slightly
                if (minDateTicks == maxDateTicks)
                {
                    cartesianChart1.AxisX[0].MinValue = minDateTicks - TimeSpan.FromHours(12).Ticks; // Half a day before
                    cartesianChart1.AxisX[0].MaxValue = maxDateTicks + TimeSpan.FromHours(12).Ticks; // Half a day after
                }
                else
                {
                    cartesianChart1.AxisX[0].MinValue = minDateTicks;
                    cartesianChart1.AxisX[0].MaxValue = maxDateTicks;
                }

                // Y-axis: Quantities
                double maxQuantity = salesData.Max(x => x.TotalQuantity);
                double minQuantity = salesData.Min(x => x.TotalQuantity);

                cartesianChart1.AxisY[0].MinValue = Math.Max(0, minQuantity - (maxQuantity * 0.1)); // Ensure min is not negative, add small buffer
                // Ensure MaxValue is greater than MinValue. If maxQuantity is 0 or all quantities are the same,
                // set a minimum valid range (e.g., up to 1 or 2).
                if (maxQuantity == minQuantity)
                {
                    cartesianChart1.AxisY[0].MaxValue = maxQuantity + 1; // If all quantities are same, add 1 to max to ensure range
                }
                else
                {
                    cartesianChart1.AxisY[0].MaxValue = maxQuantity * 1.1; // Add 10% buffer for visualization
                }
                // Ensure the max value is at least 1 if it's currently 0
                if (cartesianChart1.AxisY[0].MaxValue <= 0)
                {
                    cartesianChart1.AxisY[0].MaxValue = 1;
                }


                cartesianChart1.AxisY[0].Separator = new Separator { Step = 1 };

                cartesianChart1.Series.Add(new LineSeries
                {
                    Title = "Daily Sales Quantity",
                    Values = new ChartValues<DateTimePoint>(
                        salesData.Select(x => new DateTimePoint(x.Date, x.TotalQuantity))
                    ),
                    PointGeometrySize = 15,
                    StrokeThickness = 2,
                    DataLabels = true
                });
            }
            else
            {
                cartesianChart1.Series.Clear();

                // If no sales data, set axes to a small, valid default range
                cartesianChart1.AxisX[0].Labels = null;
                cartesianChart1.AxisX[0].MinValue = 0;
                cartesianChart1.AxisX[0].MaxValue = 1;

                cartesianChart1.AxisY[0].MinValue = 0;
                cartesianChart1.AxisY[0].MaxValue = 1;
                cartesianChart1.AxisY[0].Separator = new Separator { Step = 1 };
            }
        }

        private void ExportToCSV(DataGridView dgv, string fileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
                   {
                       Filter = "CSV file (*.csv)|*.csv",
                       FileName = fileName
                   })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        var headers = dgv.Columns.Cast<DataGridViewColumn>();
                        sw.WriteLine(string.Join(",", headers.Select(c => "\"" + c.HeaderText + "\"")));

                        // Write data
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sw.WriteLine(string.Join(",", cells.Select(c => "\"" + c.Value?.ToString() + "\"")));
                            }
                        }
                    }
                    MessageBox.Show("CSV exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            ExportToCSV(salesDataGridView, "Sales.csv");
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadSalesData();
        }
    }
}
