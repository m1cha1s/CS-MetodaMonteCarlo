namespace MetodaMonteCarlo
{
    public partial class Form1 : Form
    {
        const int a = 200;
        const int rectW = 2 * a;
        const int rectH = 2 * a;

        const int xOffset = 20;
        const int yOffset = 20;

        List<Point> points = new List<Point>();

        double pointsInRect = 0.0;
        double pointsInCircle = 0.0;

        Random random = new Random();

        Task generateTask;

        public Form1()
        {
            InitializeComponent();
        }


        async private void iterate_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                //while (true)
                for(int i = 0; i < 1000; i++)
                {
                    Point np = new Point(random.Next(rectW), random.Next(rectH));
                    points.Add(np);
                    pointsInRect++;
                    if ((np.X - a) * (np.X - a) + (np.Y - a) * (np.Y - a) <= a * a)
                        pointsInCircle++;

                    Task.Delay(1).Wait();
                }
            });

            points.Clear();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //points.Clear();

            g.DrawRectangle(Pens.Black, xOffset, yOffset, rectW, rectH);
            g.DrawEllipse(Pens.Black, xOffset, yOffset, rectW, rectH);

            for(int i = 0; i < points.Count; i++)
            {
                Point p = points[i];
                if ((p.X - a) * (p.X - a) + (p.Y - a) * (p.Y - a) <= a * a)
                    g.DrawEllipse(Pens.Red, p.X + xOffset, p.Y + yOffset, 2, 2);
                else
                    g.DrawEllipse(Pens.Black, p.X + xOffset, p.Y + yOffset, 2, 2);
            }   

            piLabel.Text = (4.0 * (pointsInCircle / pointsInRect)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            pictureBox1.Invalidate();
        }
    }
}