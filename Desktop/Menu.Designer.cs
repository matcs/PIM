namespace Desktop
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.fisrtPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.BestCustomers = new System.Windows.Forms.Button();
            this.chartActives = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ListBestCustomers = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.fisrtPanel.SuspendLayout();
            this.Nav_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActives)).BeginInit();
            this.SuspendLayout();
            // 
            // fisrtPanel
            // 
            this.fisrtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.fisrtPanel.Controls.Add(this.flowLayoutPanel2);
            this.fisrtPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fisrtPanel.Location = new System.Drawing.Point(229, 0);
            this.fisrtPanel.Name = "fisrtPanel";
            this.fisrtPanel.Size = new System.Drawing.Size(571, 100);
            this.fisrtPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(568, 97);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // Nav_panel
            // 
            this.Nav_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.Nav_panel.Controls.Add(this.header_panel);
            this.Nav_panel.Controls.Add(this.Button1);
            this.Nav_panel.Controls.Add(this.Button2);
            this.Nav_panel.Controls.Add(this.BestCustomers);
            this.Nav_panel.Controls.Add(this.Exit);
            this.Nav_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Nav_panel.Location = new System.Drawing.Point(0, 0);
            this.Nav_panel.Name = "Nav_panel";
            this.Nav_panel.Size = new System.Drawing.Size(229, 450);
            this.Nav_panel.TabIndex = 1;
            this.Nav_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Controls.Add(this.pictureBox1);
            this.header_panel.Location = new System.Drawing.Point(3, 3);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(220, 75);
            this.header_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SysInfo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(3, 88);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(220, 40);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Inicio";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(3, 138);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(220, 40);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Contas Ativas";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BestCustomers
            // 
            this.BestCustomers.AutoSize = true;
            this.BestCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BestCustomers.FlatAppearance.BorderSize = 0;
            this.BestCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.BestCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BestCustomers.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestCustomers.ForeColor = System.Drawing.Color.White;
            this.BestCustomers.Image = ((System.Drawing.Image)(resources.GetObject("BestCustomers.Image")));
            this.BestCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BestCustomers.Location = new System.Drawing.Point(3, 188);
            this.BestCustomers.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.BestCustomers.Name = "BestCustomers";
            this.BestCustomers.Size = new System.Drawing.Size(220, 66);
            this.BestCustomers.TabIndex = 4;
            this.BestCustomers.Text = "Maiores\r\nInvestidores";
            this.BestCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BestCustomers.UseVisualStyleBackColor = true;
            this.BestCustomers.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // chartActives
            // 
            chartArea1.Name = "ChartArea1";
            this.chartActives.ChartAreas.Add(chartArea1);
            this.chartActives.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartActives.Legends.Add(legend1);
            this.chartActives.Location = new System.Drawing.Point(229, 100);
            this.chartActives.Name = "chartActives";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartActives.Series.Add(series1);
            this.chartActives.Size = new System.Drawing.Size(571, 350);
            this.chartActives.TabIndex = 2;
            this.chartActives.Text = "chart1";
            // 
            // ListBestCustomers
            // 
            this.ListBestCustomers.FormattingEnabled = true;
            this.ListBestCustomers.Location = new System.Drawing.Point(287, 138);
            this.ListBestCustomers.Name = "ListBestCustomers";
            this.ListBestCustomers.Size = new System.Drawing.Size(383, 251);
            this.ListBestCustomers.TabIndex = 3;
            this.ListBestCustomers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(3, 260);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Sair";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ListBestCustomers);
            this.Controls.Add(this.chartActives);
            this.Controls.Add(this.fisrtPanel);
            this.Controls.Add(this.Nav_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.fisrtPanel.ResumeLayout(false);
            this.Nav_panel.ResumeLayout(false);
            this.Nav_panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActives)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fisrtPanel;
        private System.Windows.Forms.FlowLayoutPanel Nav_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActives;
        private System.Windows.Forms.Button BestCustomers;
        private System.Windows.Forms.ListBox ListBestCustomers;
        private System.Windows.Forms.Button Exit;
    }
}

