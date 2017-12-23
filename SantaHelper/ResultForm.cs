using System.Windows.Forms;

namespace SantaHelper
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void SetGiftsListFrom(string[] giftsList)
        {
            for (var i = 0; i < giftsList.Length; i++)
            {
                resultCheckedListBox.Items.Add(giftsList[i]);
                resultCheckedListBox.Items[i] = $"Kid #{i + 1}: {resultCheckedListBox.Items[i]}";
                resultCheckedListBox.SetItemChecked(i, true);
            }
        }
    }
}