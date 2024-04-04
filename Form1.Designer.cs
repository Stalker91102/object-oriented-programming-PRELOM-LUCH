namespace PrelomLuch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.name4 = new System.Windows.Forms.Label();
            this.comboBoxSreda = new System.Windows.Forms.ComboBox();
            this.trackBarAngl = new System.Windows.Forms.TrackBar();
            this.buttonRas = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "0...90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(10, 6);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(163, 15);
            this.name1.TabIndex = 4;
            this.name1.Text = "Введите среду преломления";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(136, 94);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(111, 15);
            this.name2.TabIndex = 5;
            this.name2.Text = "Угол паден. луча =";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(136, 58);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(111, 15);
            this.name3.TabIndex = 6;
            this.name3.Text = "Коэфф. прелом. = ";
            // 
            // name4
            // 
            this.name4.AutoSize = true;
            this.name4.Location = new System.Drawing.Point(23, 24);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(124, 15);
            this.name4.TabIndex = 9;
            this.name4.Text = "(вода, масло, стекло)";
            // 
            // comboBoxSreda
            // 
            this.comboBoxSreda.FormattingEnabled = true;
            this.comboBoxSreda.Items.AddRange(new object[] {
            "Вода",
            "Масло",
            "Стекло"});
            this.comboBoxSreda.Location = new System.Drawing.Point(9, 55);
            this.comboBoxSreda.Name = "comboBoxSreda";
            this.comboBoxSreda.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSreda.TabIndex = 7;
            this.comboBoxSreda.SelectedIndexChanged += new System.EventHandler(this.comboBoxSreda_SelectedIndexChanged);
            // 
            // trackBarAngl
            // 
            this.trackBarAngl.Location = new System.Drawing.Point(10, 94);
            this.trackBarAngl.Maximum = 90;
            this.trackBarAngl.Name = "trackBarAngl";
            this.trackBarAngl.Size = new System.Drawing.Size(120, 45);
            this.trackBarAngl.TabIndex = 10;
            this.trackBarAngl.Scroll += new System.EventHandler(this.trackBarAngl_Scroll);
            // 
            // buttonRas
            // 
            this.buttonRas.Location = new System.Drawing.Point(7, 154);
            this.buttonRas.Name = "buttonRas";
            this.buttonRas.Size = new System.Drawing.Size(123, 28);
            this.buttonRas.TabIndex = 11;
            this.buttonRas.Text = "Рассчитать";
            this.buttonRas.UseVisualStyleBackColor = true;
            this.buttonRas.Click += new System.EventHandler(this.buttonRas_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(149, 154);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(16, 15);
            this.labelRes.TabIndex = 12;
            this.labelRes.Text = "   ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(360, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 420);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Угол преломления луча равен =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.buttonRas);
            this.Controls.Add(this.trackBarAngl);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.comboBoxSreda);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label name1;
        private Label name2;
        private Label name3;
        private Label name4;
        private ComboBox comboBoxSreda;
        private TrackBar trackBarAngl;
        private Button buttonRas;
        private Label labelRes;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
    }
}