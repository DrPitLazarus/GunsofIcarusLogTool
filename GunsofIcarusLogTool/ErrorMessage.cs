using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    public static class ErrorMessage
    {
        public static void ShowErrorMessage(string message, string title = "Error")
        {
            MessageBox.Show(message,
                            title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public static void ShowAlertMessage(string message, string title = "Alert")
        {
            MessageBox.Show(message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
