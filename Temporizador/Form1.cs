namespace Temporizador
{
    public partial class Form1 : Form
    {
        private ZonaHorariaServicio _ZonaHorariaServicio;
        public Form1()
        {
            InitializeComponent();
            _ZonaHorariaServicio = new ZonaHorariaServicio();
        }

        

        private void Form1_load(object sender, EventArgs e)
        {
            local.Start();
            NY.Start();
            UK.Start();
            JP.Start();
        }

        private void local_Tick(object sender, EventArgs e)
        {
            lblhora1.Text = DateTime.Now.ToString("HH:mm");
            lblseg1.Text = DateTime.Now.ToString("ss");
            lblfecha1.Text = DateTime.Now.ToString("MMMM dd yyyy");
            lblDia1.Text = DateTime.Now.ToString("dddd");
        }

        private void NY_Tick(object sender, EventArgs e)
        {
            var zonaHoraria = _ZonaHorariaServicio.TomarFechaHoraActual("Eastern Standard Time");
            
            lblhora2.Text = zonaHoraria.ToString("HH:mm");
            lblseg2.Text = zonaHoraria.ToString("ss");
            lblfecha2.Text = zonaHoraria.ToString("MMMM dd yyyy");
            lbldia2.Text = zonaHoraria.ToString("dddd");
        }

        private void UK_Tick(object sender, EventArgs e)
        {
            var zonaHoraria = _ZonaHorariaServicio.TomarFechaHoraActual("GMT Standard Time");
           

            lblhora3.Text = zonaHoraria.ToString("HH:mm");
            lblseg3.Text = zonaHoraria.ToString("ss");
            lblfecha3.Text = zonaHoraria.ToString("MMMM dd yyyy");
            lbldia3.Text = zonaHoraria.ToString("dddd");
        }

        private void JP_Tick(object sender, EventArgs e)
        {
            var zonaHoraria = _ZonaHorariaServicio.TomarFechaHoraActual("Tokyo Standard Time");
            

            lblhora4.Text = zonaHoraria.ToString("HH:mm");
            lblseg4.Text = zonaHoraria.ToString("ss");
            lblfecha4.Text = zonaHoraria.ToString("MMMM dd yyyy");
            lbldia4.Text = zonaHoraria.ToString("dddd");
        }

       
    }
}