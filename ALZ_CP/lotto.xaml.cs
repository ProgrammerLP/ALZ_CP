namespace ALZ_CP;

public partial class lotto : ContentPage
{
	Random r = new Random();
    int[] numbers = new int[6];

    public lotto()
	{
		InitializeComponent();
	}

	private void sz_btn_Clicked(object sender, EventArgs e)
	{
		int i = r.Next(0, 10);
		LBL_sz.Text = "Supernumber: " + i;
	}

	private void nb_btn_Clicked(object sender, EventArgs e)
	{
		Gen_NB();

	}

	void Gen_NB()
	{
		int i = 0;

        for (int j = 0; j < 6; j++)
        {
            i = r.Next(1, 50);
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
            else if (numbers[k] == numbers[5] && k != 5)
            {
                Gen_NB();
                break;
            }
        }
    }

}