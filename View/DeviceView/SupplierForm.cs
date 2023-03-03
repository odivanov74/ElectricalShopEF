using ElectricalDevicesEF.Controller;
using ElectricalShopEF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricalDevicesEF.View.DeviceView
{
    public partial class SupplierForm : Form
    {
        DeviceController deviceController = DeviceController.Instance;
        int idSelectedSupplier = 0;

        public SupplierForm()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private async void Add_Button_Click(object sender, EventArgs e)
        {
            var res = await deviceController.AddSupplierAsync(new Supplier() { Name = Name_TextBox.Text });
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        private async void Edit_Button_Click(object sender, EventArgs e)
        {
            Supplier selectedSupplier = new Supplier() { Id = idSelectedSupplier, Name = Name_TextBox.Text };
            var res = await deviceController.EditSupplierAsync(selectedSupplier);
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        private async void Delete_Button_Click(object sender, EventArgs e)
        {
            var res = await deviceController.DeleteSupplierAsync(idSelectedSupplier);
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        private void Supplier_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Supplier_ListBox.SelectedItem == null) return;
            Name_TextBox.Text = Supplier_ListBox.SelectedItem.ToString();
            idSelectedSupplier = deviceController.GetSupplierId(Name_TextBox.Text);
        }

        public void RefreshListBox()
        {
            List<Supplier> suppliers = deviceController.GetAllSuppliers();
            if (suppliers == null)
            {
                MessageBox.Show("Список поставщиков не был получен из-за ошибки");
                return;
            }
            Supplier_ListBox.Items.Clear();
            suppliers.ForEach(s => Supplier_ListBox.Items.Add(s.Name));
            Name_TextBox.Text = "";
        }
    }
}
