namespace ALZ_CP;

public partial class Euro : ContentPage
{
    Random r = new Random();
    int[] eznumbers = new int[2];
    int[] numbers = new int[5];

    public Euro()
	{
		InitializeComponent();
	}

	private void ez_btn_Clicked(object sender, EventArgs e)
	{
        Gen_SN();
    }

	private void nb_btn_Clicked(object sender, EventArgs e)
	{
        Gen_NB();
    }

    void Gen_NB()
    {
        int i = 0;

        for (int j = 0; j < 5; j++)
        {
            i = r.Next(1, 51);
            numbers[j] = i;
        }

        Array.Sort(numbers);
        LBL_nb.Text = string.Join(", ", numbers);

        Check();
    }

    void Check()
    {
        for (int k = 0; k < numbers.Length; k++)
        {
            if (numbers[k] == numbers[0] && k != 0)
            {
                Gen_NB();
                break;

            }
            else if (numbers[k] == numbers[1] && k != 1)
            {
                Gen_NB();
                break;
            }
            else if (numbers[k] == numbers[2] && k != 2)
            {
                Gen_NB();
                break;
            }
            else if (numbers[k] == numbers[3] && k != 3)
            {
                Gen_NB();
                break;
            }
            else if (numbers[k] == numbers[4] && k != 4)
            {
                Gen_NB();
                break;
            }
        }
    }

    void Gen_SN()
    {
        int i = 0;

        for (int j = 0; j < 2; j++)
        {
            i = r.Next(1, 13);
            eznumbers[j] = i;
        }

        Array.Sort(eznumbers);
        LBL_en.Text = "Euronumbers: " + string.Join(", ", eznumbers);

        CheckEZ();
    }

    void CheckEZ()
    {
        for (int k = 0; k < eznumbers.Length; k++)
        {
            if (eznumbers[k] == eznumbers[0] && k != 0)
            {
                Gen_SN();
                break;

            }
            else if (eznumbers[k] == eznumbers[1] && k != 1)
            {
                Gen_SN();
                break;
            }
        }
    }

}