namespace clickerGame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Inventory inventory = new Inventory(9);
        public void updateInv()
        {
            inventoryListBox.Items.Clear();
            for (int i = 0; i < inventory.stored.Length; i++)
            {
                inventoryListBox.Items.Add(ID.item[inventory.stored[i].itemID].name);
            }
            inventoryListBox.Refresh();
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            updateInv();
        }

        private void testInvAddButton_Click(object sender, EventArgs e)
        {
            inventory.Store(Convert.ToInt32(testInvItemIDSelector.Value), Convert.ToInt32(testInvSlotSelecter.Value));
            updateInv();
        }

        private void testInvRMButton_Click(object sender, EventArgs e)
        {
            inventory.Remove(Convert.ToInt32(testInvSlotSelecter.Value));
            updateInv();
        }
    }
}