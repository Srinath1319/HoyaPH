using CommunityToolkit.Maui.Views;

namespace HoyaPH.Test;

public partial class LoadingDialog
{

	public static LoadingDialog dialog = null;
	private LoadingDialog()
	{
		InitializeComponent();

	}

    public static LoadingDialog getInstance() { 
    
        if (dialog == null)
        {
            dialog = new LoadingDialog();
        }
        return dialog;
    }

    public void showDialog(Page page)
    {
        
        page.ShowPopup(dialog);
    }

    public void hideDialog()
    {
        if(dialog != null)
        {
            dialog.Close();
            dialog = null;
        }
        
	}

}