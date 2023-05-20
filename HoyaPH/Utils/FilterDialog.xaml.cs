
using CommunityToolkit.Maui.Views;


namespace HoyaPH.Utils;

public partial class FilterDialog 
{

	public static FilterDialog dialog = null;
	private FilterDialog()
	{
		InitializeComponent();
	}

	public static FilterDialog  getInstance()
	{
		if (dialog == null)
		{
            dialog = new FilterDialog();

		}
		return dialog;
	}


	public void showDialog(Page page) {


		page.ShowPopup(dialog);
	
	}

    public void hideDialog()
    {
        if (dialog != null)
        {
            dialog.Close();
            dialog = null;
        }

    }



}