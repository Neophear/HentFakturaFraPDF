using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Stiig;

namespace HentFakturaFraPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdPDF.ShowDialog();
        }

        private void ofdPDF_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = ofdPDF.FileName;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            dgvOutput.Rows.Clear();
            
            if (File.Exists(txtFilePath.Text))
            {
                try
                {
                    StringBuilder text = new StringBuilder();
                    Regex re = new Regex(@"(\+45\d+)(.*) (\d*\.?\d+,\d+)");

                    using (PdfReader reader = new PdfReader(File.OpenRead(txtFilePath.Text)))
                    {
                        pbBottom.Maximum = reader.NumberOfPages;

                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            foreach (Match m in re.Matches(PdfTextExtractor.GetTextFromPage(reader, i)))
                            {
                                SIMcard sim = GetInfoFromNumber(m.Groups[1].Value);
                                dgvOutput.Rows.Add(m.Groups[1], m.Groups[2], m.Groups[3], sim.Simnumber, $"{sim.Stabsnummer} {sim.Name}", sim.MANR);
                            }
                            pbBottom.PerformStep();
                        }
                    }

                    pbBottom.Value = 0;
                }
                catch (BadPdfFormatException)
                {
                    MessageBox.Show("PDF-filen kunne ikke læses");
                }
            }
            else
                MessageBox.Show("Filen findes ikke");
        }

        private SIMcard GetInfoFromNumber(string number)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.AddParameter("@Number", number.Substring(3), DbType.String);
            dal.AddParameter("@Simnumber", null, DbType.String, ParameterDirection.Output);
            dal.AddParameter("@MANR", null, DbType.String, ParameterDirection.Output);
            dal.AddParameter("@Stabsnummer", null, DbType.String, ParameterDirection.Output);
            dal.AddParameter("@Name", null, DbType.String, ParameterDirection.Output);
            dal.ExecuteScalar("SELECT @Simnumber = [Simnumber], @MANR = [MANR], @Stabsnummer = [Stabsnummer], @Name = [Name] FROM [SimcardView] WHERE [Number] = @Number");

            SIMcard sim = new SIMcard();
            sim.Number = number;
            sim.Simnumber = dal.GetParameterValue("@Simnumber").ToString();
            sim.MANR = dal.GetParameterValue("@MANR").ToString();
            sim.Stabsnummer = dal.GetParameterValue("@Stabsnummer").ToString();
            sim.Name = dal.GetParameterValue("@Name").ToString();

            dal.ClearParameters();
            return sim;
        }
    }

    class SIMcard
    {
        public string Number { get; set; }
        public string Simnumber { get; set; }
        public string MANR { get; set; }
        public string Stabsnummer { get; set; }
        public string Name { get; set; }
    }
}