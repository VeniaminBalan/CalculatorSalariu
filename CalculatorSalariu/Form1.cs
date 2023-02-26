namespace CalculatorSalariu
{
    public partial class Form1 : Form
    {
        const float SALAR_MINIM = 3000;
        public Form1()
        {
            InitializeComponent();
        }

        private void SalariuTextBox_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculeazaButton_Click(sender, EventArgs.Empty);
            }
        }

        private void CalculeazaButton_Click(object sender, EventArgs e)
        {

            string sbrutText = textLabel_SBrut.Text;

            if (sbrutText == "") 
            {
                label_SBRUT.Text = "Introduceti salariul brut";
                return;
            }
            label_SBRUT.Text = "";

            float sbrut = Convert.ToInt64(sbrutText);

            float CAS_angajat = sbrut / 4; // 25% din salariul brut
            float CASS_angajat = sbrut / 10; // 10% din salariul brut
            float Sdpc = sbrut - CAS_angajat - CASS_angajat;

            float DP_procent = Deducerea_personala(sbrut);
            float DP = (SALAR_MINIM * DP_procent) / 100;
           
            float Sbi = Sdpc - DP;

            float Is = 0;
            float IS_procent = 0;
            if (!checkBox_impozit.Checked) 
            {
                IS_procent = 10;
                Is = Sbi / IS_procent; // cota de impozitare
                if (Is < 0) 
                {
                    Is = 0;
                    IS_procent = 0;
                }
            }

            float sNet = Sdpc - Is;

            label_Deducere.Text = DP.ToString("0.00") + $" ({DP_procent}%)";
            label_CAS.Text = CAS_angajat.ToString("0.00") + " (25%)";
            label_CASS.Text = CASS_angajat.ToString("0.00") + " (10%)"; ;
            label_Impozit.Text = Is.ToString("0.00") + $" ({IS_procent}%)";
            label_SNET.Text = sNet.ToString();

            float CAS_angajator = (float)(sbrut * 0) / 100; // ?
            float CASS_angajator = (float)(sbrut * 0) / 100; // ?
            float CAM_angajator = (float)(sbrut * 2.25) / 100;

            label_CAM_Angajator.Text = $"{CAM_angajator.ToString("0")} (2.25%)";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_SBRUT.Text = "";
        }



        private float map(float x, float x0, float x1, float y0, float y1)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }
        private float Deducerea_personala(float sbrut) 
        {
            float DP_procent = 0;

            if (sbrut <= SALAR_MINIM)
            {
                DP_procent = 20;

            }
            else if (sbrut > SALAR_MINIM && sbrut <= SALAR_MINIM + 2000)
            {
                DP_procent = map((sbrut - SALAR_MINIM), 0, 2000, 20, 0);

            }

            return DP_procent;
        }
    }
}