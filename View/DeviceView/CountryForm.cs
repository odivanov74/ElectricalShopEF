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
    public partial class CountryForm : Form
    {
        DeviceController deviceController = DeviceController.Instance;
        int idSelectedCountry = 0;

        public CountryForm()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private async void Add_Button_Click(object sender, EventArgs e)
        {
            var res = await deviceController.AddCountryAsync(new Country() { Name = Name_TextBox.Text });
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        private async void Edit_Button_Click(object sender, EventArgs e)
        {
            Country selectedCountry = new Country() { Id = idSelectedCountry, Name = Name_TextBox.Text };
            var res = await deviceController.EditCountryAsync(selectedCountry);
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        private async void Delete_Button_Click(object sender, EventArgs e)
        {
            var res = await deviceController.DeleteCountryAsync(idSelectedCountry);
            if (res == "") RefreshListBox();
            else MessageBox.Show(res);
        }

        public void RefreshListBox()
        {
            List<Country> countries = deviceController.GetAllCoutries();
            if(countries == null)
            {
                MessageBox.Show("Список стран не был получен из-за ошибки");
                return;
            }
            Country_ListBox.Items.Clear();
            countries.ForEach(c => Country_ListBox.Items.Add(c.Name));
            Name_TextBox.Text = "";
        }

        private void Country_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Country_ListBox.SelectedItem == null) return;
            Name_TextBox.Text = Country_ListBox.SelectedItem.ToString();
            idSelectedCountry = deviceController.GetCountryId(Name_TextBox.Text);
        }
    }
}
