using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    public static class ErrorMessage
    {
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
