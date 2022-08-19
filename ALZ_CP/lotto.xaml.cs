namespace ALZ_CP;

public partial class lotto : ContentPage
{
	Random r = new Random();
	
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
		int i = 0;
		int[] numbers = new int[6];

		for (int j = 0; j < 6; j++)
		{
			i = r.Next(1, 50);
			numbers[j] = i;
		}
		Array.Sort(numbers);
		LBL_nb.Text = string.Join(" ", numbers);

	}
}