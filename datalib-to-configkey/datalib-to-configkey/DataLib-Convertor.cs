using Microsoft.Extensions.Configuration;
using Serilog;
using System.Configuration;

namespace datalib_to_configkey
{
    public partial class Form1 : Form
    {
        string? selectedFilePath;

        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Set timer interval to 1 second (1000 ms)
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        // Loading configuration from AppSettings.json
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("AppSettings.json")
            .Build();

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display current date and time on lblDT
            lblDT.Text = DateTime.Now.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogCSV = new OpenFileDialog())
            {
                openFileDialogCSV.InitialDirectory = "c:\\";
                openFileDialogCSV.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialogCSV.FilterIndex = 1;

                if (openFileDialogCSV.ShowDialog() == DialogResult.OK)
                {

                    selectedFilePath = openFileDialogCSV.FileName;

                    lblSelectedFile.Text = selectedFilePath;
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Close this Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string? outputFilePath = configuration["CsvProcessorSettings:OutputTextFilePath"];

            try
            {
                string[] lines = File.ReadAllLines(selectedFilePath);

                if (lines.Length > 1)
                {
                    string header = lines[0];
                    IEnumerable<string> secondColumnValues = lines.Skip(1)
                        .Select(line => line.Split(',')[1].Trim());

                    IEnumerable<string> formattedOutput = secondColumnValues
                        .Select(value => $"<add key=\"enable.redirect.{value.ToLower()}\" value=\"true\"/>");

                    File.WriteAllLines(outputFilePath, formattedOutput);

                    Log.Information($"Output written to: {outputFilePath}");
                    lblOutput.Text = outputFilePath;
                }
                else
                {
                    Log.Error("The CSV file is empty or contains only headers.");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred: {ex.Message}");
            }

        }


    }
}
