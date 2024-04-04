using System.Numerics;
using System.Security.Cryptography;

namespace PrelomLuch
{
    public partial class Form1 : Form
    {
        public double angpadstart = 0;
        

        public Form1()
        {
            InitializeComponent();
            comboBoxSreda.SelectedIndexChanged += comboBoxSreda_SelectedIndexChanged;
        }

        public double Result1(double angpadstart, double nair, double nspace)
        {
            double angprem = 0;
            angprem = Math.Sin(angpadstart * Math.PI / 180) * nair / nspace;
            double angprem1;
            angprem1 = (180 * angprem) / 3.14;
            return angprem1;
        }
        
        private void comboBoxSreda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = comboBoxSreda.SelectedItem.ToString();
            double nspace = 0.0;

            switch (op)
            {
                case "¬ода":
                    nspace = 1.33;
                    break;
                case "ћасло":
                    nspace = 1.48;
                    break;
                case "—текло":
                    nspace = 1.5;
                    break;
            }
            label2.Text = nspace.ToString();
        }

        private void trackBarAngl_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBarAngl.Value.ToString();
        }

        private void buttonRas_Click(object sender, EventArgs e)
        {
            try
            {
                double nspace = Convert.ToDouble(label2.Text);
                double nair = 1.003;
                angpadstart = Convert.ToDouble(label1.Text);

                textBox1.Text = Convert.ToString( Math.Round((Result1(angpadstart, nair, nspace)),2));

                groupBox1.Refresh();

                Draw();
            }
            catch 
            {
                    
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Draw()
        {
            // луч падени€ 
            Pen axisPad = new Pen(Color.Orange, 3);
            Pen axisPrem = new Pen(Color.Orange, 3);
            Pen axisX = new Pen(Color.Black, 2);
            Pen axisY = new Pen(Color.Black, 2);
            
            double angprem = Convert.ToDouble(textBox1.Text);
            int radius = 150;
            
            //координаты луча падени€
            double x1 = 210;
            double y1 = 210;
            
            //координаты луча преломлени€
            double x21 = 210;
            double y21 = 210;
            
            //ортогональные оси 
            int horix1 = 5;
            int horiy1 = 210;
            int horix2 = 415;
            int horiy2 = 210;

            int vertx1 = 210;
            int verty1 = 10;
            int vertx2 = 210;
            int verty2 = 415;

            //вторые координаты лучей
            double x2 = x1 - radius * Math.Cos((90-angpadstart) * (Math.PI/180));
            double y2 = y1 - radius * Math.Sin((90-angpadstart) * (Math.PI / 180));
            double x22 = x21 + radius * Math.Cos((90-angprem) * (Math.PI / 180));
            double y22 = y21 + radius * Math.Sin((90 - angprem) * (Math.PI / 180)); 

            Graphics gr = groupBox1.CreateGraphics();
            {
                gr.DrawLine(axisPad, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
                gr.DrawLine(axisPrem,Convert.ToInt32(x21),Convert.ToInt32(y21),Convert.ToInt32(x22),Convert.ToInt32(y22));
                gr.DrawLine(axisX, horix1, horiy1, horix2, horiy2);
                gr.DrawLine(axisY,vertx1,verty1,vertx2,verty2);
            }
        } 
    } 
}
    
