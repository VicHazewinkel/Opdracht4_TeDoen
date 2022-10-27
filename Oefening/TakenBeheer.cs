namespace Oefening
{
    public partial class TakenBeheer : System.Windows.Forms.Form
    {
        public TakenBeheer()
        {
            InitializeComponent();
        }

        private void TakenBeheer_Load(object sender, EventArgs e)
        {

        }

        FouteRij<TeDoen> lijst = new FouteRij<TeDoen>(); 



        // Task Buttons 

        private void button_NextTask_Click(object sender, EventArgs e)
        {
            lijst.ToonVolgende();
            label_curentTaskOutput.Text = lijst.HuidigElement().ToString(); 
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            lijst.ZetAchteraanInRij();
            label_curentTaskOutput.Text = lijst.HuidigElement().ToString();
            label_TasksOutput.Text = lijst.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            lijst.UitRijVerwijderen(); 
            label_curentTaskOutput.Text = lijst.HuidigElement().ToString();
            label_TasksOutput.Text = lijst.ToString();

        }

        // Task Text Input 

        private void textBox_TitleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_InformationInput_Click(object sender, EventArgs e)
        {

        }

        // Input
        private void checkBox_Time_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_Input.Visible = !checkBox_Time.Checked;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string text = textBox_InformationInput.Text;
            string[] informatie = text.Split(", ");
            TeDoen task; 
            if (checkBox_Time.Checked)
            {
                task = new TeDoen(textBox_TitleInput.Text, informatie);
            } else
            {
                task = new TeDoen(textBox_TitleInput.Text, informatie, new DateTime()); 
            }
            lijst.InRijToevoegen(task);
            label_TasksOutput.Text =lijst.ToString();

            label_curentTaskOutput.Text = lijst.HuidigElement().ToString();
        }
    }
}