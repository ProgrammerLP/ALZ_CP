namespace ALZ_CP;

public partial class Euro : ContentPage
{
    Random r = new Random();

	public Euro()
	{
		InitializeComponent();
	}

	private void ez_btn_Clicked(object sender, EventArgs e)
	{
        int i = 0;
        int[] numbers = new int[2];

        for (int j = 0; j < 2; j++)
        {
            i = r.Next(1, 13);
            numbers[j] = i;
        }
        Array.Sort(numbers);
        LBL_en.Text = "Euronumbers: " + string.Join(" ", numbers);
    }

	private void nb_btn_Clicked(object sender, EventArgs e)
	{
        int i = 0;
        int[] numbers = new int[5];

        for (int j = 0; j < 5; j++)
        {
            i = r.Next(1, 51);
            numbers[j] = i;
        }
        Array.Sort(numbers);
        LBL_nb.Text = string.Join(" ", numbers);
    }
}