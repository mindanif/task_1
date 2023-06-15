namespace Task_for_exam_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            // Bounds
            var a = Convert.ToDouble(leftBound.Text);
            var b = Convert.ToDouble(rightBound.Text);

            Function function = new Function(a, b);

            Consumer consumer = new Consumer();

            Producer p1 = new Producer(0);
            Producer p2 = new Producer(1);
            Producer p3 = new Producer(2);


            var count = 3;

            var step = (b-a) / count;

            p1.Start(function, a, a + step);
            p2.Start(function, a + step, a + 2*step);
            p3.Start(function, a + 2*step, b);

            var _tResult = CommonData.Get();
            var result = _tResult.Sum();

            label1.Text = result.ToString();
            //consumer.Start(label1);

        }
    }
}