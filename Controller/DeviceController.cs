using ElectricalDevicesEF.Model;
using ElectricalShopEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDevicesEF.Controller
{
    public class DeviceController
    {
        private readonly AppDbContext _context;

        public static DeviceController Instance { get => DeviceControllerCreate.instance;  }

        private DeviceController()
        {
            _context = new AppDbContext();            
        }
        private class DeviceControllerCreate
        {
            static DeviceControllerCreate() { }
            internal static readonly DeviceController instance = new DeviceController();
        }

        #region country
        public async Task<string> AddCountryAsync(Country country)
        {
            string outStr = "";
            if (string.IsNullOrWhiteSpace(country.Name) == true) return "Некорректные данные";
            try
            {
                if(_context.Countries.FirstOrDefault(c => c.Name == country.Name) != null) return "Такая страна уже имеется в базе";
                _context.Countries.Add(country);
                var res = await _context.SaveChangesAsync();
                if (res == 0) return "Ошибка записи новой страны в базу данных";
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public async Task<string> EditCountryAsync(Country country)
        {
            string outStr = "";
            if (string.IsNullOrWhiteSpace(country.Name) == true) return "Некорректные данные";
            try
            {
                Country editCountry = _context.Countries.ToList().FirstOrDefault(c => c.Id == country.Id);
                editCountry.Name = country.Name;
                var res = await _context.SaveChangesAsync();
                if (res == 0) outStr = "Ошибка записи изменений в базу данных";               
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public async Task<string> DeleteCountryAsync(int selectedCountryId)
        {
            string outStr = "";
            try
            {
                Country delCountry = _context.Countries.ToList().FirstOrDefault(c => c.Id == selectedCountryId);
                _context.Countries.Remove(delCountry);
                 var res = await _context.SaveChangesAsync();
                if (res == 0) outStr = "Ошибка удаления из базы данных";
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public int GetCountryId(string countryName)
        {
            return (_context.Countries.ToList().FirstOrDefault(c => c.Name == countryName)).Id;            
        }

        public List<Country> GetAllCoutries()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        #endregion

        #region supplier
        public async Task<string> AddSupplierAsync(Supplier supplier)
        {
            string outStr = "";
            if (string.IsNullOrWhiteSpace(supplier.Name) == true) return "Некорректные данные";
            try
            {
                if (_context.Suppliers.FirstOrDefault(s => s.Name == supplier.Name) != null) return "Такой поставщик уже имеется в базе";
                _context.Suppliers.Add(supplier);
                var res = await _context.SaveChangesAsync();
                if (res == 0) return "Ошибка записи нового поставщика в базу данных";
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public async Task<string> EditSupplierAsync(Supplier supplier)
        {   
            string outStr = "";
            if (string.IsNullOrWhiteSpace(supplier.Name) == true) return "Некорректные данные";
            try
            {
                Supplier editSupplier = _context.Suppliers.ToList().FirstOrDefault(s => s.Id == supplier.Id);
                editSupplier.Name = supplier.Name;
                var res = await _context.SaveChangesAsync();
                if (res == 0) outStr = "Ошибка записи изменений в базу данных";
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public async Task<string> DeleteSupplierAsync(int selectedSupplierId)
        {
            string outStr = "";
            try
            {
                Supplier delSupplier = _context.Suppliers.ToList().FirstOrDefault(s => s.Id == selectedSupplierId);
                _context.Suppliers.Remove(delSupplier);
                var res = await _context.SaveChangesAsync();
                if (res == 0) outStr = "Ошибка удаления из базы данных";
            }
            catch (Exception ex)
            {
                outStr = ex.Message;
            }
            return outStr;
        }

        public int GetSupplierId(string supplierName)
        {
            return (_context.Suppliers.ToList().FirstOrDefault(s => s.Name == supplierName)).Id;
        }

        public List<Supplier> GetAllSuppliers()
        {
            try
            {
                return _context.Suppliers.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }

        #endregion
    }
}
