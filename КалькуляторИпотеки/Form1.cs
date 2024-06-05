using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting; // Добавьте это пространство имен

namespace КалькуляторИпотеки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonGraf.Click += GrafON;
            // Инициализируйте Chart здесь, если нужно
            InitializeChart();
        }

        static int i = 0;

        private void InitializeChart()
        {
            grafFinanse.Series.Clear();
            grafFinanse.Titles.Add("Ипотечные платежи");
            grafFinanse.ChartAreas[0].AxisX.Title = "Месяц";
            grafFinanse.ChartAreas[0].AxisY.Title = "Сумма платежа, ₽";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            grafFinanse.Hide();
            tableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableData.ColumnCount = 6;
            tableData.Columns[0].Name = "№"; //загрузка столбцов в datagridview
            tableData.Columns[1].Name = "Месяц";
            tableData.Columns[2].Name = "Еж.Платеж";
            tableData.Columns[3].Name = "Платеж в банк";
            tableData.Columns[4].Name = "Платеж основного долга";
            tableData.Columns[5].Name = "Остаток основного долга";
            rbA.Checked = true;
        }

        private int datPars(string input) //парс с проверкой, при неправильном вводе выводить ошибку
        {
            int output = 0;
            if (int.TryParse(input, out output) && output >= 0) return output;
            else
            {
                MessageBox.Show("Ошибка в вводе данных");
                return 0;
            }
        }

        private void GrafON(object sender, EventArgs e) //включение/отключенние графа
        {
            Button button = (Button)sender;
            if (i == 0)
            {
                grafFinanse.Enabled = true;
                grafFinanse.Show();
                buttonGraf.Text = "Закрыть График";
                grafFinanse.BringToFront();
                i++;
            }
            else if (i == 1)
            {
                grafFinanse.Enabled = false;
                grafFinanse.Hide();
                buttonGraf.Text = "Нарисовать График";
                i = 0;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) //кнопка выхода
        {
            Application.Exit();
        }

        public int GetDaysInYear(int year) //узнать скольо дней в конкретном году
        {
            int daysInYear = DateTime.IsLeapYear(year) ? 366 : 365;
            return daysInYear;
        }

        private void annuitetnaa(out List<double> monthlyPayments)
        {
            monthlyPayments = new List<double>();
            int price = datPars(costNedv.Text);
            double rate = datPars(stavkaIpotek.Text);
            double startPercent = (double)datPars(StartVznos.Text) / 100;
            dateNow.Text = DateTime.Now.ToString("D");
            int years = datPars(dataKredit.Text);
            double startPay = price * startPercent;
            startSum.Text = startPay.ToString("N2") + " \u20BD";
            double summa = price - startPay;
            sumCredit.Text = summa.ToString("N2") + " \u20BD";
            int mouns = years * 12;
            double rateMounthe = rate / 12 / 100;
            dataEnd.Text = DateTime.Now.AddMonths(mouns).ToString("D");
            DateTime chetchik = DateTime.Now;
            double k = Math.Pow((1 + rateMounthe), mouns);
            double pay = summa * ((rateMounthe * k) / (k - 1));
            double pereplata = 0, debitMain = summa;

            for (int i = 0; i <= mouns; i++)
            {
                double payBank = (debitMain * (rate / 100) * DateTime.DaysInMonth(chetchik.Year, chetchik.Month)) / GetDaysInYear(chetchik.Year);
                pereplata += payBank;
                double payMain = pay - payBank;
                summa -= payMain;
                tableData.Rows.Add(i + 1, chetchik.ToString("D"), pay.ToString("N2") + " \u20BD", payBank.ToString("N2") + " \u20BD", payMain.ToString("N2") + " \u20BD", summa.ToString("N2") + " \u20BD");
                chetchik = chetchik.AddMonths(1);
                debitMain -= payBank;
                monthlyPayments.Add(pay); // добавляем ежемесячный платеж в список
            }
            overSum.Text = pereplata.ToString("N2") + " \u20BD";
        }

        private void differenc(out List<double> monthlyPayments)
        {
            monthlyPayments = new List<double>();
            int price = datPars(costNedv.Text);
            double rate = datPars(stavkaIpotek.Text);
            double startPercent = (double)datPars(StartVznos.Text) / 100;
            dateNow.Text = DateTime.Now.ToString("D");
            int years = datPars(dataKredit.Text);
            double startPay = price * startPercent;
            startSum.Text = startPay.ToString("N2") + " \u20BD";
            double summa = price - startPay;
            sumCredit.Text = summa.ToString("N2") + " \u20BD";
            int mouns = years * 12;
            double rateMounthe = rate / 12 / 100;
            dataEnd.Text = DateTime.Now.AddMonths(mouns).ToString("D");
            DateTime chetchik = DateTime.Now;
            double k = Math.Pow((1 + rateMounthe), mouns);
            double pay = summa * ((rateMounthe * k) / (k - 1));
            double pereplata = 0, debitMain = summa;
            double payMain = summa / mouns;

            for (int i = 0; i <= mouns; i++)
            {
                double debit = summa - (payMain * DateTime.DaysInMonth(chetchik.Year, chetchik.Month));
                double payBank = debit * rateMounthe;
                pereplata += payBank;
                summa -= payMain;
                pay = payMain + payBank;
                tableData.Rows.Add(i + 1, chetchik.ToString("D"), pay.ToString("N2") + " \u20BD", payBank.ToString("N2") + " \u20BD", payMain.ToString("N2") + " \u20BD", summa.ToString("N2") + " \u20BD");
                chetchik = chetchik.AddMonths(1);
                debitMain -= payBank;
                monthlyPayments.Add(pay); // добавляем ежемесячный платеж в список
            }
            overSum.Text = pereplata.ToString("N2") + " \u20BD";
        }

        private void ansver_Click(object sender, EventArgs e)
        {
            tableData.Rows.Clear();
            List<double> annuitetPayments = new List<double>();
            List<double> diffPayments = new List<double>();

            if (rbA.Checked == true)
            {
                annuitetnaa(out annuitetPayments);
            }
            if (rbD.Checked == true)
            {
                differenc(out diffPayments);
            }

            // Очищаем график перед добавлением новых данных
            grafFinanse.Series.Clear();

            // Добавляем данные аннуитетных платежей на график
            Series annuitetSeries = new Series("Аннуитетные платежи");
            annuitetSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < annuitetPayments.Count; i++)
            {
                annuitetSeries.Points.AddXY(i + 1, annuitetPayments[i]);
            }
            grafFinanse.Series.Add(annuitetSeries);

            // Добавляем данные дифференцированных платежей на график
            Series diffSeries = new Series("Дифференцированные платежи");
            diffSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < diffPayments.Count; i++)
            {
                diffSeries.Points.AddXY(i + 1, diffPayments[i]);
            }
            grafFinanse.Series.Add(diffSeries);
        }
    }
}
