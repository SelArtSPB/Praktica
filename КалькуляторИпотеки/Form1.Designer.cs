namespace КалькуляторИпотеки
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGraf = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.GroupBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.ansver = new System.Windows.Forms.Button();
            this.StartVznos = new System.Windows.Forms.TextBox();
            this.stavkaIpotek = new System.Windows.Forms.TextBox();
            this.dataKredit = new System.Windows.Forms.TextBox();
            this.costNedv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputData = new System.Windows.Forms.GroupBox();
            this.overSum = new System.Windows.Forms.TextBox();
            this.sumCredit = new System.Windows.Forms.TextBox();
            this.startSum = new System.Windows.Forms.TextBox();
            this.dataEnd = new System.Windows.Forms.TextBox();
            this.dateNow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.grafFinanse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputData.SuspendLayout();
            this.outputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafFinanse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGraf
            // 
            this.buttonGraf.Location = new System.Drawing.Point(660, 40);
            this.buttonGraf.Name = "buttonGraf";
            this.buttonGraf.Size = new System.Drawing.Size(275, 70);
            this.buttonGraf.TabIndex = 0;
            this.buttonGraf.Text = "Нарисовать График";
            this.buttonGraf.UseVisualStyleBackColor = true;
            // 
            // inputData
            // 
            this.inputData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.inputData.Controls.Add(this.rbD);
            this.inputData.Controls.Add(this.rbA);
            this.inputData.Controls.Add(this.ansver);
            this.inputData.Controls.Add(this.StartVznos);
            this.inputData.Controls.Add(this.stavkaIpotek);
            this.inputData.Controls.Add(this.dataKredit);
            this.inputData.Controls.Add(this.costNedv);
            this.inputData.Controls.Add(this.label4);
            this.inputData.Controls.Add(this.label3);
            this.inputData.Controls.Add(this.label2);
            this.inputData.Controls.Add(this.label1);
            this.inputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputData.Location = new System.Drawing.Point(30, 150);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(661, 272);
            this.inputData.TabIndex = 1;
            this.inputData.TabStop = false;
            this.inputData.Text = "Входные Данные";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(476, 216);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(185, 22);
            this.rbD.TabIndex = 9;
            this.rbD.TabStop = true;
            this.rbD.Text = "Дифференцированная";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(476, 178);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(104, 22);
            this.rbA.TabIndex = 7;
            this.rbA.TabStop = true;
            this.rbA.Text = "Аннуитетая";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // ansver
            // 
            this.ansver.BackColor = System.Drawing.Color.Cyan;
            this.ansver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ansver.Location = new System.Drawing.Point(25, 209);
            this.ansver.Name = "ansver";
            this.ansver.Size = new System.Drawing.Size(445, 36);
            this.ansver.TabIndex = 8;
            this.ansver.Text = "Рассчитать";
            this.ansver.UseVisualStyleBackColor = false;
            this.ansver.Click += new System.EventHandler(this.ansver_Click);
            // 
            // StartVznos
            // 
            this.StartVznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartVznos.Location = new System.Drawing.Point(228, 172);
            this.StartVznos.Name = "StartVznos";
            this.StartVznos.Size = new System.Drawing.Size(242, 26);
            this.StartVznos.TabIndex = 7;
            // 
            // stavkaIpotek
            // 
            this.stavkaIpotek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stavkaIpotek.Location = new System.Drawing.Point(228, 133);
            this.stavkaIpotek.Name = "stavkaIpotek";
            this.stavkaIpotek.Size = new System.Drawing.Size(242, 26);
            this.stavkaIpotek.TabIndex = 6;
            // 
            // dataKredit
            // 
            this.dataKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataKredit.Location = new System.Drawing.Point(228, 93);
            this.dataKredit.Name = "dataKredit";
            this.dataKredit.Size = new System.Drawing.Size(242, 26);
            this.dataKredit.TabIndex = 5;
            // 
            // costNedv
            // 
            this.costNedv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costNedv.Location = new System.Drawing.Point(228, 53);
            this.costNedv.Name = "costNedv";
            this.costNedv.Size = new System.Drawing.Size(242, 26);
            this.costNedv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Первоначальный взнос (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ставка по ипотеке (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок кредитования (лет)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена недвижимости (руб)";
            // 
            // outputData
            // 
            this.outputData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.outputData.Controls.Add(this.overSum);
            this.outputData.Controls.Add(this.sumCredit);
            this.outputData.Controls.Add(this.startSum);
            this.outputData.Controls.Add(this.dataEnd);
            this.outputData.Controls.Add(this.dateNow);
            this.outputData.Controls.Add(this.label9);
            this.outputData.Controls.Add(this.label8);
            this.outputData.Controls.Add(this.label7);
            this.outputData.Controls.Add(this.label6);
            this.outputData.Controls.Add(this.label5);
            this.outputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputData.Location = new System.Drawing.Point(697, 154);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(563, 268);
            this.outputData.TabIndex = 2;
            this.outputData.TabStop = false;
            this.outputData.Text = "Расчёты";
            // 
            // overSum
            // 
            this.overSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overSum.Location = new System.Drawing.Point(288, 201);
            this.overSum.Name = "overSum";
            this.overSum.ReadOnly = true;
            this.overSum.Size = new System.Drawing.Size(242, 26);
            this.overSum.TabIndex = 9;
            // 
            // sumCredit
            // 
            this.sumCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCredit.Location = new System.Drawing.Point(288, 164);
            this.sumCredit.Name = "sumCredit";
            this.sumCredit.ReadOnly = true;
            this.sumCredit.Size = new System.Drawing.Size(242, 26);
            this.sumCredit.TabIndex = 8;
            // 
            // startSum
            // 
            this.startSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSum.Location = new System.Drawing.Point(288, 125);
            this.startSum.Name = "startSum";
            this.startSum.ReadOnly = true;
            this.startSum.Size = new System.Drawing.Size(242, 26);
            this.startSum.TabIndex = 7;
            // 
            // dataEnd
            // 
            this.dataEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataEnd.Location = new System.Drawing.Point(288, 88);
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.ReadOnly = true;
            this.dataEnd.Size = new System.Drawing.Size(242, 26);
            this.dataEnd.TabIndex = 6;
            // 
            // dateNow
            // 
            this.dateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateNow.Location = new System.Drawing.Point(288, 49);
            this.dateNow.Name = "dateNow";
            this.dateNow.ReadOnly = true;
            this.dateNow.Size = new System.Drawing.Size(242, 26);
            this.dateNow.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Переплата:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Сумма кредита:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Первоначальный взнос:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дата окончания платежений:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата начала платежений:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(985, 40);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(275, 70);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // grafFinanse
            // 
            chartArea1.Name = "ChartArea1";
            this.grafFinanse.ChartAreas.Add(chartArea1);
            this.grafFinanse.Enabled = false;
            legend1.Name = "Legend1";
            this.grafFinanse.Legends.Add(legend1);
            this.grafFinanse.Location = new System.Drawing.Point(30, 132);
            this.grafFinanse.Name = "grafFinanse";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafFinanse.Series.Add(series1);
            this.grafFinanse.Size = new System.Drawing.Size(1236, 667);
            this.grafFinanse.TabIndex = 0;
            this.grafFinanse.Text = "chart1";
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.AllowUserToDeleteRows = false;
            this.tableData.AllowUserToResizeColumns = false;
            this.tableData.AllowUserToResizeRows = false;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Location = new System.Drawing.Point(30, 428);
            this.tableData.Name = "tableData";
            this.tableData.ReadOnly = true;
            this.tableData.RowHeadersVisible = false;
            this.tableData.Size = new System.Drawing.Size(1236, 371);
            this.tableData.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(187, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(469, 42);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ипотечный Калькулятор";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.grafFinanse);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputData);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.buttonGraf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "КалькуляторИпотеки";
            this.Load += new System.EventHandler(this.Form_Load);
            this.inputData.ResumeLayout(false);
            this.inputData.PerformLayout();
            this.outputData.ResumeLayout(false);
            this.outputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafFinanse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGraf;
        private System.Windows.Forms.GroupBox inputData;
        private System.Windows.Forms.GroupBox outputData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafFinanse;
        private System.Windows.Forms.TextBox StartVznos;
        private System.Windows.Forms.TextBox stavkaIpotek;
        private System.Windows.Forms.TextBox dataKredit;
        private System.Windows.Forms.TextBox costNedv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.Button ansver;
        private System.Windows.Forms.TextBox overSum;
        private System.Windows.Forms.TextBox sumCredit;
        private System.Windows.Forms.TextBox startSum;
        private System.Windows.Forms.TextBox dataEnd;
        private System.Windows.Forms.TextBox dateNow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbA;
    }
}

