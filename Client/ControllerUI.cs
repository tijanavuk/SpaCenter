using Domain;
using GeneratingPDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{

    public class ControllerUI
    {
        const String adminRole = "ADMIN";
        Communication c;
        TransferClass tc;
        
        public Employee e;
        public List<EmployeeRole> er;
        public Employee showEmployee;
        public Service showService;
        public Domain.Client showClient;
        public Loyalty showLoyalty;
        public ReceiptHeader showReceiptHeader;
        public ReceiptHeader receiptHeader;
        public bool adminRoleExist;

        public ControllerUI()
        {
            c = new Communication();
            tc = new TransferClass();
            e = new Employee();
            er = new List<EmployeeRole>();
            showEmployee = new Employee();
            showService = new Service();
            showClient = new Domain.Client();
            showLoyalty = new Loyalty();
            receiptHeader = new ReceiptHeader();
            showReceiptHeader = new ReceiptHeader();
            //ConnectToServer();
        }

        public bool ConnectToServer()
        {
            bool result = c.Connect();
            if (result)
            {
                MessageBox.Show("Successful connection to the server!");
                return true;

            }
            else
            {
                MessageBox.Show("Failed to connect to server!");
                return false;
            }

            //if (c.Connect())
            //{
            //    MessageBox.Show("Klijent je povezan na server!");
            //    return true;
            //}
            //else
            //{
            //    //throw new Exception("Klijent nije povezan na server!");
            //    MessageBox.Show("Neuspesna konekcija!");
            //    return false;
            //}
        }

        internal void ReturnAllEmployees(DataGridView dataGridViewEmployee)
        {
            List<Employee> employees = new List<Employee>();

            employees = c.ReturnAllEmployees();

            if (employees == null || employees.Count == 0)
            {
                dataGridViewEmployee.DataSource = null;
            }
            else
            {
                dataGridViewEmployee.DataSource = new BindingList<Employee>(employees);
            }
        }

        internal void ReturnAllLoyalties(DataGridView dataGridViewLoyalty)
        {
            List<Loyalty> loyalties = new List<Loyalty>();

            loyalties = c.ReturnLoyalties();

            if (loyalties == null || loyalties.Count == 0)
            {
                dataGridViewLoyalty.DataSource = null;
            }
            else
            {
                dataGridViewLoyalty.DataSource = new BindingList<Loyalty>(loyalties);
            }
        }

        internal void ReturnAllServices(DataGridView dataGridViewService)
        {
            List<Service> services = new List<Service>();

            Service service = new Service();
            services = c.SearchServices(service);

            if (services == null || services.Count == 0)
            {
                dataGridViewService.DataSource = null;
            }
            else
            {
                dataGridViewService.DataSource = new BindingList<Service>(services);
            }
        }

        internal void OpenReceiptLinesForm(DataGridView dataGridViewReceipt)
        {
            if (dataGridViewReceipt.CurrentRow != null)
            {
                ShowReceiptLinesForm rl = new ShowReceiptLinesForm(this, dataGridViewReceipt.CurrentRow.DataBoundItem as ReceiptHeader);
                rl.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select receipt!");
            }
        }

       

        internal void ReturnStatuses(ComboBox comboBoxStatuses)
        {
            comboBoxStatuses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatuses.DataSource = Enum.GetValues(typeof(Status));
            //comboBoxStatuses.SelectedItem = Status.None;
        }

        internal void ReturnAllReceipt(DataGridView dataGridViewReceipt)
        {
            List<ReceiptHeader> receipts = new List<ReceiptHeader>();

            ReceiptHeader receiptHeader = new ReceiptHeader();
            receipts = c.SearchReceipt(receiptHeader);

            if (receipts == null || receipts.Count == 0)
            {
                dataGridViewReceipt.DataSource = null;
            }
            else
            {
                dataGridViewReceipt.DataSource = new BindingList<ReceiptHeader>(receipts);
            }
        }

        

        #region Employee

        internal void ReturnSelectedEmployee(DataGridView dataGridViewEmployee)
        {
            if (dataGridViewEmployee.CurrentRow != null)
            {
                Employee selectedEmployee = new Employee();
                selectedEmployee = dataGridViewEmployee.CurrentRow.DataBoundItem as Employee;
                selectedEmployee = c.ReturnSelectedEmployee(selectedEmployee);
                if (selectedEmployee != null)
                {
                    ShowEmployee sc = new ShowEmployee(this, selectedEmployee);
                    sc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The system cannot load the employee.!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select loyalty!");
                return;
            }
        }

        internal void ReturnRoles(ComboBox comboBoxRoles)
        {
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.DataSource = c.ReturnRoles();
            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.SelectedItem = null;
        }

        internal void CheckRoles(ToolStripMenuItem employeeToolStripMenuItem, ToolStripMenuItem newLoyaltyToolStripMenuItem)
        {
            if (adminRoleExist)
            {
                employeeToolStripMenuItem.Visible = true;
                newLoyaltyToolStripMenuItem.Visible = true;
            }
        }

        public bool FindAdminRole()
        {
            foreach (EmployeeRole employeeRole in er)
            {
                if (employeeRole.RoleName == adminRole)
                {
                    return true;
                }
            }
            return false;
        }

        internal void SaveEmployeeRole(ComboBox comboBoxRoles, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo, CheckBox checkBoxDateTo, AddRoleForm addRoleForm)
        {
            if (comboBoxRoles.SelectedItem == null)
            {
                MessageBox.Show("Please select a role!");
                return;
            }

            EmployeeRole newEmplRol = new EmployeeRole();
            newEmplRol.Employee = showEmployee;
            newEmplRol.Role = comboBoxRoles.SelectedItem as Role;
            newEmplRol.DateFrom = dateTimePickerFrom.Value;
            newEmplRol.DateTo = DateTime.MinValue;
            if (checkBoxDateTo.Checked) newEmplRol.DateTo = dateTimePickerTo.Value;
            newEmplRol.Active = true;
            newEmplRol.CreatedBy = e;

            object o = c.SaveNewEmployeeRole(newEmplRol);

            if (o == null)
            {
                MessageBox.Show("Employee role has not been saved!");
                return;
            }
            else
            {
                MessageBox.Show("Employee role has been saved!");
                addRoleForm.Close();
            }
        }

        internal void ShowEmployeeRolesData(Employee showEmployee, DataGridView dataGridViewEmployeeRoles, ShowRolesForm form)
        {
            EmployeeRole employeeRole = new EmployeeRole();
            employeeRole.Employee = showEmployee;
            List<EmployeeRole> employeeRoles = c.ReturnRolesForEmployee(employeeRole);

            if (employeeRoles.Count == 0)
            {
                MessageBox.Show("There are no roles for the employee!");
                dataGridViewEmployeeRoles.DataSource = null;
                form.Close();

                return;
            }
            else
            {
                MessageBox.Show("The system found the rolls for the employee!");
                dataGridViewEmployeeRoles.DataSource = new BindingList<EmployeeRole>(employeeRoles);
            }
        }

        internal void EditEmployee(TextBox textBoxUsername, TextBox textBoxPassword, TextBox textBoxFirstName, TextBox textBoxLastName, DateTimePicker dateTimeOfEmployment, DateTimePicker dateTimeTermination, CheckBox checkBoxTerminationDate, ShowEmployee form)
        {
            showEmployee.username = textBoxUsername.Text;
            showEmployee.password = textBoxPassword.Text;
            showEmployee.firstName = textBoxFirstName.Text;
            showEmployee.lastName = textBoxLastName.Text;
            showEmployee.workStartDate = dateTimeOfEmployment.Value;
            if (checkBoxTerminationDate.Checked || checkBoxTerminationDate.Visible == false) showEmployee.WorkEndDate = dateTimeTermination.Value;



            object o = c.EditEmployee(showEmployee);

            if (o == null)
            {
                MessageBox.Show("Employee has not been changed! Check the entered data!");

            }
            else
            {
                MessageBox.Show("Employee has been changed!");
                form.Close();

            }

        }

        public void DeactiveEmployee(ShowEmployee form)
        {
            showEmployee.active = false;
            object o = c.EditEmployee(showEmployee);

            if (o != null)
            {
                MessageBox.Show("The selected employee has not been deleted!");

            }
            else
            {
                MessageBox.Show("The selected employee has been deleted!");
                form.Close();

            }
        }

        internal void ShowEmployeeData(TextBox textBoxUsername, TextBox textBoxPassword, TextBox textBoxFirstName, TextBox textBoxLastName, DateTimePicker dateTimeOfEmployment, DateTimePicker dateTimeTermination, CheckBox checkBoxTerminationDate, Label label6, ShowEmployee form)
        {
            try
            {
                textBoxUsername.Text = showEmployee.Username;
                textBoxPassword.Text = showEmployee.Password;
                textBoxFirstName.Text = showEmployee.FirstName;
                textBoxLastName.Text = showEmployee.LastName;
                dateTimeOfEmployment.Value = showEmployee.WorkStartDate;
                //if (showEmployee.WorkEndDate == DateTime.MinValue)
                //{
                //    dateTimeTermination.CustomFormat = "";
                //    dateTimeTermination.Format = DateTimePickerFormat.Custom;
                //}
                //else {
                //    dateTimeTermination.Value = showEmployee.WorkEndDate;
                //}
                if (showEmployee.WorkEndDate == DateTime.MinValue)
                {
                    checkBoxTerminationDate.Visible = true;
                    dateTimeTermination.Visible = false;
                    label6.Visible = false;
                }
                else
                {
                    dateTimeTermination.Value = showEmployee.WorkEndDate;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("The system cannot load the employee!");
                form.Close();
                return;
            }
        }

        internal void SearchEmployees(TextBox textBoxSearchEmployee, DataGridView dataGridViewEmployee)
        {
            List<Employee> employees = new List<Employee>();
            if (textBoxSearchEmployee.Text == "")
            {
                MessageBox.Show("Please enter a search value!");
                return;
            }
            if (textBoxSearchEmployee.Text.Count() > 0 && textBoxSearchEmployee.Text.Count() <= 3)
            {
                MessageBox.Show("You need to enter at least four characters for search!");
                return;
            }
                       
            Employee e = new Employee();
            e.Username = textBoxSearchEmployee.Text;
            employees = c.SearchEmployees(e);

            if (employees == null || employees.Count == 0)
            {
                MessageBox.Show("No employees found!");
                dataGridViewEmployee.DataSource = null;

                return;
            }
            else
            {
                MessageBox.Show("The system found employees!");
                dataGridViewEmployee.DataSource = new BindingList<Employee>(employees);
            }
        }

        public void SaveNewEmployee(TextBox textBoxUsername, TextBox textBoxPassword, TextBox textBoxFirstName, TextBox textBoxLastName, DateTimePicker dateTimeOfEmployment, DateTimePicker dateTimeTermination, CheckBox checkBoxTerminationDate, NewEmployeeForm form)
        {
            String mandatoryValues = "Please enter: ";
            bool thereIsEmptyValue = false;
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "username";
                else mandatoryValues = mandatoryValues + ",username";
                textBoxUsername.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "password";
                else mandatoryValues = mandatoryValues + ",password";
                textBoxPassword.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "first name";
                else mandatoryValues = mandatoryValues + ",first name";
                textBoxFirstName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "last name";
                else mandatoryValues = mandatoryValues + ",last name";
                textBoxLastName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (thereIsEmptyValue)
            {
                MessageBox.Show(mandatoryValues + "!");
                return;
            }

            Employee employee = new Employee();
            employee.Username = textBoxUsername.Text;
            employee.Password = textBoxPassword.Text;
            employee.FirstName = textBoxFirstName.Text;
            employee.LastName = textBoxLastName.Text;
            employee.WorkStartDate = dateTimeOfEmployment.Value;
            employee.WorkEndDate = DateTime.MinValue;
            if (checkBoxTerminationDate.Checked)
            {
                employee.WorkEndDate = dateTimeTermination.Value;
            }


            employee.Active = true;
            employee.CreatedBy = e;

            object o = c.SaveNewEmployee(employee);

            if (o == null)
            {
                MessageBox.Show("The employee has not been saved. Check the entered data!");
                return;
            }
            else
            {
                MessageBox.Show("The employee has been saved!");
                form.Close();
            }
        }

        internal void FindEmployee(TextBox textBoxUsername, TextBox textBoxPassword)
        {
            string mandatoryValues = "Please enter:";
            bool thereIsEmptyValue = false;

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text)) {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "username";
                else mandatoryValues = mandatoryValues + ",username";
                textBoxUsername.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "password";
                else mandatoryValues = mandatoryValues + ",password";
                textBoxPassword.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (thereIsEmptyValue)
            {
                MessageBox.Show(mandatoryValues + "!");
                return;
            }


            List<Employee> employees = new List<Employee>();
                Employee emplFromUI = new Employee();
                emplFromUI.Username = textBoxUsername.Text;
                emplFromUI.Password = textBoxPassword.Text;
                employees = c.FindEmployee(emplFromUI);
                if (employees == null || employees.Count() == 0)
                {
                    MessageBox.Show("The system cannot find the user based on the entered values! Check the entered data!");
                    return;
                }
                else
                {
                    e = employees[0];
                    EmployeeRole emplRole = new EmployeeRole();
                    emplRole.Employee = e;
                    er = c.ReturnRolesForEmployee(emplRole);
                    adminRoleExist = FindAdminRole();
                    MessageBox.Show("You have successfully logged into the system!");
                    new Form1(this).ShowDialog();
                }

        }

        #endregion

        #region Loyalty 

        internal void ReturnSelectedLoyalty(DataGridView dataGridViewLoyalty)
        {
            if (dataGridViewLoyalty.CurrentRow != null)
            {
                Loyalty selectedLoyalty = new Loyalty();
                selectedLoyalty = dataGridViewLoyalty.CurrentRow.DataBoundItem as Loyalty;
                selectedLoyalty = c.ReturnSelectedLoyalty(selectedLoyalty);
                if (selectedLoyalty != null)
                {
                    ShowLoyaltyForm sc = new ShowLoyaltyForm(this, selectedLoyalty);
                    sc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The selected loyalty no longer exists!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select loyalty!");
                return;
            }
        }

        internal void ShowLoyaltyData(TextBox textBoxName, TextBox textBoxDiscount, Button buttonDeactiveLoyalty, Button buttonEditLoyalty, ShowLoyaltyForm form)
        {
            try
            {
                textBoxName.Text = showLoyalty.Name;
                textBoxDiscount.Text = showLoyalty.Discount.ToString();

                if (!adminRoleExist)
                {
                    textBoxName.Enabled = false;
                    textBoxDiscount.Enabled = false;
                    buttonDeactiveLoyalty.Enabled = false;
                    buttonEditLoyalty.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("The system cannot find data about the selected loyalty!");
                form.Close();
                return;
            }
        }

        internal void EditLoyalty(TextBox textBoxName, TextBox textBoxDiscount, ShowLoyaltyForm form)
        {
            double discount;
            try
            {
                discount = Convert.ToDouble(textBoxDiscount.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the entered discount. Enter the numerical value for discount!");
                return;
            }
            if (discount < 0 || discount > 100) {
                MessageBox.Show("Enter a discount in the range from 0 to 100 %!");
                return;
            }
            showLoyalty.Discount = discount;
            showLoyalty.Name = textBoxName.Text;

            object o = c.EditLoyalty(showLoyalty);

            if (o == null)
            {
                MessageBox.Show("Loyalty has not been changed! Check the entered data!");

            }
            else
            {
                MessageBox.Show("Loyalty has been changed!");
                form.Close();

            }
        }

        internal void DeactiveLoyalty(ShowLoyaltyForm form)
        {
            showLoyalty.Active = false;
            object o = c.EditLoyalty(showLoyalty);

            if (o == null)
            {
                MessageBox.Show("Please select loyalty!");

            }
            else
            {
                MessageBox.Show("Loyalty has been deleted!");
                form.Close();

            }
        }

        public void SaveNewLoyalty(TextBox textBoxName, TextBox textBoxDiscount, NewLoyaltyForm form)
        {
            double discount;
            String mandatoryValues = "Please enter: ";
            bool thereIsEmptyValue = false;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "name";
                else mandatoryValues = mandatoryValues + ",name";
                textBoxName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxDiscount.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "discount";
                else mandatoryValues = mandatoryValues + ",discount";
                textBoxDiscount.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (thereIsEmptyValue)
            {
                MessageBox.Show(mandatoryValues + "!");
                return;
            }

            try
            {
                discount = Convert.ToDouble(textBoxDiscount.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the entered discount. Enter the numerical value of the discount!");
                return;
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Enter a discount in the range from 0 to 100 %!");
                return;
            }

            Loyalty loyalty = new Loyalty();
            loyalty.Name = textBoxName.Text;
            loyalty.Discount = discount;
            loyalty.Active = true;
            loyalty.CreatedBy = e;

            object o = c.SaveNewLoyalty(loyalty);

            if (o == null)
            {
                MessageBox.Show("Loyalty has not been saved! Check the entered data!");
                return;
            }
            else
            {
                MessageBox.Show("Loyalty has been saved!");
                form.Close();
            }


        }

        internal void SearchLoyalties(TextBox textBoxSearchLoyalty, DataGridView dataGridViewLoyalty)
        {
            List<Loyalty> loyalties = new List<Loyalty>();

            if (textBoxSearchLoyalty.Text.Count() == 0)
            {
                MessageBox.Show("Please enter a search value!");
                return;
            }

            if (textBoxSearchLoyalty.Text.Count() > 0 && textBoxSearchLoyalty.Text.Count() <= 3)
            {
                MessageBox.Show("You need to enter at least four characters for search!");
                return;
            }
          
            Loyalty l = new Loyalty();
            l.Name = textBoxSearchLoyalty.Text;
            loyalties = c.SearchLoyalties(l);

            if (loyalties == null || loyalties.Count == 0)
            {
                MessageBox.Show("No loyalty found!");
                dataGridViewLoyalty.DataSource = null;

                return;
            }
            else
            {
                MessageBox.Show("The system has found loyalties!");
                dataGridViewLoyalty.DataSource = new BindingList<Loyalty>(loyalties);
            }
        }

        public void ReturnLoyalties(ComboBox loyalty)
        {
            loyalty.DropDownStyle = ComboBoxStyle.DropDownList;
            loyalty.DataSource = c.ReturnLoyalties();
            loyalty.DisplayMember = "Name";
            loyalty.SelectedItem = null;
        }

        #endregion

        #region Service

        internal void ReturnSelectedService(DataGridView dataGridViewService)
        {
            if (dataGridViewService.CurrentRow != null)
            {
                Service selectedService = new Service();
                selectedService = dataGridViewService.CurrentRow.DataBoundItem as Service;
                List<Service> services = c.SearchServices(selectedService);
                if (services != null && services.Count > 0)
                {
                    ShowService sc = new ShowService(this, services[0]);
                    sc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The system cannot load data about the selected service!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select service!");
                return;
            }
        }

        public void ReturnCategories(ComboBox categories)
        {
            categories.DropDownStyle = ComboBoxStyle.DropDownList;
            categories.DataSource = c.ReturnCategories();
            categories.DisplayMember = "Name";
            categories.SelectedItem = null;
        }

        internal void EditService(TextBox textBoxName, TextBox textBoxDescription, TextBox textBoxPrice, ComboBox comboBoxCategory, ShowService form)
        {
            if (textBoxDescription.Text.Count() > 255) {
                MessageBox.Show("You have entered more than the allowed number of characters in the field Description! It is possible to enter a maximum of 255 characters.");
                return;
            }
            showService.name = textBoxName.Text;
            showService.description = textBoxDescription.Text;
            try
            {
                showService.price = Convert.ToDouble(textBoxPrice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the entered price. Enter the numerical value of the price!");
                return;
            }
            
            showService.Category = comboBoxCategory.SelectedItem as Category;

            object o = c.EditService(showService);

            if (o == null)
            {
                MessageBox.Show("Service has not been changed! Check the entered data!");

            }
            else
            {
                MessageBox.Show("Service has been changed!");
                form.Close();

            }
        }

        internal void ShowServiceData(TextBox textBoxName, TextBox textBoxDescription, TextBox textBoxPrice, ComboBox comboBoxCategory, ShowService form)
        {
            try
            {
                textBoxName.Text = showService.Name;
                textBoxDescription.Text = showService.Description;
                textBoxPrice.Text = showService.Price.ToString();
                ReturnCategories(comboBoxCategory);
                comboBoxCategory.Text = showService.category.Name;
            }
            catch (Exception)
            {

                MessageBox.Show("The system cannot load data for selected service!");
                form.Close();
                return;
            }
        }

        internal void DeactiveService(ShowService form)
        {
            showService.active = false;
            object o = c.EditService(showService);

            if (o == null)
            {
                MessageBox.Show("Service has not beed deleted!");

            }
            else
            {
                MessageBox.Show("Service has been deleted!");
                form.Close();

            }
        }

        internal void SearchServices(TextBox textBoxSearchService, ComboBox comboBoxCategory, DataGridView dataGridViewService)
        {
            List<Service> services = new List<Service>();
            if (textBoxSearchService.Text.Count() == 0 && comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Please enter a search value!");
                return;
            }

            if (textBoxSearchService.Text.Count() > 0 && textBoxSearchService.Text.Count() <= 3)
            {
                MessageBox.Show("You need to enter at least four characters for search!");
                return;
            }

            Service s = new Service();
            s.Name = textBoxSearchService.Text;
            s.category = comboBoxCategory.SelectedItem as Category;
            services = c.SearchServices(s);

            if (services == null || services.Count == 0)
            {
                MessageBox.Show("No service found!");
                dataGridViewService.DataSource = null;

                return;
            }
            else
            {
                MessageBox.Show("The search is complete!");
                dataGridViewService.DataSource = new BindingList<Service>(services);
            }

        }

        public void SaveNewService(TextBox textBoxName, TextBox textBoxDesc, TextBox textBoxPrice, ComboBox comboBoxCategory, NewServiceForm newServiceForm)
        {
            String mandatoryValues = "Please enter: ";
            bool thereIsEmptyValue = false;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "name";
                else mandatoryValues = mandatoryValues + ",name";
                textBoxName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxDesc.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "description";
                else mandatoryValues = mandatoryValues + ",description";
                textBoxDesc.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "price";
                else mandatoryValues = mandatoryValues + ",price";
                textBoxPrice.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "category";
                else mandatoryValues = mandatoryValues + ",category";
                thereIsEmptyValue = true;
            }

            if (thereIsEmptyValue)
            {
                MessageBox.Show(mandatoryValues + "!");
                return;
            }

            if (textBoxDesc.Text.Count() > 255) {
                MessageBox.Show("You have entered more than the allowed number of characters in the field Description! It is possible to enter a maximum of 255 characters.");
                return;
            }

            Service service = new Service();
            service.Name = textBoxName.Text;
            service.Description = textBoxDesc.Text;

            try
            {
                service.Price = Convert.ToDouble(textBoxPrice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the entered price. Enter the numerical value of the price!");
                return;
            }
            
            service.Category = (Category)comboBoxCategory.SelectedItem;
            service.Active = true;
            service.CreatedBy = e;

            object o = c.SaveNewService(service);

            if (o == null)
            {
                MessageBox.Show("Service has not been saved! Check the entered data!");
                return;
            }
            else
            {
                MessageBox.Show("Service has been saved!");
                newServiceForm.Close();
            }
        }

        internal void ReturnServices(ComboBox comboBoxService)
        {
            comboBoxService.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxService.DataSource = c.ReturnServices();
            comboBoxService.DisplayMember = "Name";

        }

        #endregion

        #region Client

        internal void ReturnAllClient(DataGridView dataGridViewClient)
        {
            List<Domain.Client> clients = new List<Domain.Client>();

            Domain.Client client = new Domain.Client();
            clients = c.SearchClients(client);

            if (clients == null || clients.Count == 0)
            {
                dataGridViewClient.DataSource = null;
            }
            else
            {
                dataGridViewClient.DataSource = new BindingList<Domain.Client>(clients);
            }
        }

        internal void ReturnSelectedClient(DataGridView dataGridViewClient)
        {
            if (dataGridViewClient.CurrentRow != null)
            {
                Domain.Client selectedClient = new Domain.Client();
                selectedClient = dataGridViewClient.CurrentRow.DataBoundItem as Domain.Client;
                List<Domain.Client> clients = c.SearchClients(selectedClient);
                if (clients != null && clients.Count > 0)
                {
                    ShowClientForm sc = new ShowClientForm(this, clients[0]);
                    sc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("System cannot load data about the selected client!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select client!");
                return;
            }
        }

        internal void ShowClientData(TextBox textBoxFirstName, TextBox textBoxLastName, TextBox textBoxEmail, ComboBox comboBoxLoyalty, ShowClientForm form)
        {
            try
            {
                textBoxFirstName.Text = showClient.FirstName;
                textBoxLastName.Text = showClient.LastName;
                textBoxEmail.Text = showClient.Email;
                ReturnLoyalties(comboBoxLoyalty);
                comboBoxLoyalty.Text = showClient.loyalty.Name;
            }
            catch (Exception)
            {

                MessageBox.Show("The system cannot load data for the selected client!");
                form.Close();
                return;
            }
        }

        internal void EditClient(TextBox textBoxFirstName, TextBox textBoxLastName, TextBox textBoxEmail, ComboBox comboBoxLoyalty, ShowClientForm form)
        {
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Invalid e-mail!");
                return;
            }
            showClient.FirstName = textBoxFirstName.Text;
            showClient.LastName = textBoxLastName.Text;
            showClient.Email = textBoxEmail.Text;
            showClient.Loyalty = comboBoxLoyalty.SelectedItem as Loyalty;

            object o = c.EditClient(showClient);

            if (o == null)
            {
                MessageBox.Show("Client has not been changed! Check the entered data!");

            }
            else
            {
                MessageBox.Show("Client has been changed!");
                form.Close();

            }
        }

        internal void DeactiveClient(ShowClientForm form)
        {
            showClient.active = false;
            object o = c.EditClient(showClient);

            if (o == null)
            {
                MessageBox.Show("Client has not been deleted!");

            }
            else
            {
                MessageBox.Show("Client has been deleted!");
                form.Close();

            }
        }

        internal void SearchClients(TextBox textBoxSearchClient, ComboBox comboBoxLoyalties, DataGridView dataGridViewClient)
        {
            List<Domain.Client> clients = new List<Domain.Client>();

            if (textBoxSearchClient.Text.Count() == 0  && comboBoxLoyalties.SelectedItem == null) {
                MessageBox.Show("Please enter a search value!");
                return;
            }
            if (textBoxSearchClient.Text.Count() > 0 && textBoxSearchClient.Text.Count() <= 3) {
                MessageBox.Show("You need to enter at least four characters for search!");
                return;
            }

            Domain.Client client = new Domain.Client();
            client.FirstName = textBoxSearchClient.Text;
            client.loyalty = comboBoxLoyalties.SelectedItem as Loyalty;
            clients = c.SearchClients(client);

            if (clients == null || clients.Count == 0)
            {
                MessageBox.Show("No client found!");
                dataGridViewClient.DataSource = null;

                return;
            }
            else
            {
                MessageBox.Show("Search is complete!");
                dataGridViewClient.DataSource = new BindingList<Domain.Client>(clients);
            }

        }

        public void SaveNewClient(TextBox textBoxFirstName, TextBox textBoxLastName, TextBox textBoxEmail, ComboBox comboBoxLoyalty, NewClientForm form)
        {
            String mandatoryValues = "Please enter: ";
            bool thereIsEmptyValue = false;

            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "first name";
                else mandatoryValues = mandatoryValues + ",first name";
                textBoxFirstName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "last name";
                else mandatoryValues = mandatoryValues + ",last name";
                textBoxLastName.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }
        

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "e-mail";
                else mandatoryValues = mandatoryValues + ",e-mail";
                textBoxEmail.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }       

            if (thereIsEmptyValue) {
                MessageBox.Show(mandatoryValues + "!");
                 return;
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Invalid e-mail!");
                return;
            }

            Domain.Client client = new Domain.Client();
            client.FirstName = textBoxFirstName.Text;
            client.LastName = textBoxLastName.Text;
            client.Email = textBoxEmail.Text;
            client.Loyalty = (Loyalty)comboBoxLoyalty.SelectedItem;
            client.Active = true;
            client.CreatedBy = e;

            object o = c.SaveNewClient(client);

            if (o == null)
            {
                MessageBox.Show("Client has not been saved! Check the entered data!");
                return;
            }
            else
            {
                MessageBox.Show("Client has been saved!");
                form.Close();
            }
        }

        public bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;

            }
            catch
            {

                return false;
            }
        }

        #endregion

        #region Receipt

        internal void SearchReceipt(TextBox textBoxSearchReceipt, DataGridView dataGridViewReceipt, ComboBox comboBoxStatuses)
        {
            List<ReceiptHeader> receiptHeaders = new List<ReceiptHeader>();

            if (textBoxSearchReceipt.Text.Count() == 0 && (Status)comboBoxStatuses.SelectedItem == Status.None)
            {
                MessageBox.Show("Please enter a search value!");
                return;
            }

            if (textBoxSearchReceipt.Text.Count() > 0 && textBoxSearchReceipt.Text.Count() <= 3)
            {
                MessageBox.Show("You need to enter at least four characters for search!");
                return;
            }
            ReceiptHeader rh = new ReceiptHeader();
            rh.receiptNumber = textBoxSearchReceipt.Text;
            if (comboBoxStatuses.SelectedItem!=null) rh.status = (Status)comboBoxStatuses.SelectedItem;
            receiptHeaders = c.SearchReceipt(rh);
            
            if (receiptHeaders == null || receiptHeaders.Count == 0)
            {
                MessageBox.Show("No receipt found!");
                textBoxSearchReceipt.Clear();
                dataGridViewReceipt.DataSource = null;

                return;
            }
            else
            {
                MessageBox.Show("Search is complete!");
                dataGridViewReceipt.DataSource = new BindingList<ReceiptHeader>(receiptHeaders);
            }
        }

        internal void CancelReceiptHeader(CancelReceiptForm form, DataGridView dataGridViewReceipt)
        {
            
            if (dataGridViewReceipt.CurrentRow.DataBoundItem!=null)
            {
                showReceiptHeader = dataGridViewReceipt.CurrentRow.DataBoundItem as ReceiptHeader;
                if (showReceiptHeader.status != Status.Storniran)
                {
                    showReceiptHeader.status = Status.Storniran;
                    object o = c.CancelReceiptHeader(showReceiptHeader);

                    if (o == null)
                    {
                        MessageBox.Show("Receipt has not been canceled!");
                    }
                    else
                    {
                        MessageBox.Show("Receipt has been canceled!");
                        form.Close();
                    }
                }
                else {
                    MessageBox.Show("Selected receipt has already been canceled!");
                    
                }
               
            }
            else {
                MessageBox.Show("Please select receipt!");
            }
            
        }

        internal void ShowReceiptLines(DataGridView dataGridViewReceiptLines, TextBox textBoxReceiptNumber)
        {
            textBoxReceiptNumber.Enabled = false;
            textBoxReceiptNumber.Text = showReceiptHeader.receiptNumber;
            ReceiptLine receiptLine = new ReceiptLine();
            receiptLine.ReceiptHeader = showReceiptHeader.ReceiptID;
            List<ReceiptLine> receiptLines = c.ReturnReceiptLines(receiptLine);

            if (receiptLines.Count == 0)
            {
                MessageBox.Show("There are no lines!");
                dataGridViewReceiptLines.DataSource = null;
                return;
            }
            else
            {
                MessageBox.Show("The system has found receipt lines!");
                dataGridViewReceiptLines.DataSource = new BindingList<ReceiptLine>(receiptLines);
            }
        }

        internal void CheckIfClientExist(TextBox textBoxClient, Label labelClient, Button buttonFindClient, TextBox textBoxAmount, TextBox textboxDiscountAmount)
        {
            if (receiptHeader.Client != null) {
                textBoxClient.Text = receiptHeader.Client.firstName + " " + receiptHeader.Client.lastName;
                labelClient.Visible = true;
                textBoxClient.Visible = true;
                buttonFindClient.Enabled = false;
                SetDiscountAndLineAmount();
                textBoxAmount.Text = receiptHeader.Amount.ToString();
                textboxDiscountAmount.Visible = true;
                textboxDiscountAmount.Text = receiptHeader.discount.ToString();
            }
        }

        internal void SetClientToReceipt(Domain.Client client, ClientForReceiptForm form)
        {
            try
            {
                if (client != null) {
                    receiptHeader.Client = client;
                    form.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void SaveReceipt(TextBox textBoxReceiptNumber, TextBox textBoxReceiptDate, ComboBox comboBoxPaymentMethods, TextBox textBoxClient, TextBox textBoxNote, TextBox textBoxAmount, DataGridView dataGridViewReceiptLines, TextBox textBoxDiscountAmount, Label labelClient, Button buttonFindClient, Form form)
        {
            if (string.IsNullOrWhiteSpace(textBoxReceiptNumber.Text))
            {
                MessageBox.Show("Receipt number has not been generated!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxReceiptDate.Text))
            {
                MessageBox.Show("Receipt date has not been generated!");
                return;
            }

            if (comboBoxPaymentMethods.SelectedItem ==null)
            {
                MessageBox.Show("Please select payment method!");
                return;
            }

            if (receiptHeader.ReceiptLines.Count() == 0) {
                MessageBox.Show("Please enter receipt line!");
                return;
            }

            if (textBoxNote.Text.Count() > 255)
            {
                MessageBox.Show("You have entered more than the allowed number of characters in the field Note! It is possible to enter a maximum of 255 characters.");
                return;
            }

            try
            {
                receiptHeader.ReceiptNumber = textBoxReceiptNumber.Text;
                receiptHeader.ReceiptDate = Convert.ToDateTime(textBoxReceiptDate.Text);
                receiptHeader.PaymentMethod = comboBoxPaymentMethods.SelectedItem as PaymentMethod;
                //receiptHeader.paymentMethod = checkBoxCashCard.Checked ? 
                PaymentMethod card = new PaymentMethod();
                receiptHeader.Note = textBoxNote.Text;
                //klijent je vec setovan ukoliko je izabran
                receiptHeader.Amount = Convert.ToDouble(textBoxAmount.Text);
                receiptHeader.Status = Status.Obradjen;
                receiptHeader.Active = true;
                receiptHeader.CreatedBy = e;

                object o = c.SaveReceipt(receiptHeader);

                if (o == null)
                {
                    MessageBox.Show("Receipt has not been saved! Check the entered data!");
                }
                else
                {
                    MessageBox.Show("Receipt has been saved!");
                    DialogResult dr = MessageBox.Show("Do you want to generate PDF for receipt?", "Generate PDF for receipt", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            ReceiptPDF pdf = new ReceiptPDF(receiptHeader);
                            pdf.CreatePDF();
                            break;
                        case DialogResult.No:
                            break;
                    }

                    if (form.Name == "NewReceiptForm") form.Close();
                    else
                    {
                        SetDateForNewReceipt(textBoxReceiptNumber, textBoxReceiptDate, comboBoxPaymentMethods, dataGridViewReceiptLines);
                        textBoxAmount.Text = 0.ToString();
                        textBoxDiscountAmount.Text = 0.ToString();
                        textBoxNote.Text = "";
                        if (textBoxClient.Visible == true)
                        {
                            buttonFindClient.Enabled = true;
                            textBoxClient.Visible = false;
                            labelClient.Visible = false;
                            textBoxClient.Text = "";

                        }
                    }



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Receipt has not been saved! Check the entered data!");
                throw;
            }
            
        }

        internal void AddReceiptLine(ComboBox comboBoxService, TextBox textBoxQuantity, NewReceiptLineForm newReceiptLineForm)
        {
            String mandatoryValues = "Please enter: ";
            bool thereIsEmptyValue = false;

            if (textBoxQuantity.Text == "") {
                if (mandatoryValues.Count() == 13) mandatoryValues = mandatoryValues + "quantity";
                else mandatoryValues = mandatoryValues + ",quantity";
                textBoxQuantity.BackColor = Color.MistyRose;
                thereIsEmptyValue = true;
            }

            if (thereIsEmptyValue)
            {
                MessageBox.Show(mandatoryValues + "!");
                return;
            }

            ReceiptLine receiptLine = new ReceiptLine();
            receiptLine.Service = comboBoxService.SelectedItem as Service;
            receiptLine.ServiceName = receiptLine.Service.name;

            try
            {
                receiptLine.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Check the entered quantity. Enter the numerical value of the quantity!");
                return;
            }
            
            receiptLine.Price = receiptLine.Service.price;
            if (receiptHeader.Client != null && receiptHeader.Client.Loyalty.Discount > 0) receiptLine.Discount = receiptHeader.Client.Loyalty.Discount;
            receiptLine.LineAmount = receiptLine.Discount > 0 ? receiptLine.Quantity * receiptLine.Price * (100 - receiptLine.Discount) / 100 : receiptLine.Quantity * receiptLine.Price;
            receiptLine.LineNumber = receiptHeader.ReceiptLines.Count() + 1;
            receiptLine.Active = true;
            receiptLine.CreatedBy = e;
            receiptHeader.ReceiptLines.Add(receiptLine);
            //receiptHeader.Amount = sumReceiptLines();
            receiptHeader.amount += receiptLine.LineAmount;
            receiptHeader.discount += (receiptLine.Price * receiptLine.Quantity) - receiptLine.LineAmount;
            newReceiptLineForm.Close();
        }

        internal void SetDiscountAndLineAmount() {
            receiptHeader.Amount = 0;
            receiptHeader.discount = 0;
            foreach (ReceiptLine rl in receiptHeader.ReceiptLines)
            {
                if (receiptHeader.Client != null && receiptHeader.Client.Loyalty.LoyaltyID > 0) rl.Discount = receiptHeader.Client.Loyalty.Discount;
                rl.LineAmount = rl.Discount > 0 ? rl.Quantity * rl.Price * (100 - rl.Discount) / 100 : rl.Quantity * rl.Price;
                receiptHeader.Amount += rl.LineAmount;
                receiptHeader.discount += (rl.Price * rl.Quantity) - rl.LineAmount;
            }
        }

        internal void RemoveReceiptLine(DataGridView receiptLine)
        {
            if (receiptLine.CurrentRow != null)
            {
                ReceiptLine rl = receiptLine.CurrentRow.DataBoundItem as ReceiptLine;
                receiptHeader.ReceiptLines.Remove(rl);
                receiptHeader.Amount -= rl.LineAmount;
                if (receiptHeader.discount> 0) receiptHeader.discount -= (rl.Price * rl.Quantity) - rl.LineAmount;

                int i = 1;
                foreach (ReceiptLine rline in receiptHeader.ReceiptLines)
                {
                    rline.LineNumber = i;
                    i++;
                }
            }
            else {
                MessageBox.Show("There are no lines!");
            }
            
        }

        private double SumReceiptLines()
        {
            double sum = 0;
            receiptHeader.discount = 0;
            foreach (ReceiptLine rl in receiptHeader.ReceiptLines)
            {
                sum += rl.LineAmount;
                receiptHeader.discount += (rl.Price * rl.Quantity) - rl.LineAmount;
            }
            return sum;
        }

        internal void SetDateForNewReceipt(TextBox textBoxReceiptNumber, TextBox textBoxReceiptDate, ComboBox comboBoxPaymentMethods, DataGridView dataGridViewReceiptLines)
        {
            receiptHeader = new ReceiptHeader();//setujem podatke na receiptHeader pre save metode i kada izadjem sa forma a ne sacuvam ostanu mi stari podaci
            //setovani i kada sledeci put otvorim formu
            receiptHeader.ReceiptLines = new BindingList<ReceiptLine>();
            
            dataGridViewReceiptLines.DataSource = receiptHeader.ReceiptLines;

            textBoxReceiptDate.Text = DateTime.Now.ToShortDateString();

            comboBoxPaymentMethods.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentMethods.DataSource = c.ReturnPaymentMethods();
            comboBoxPaymentMethods.DisplayMember = "Name";
            comboBoxPaymentMethods.SelectedItem = null;

            textBoxReceiptNumber.Text = GenerateReceiptNumber();
        }

        private string GenerateReceiptNumber()
        {
            string receiptNumber = "";
            Random r = new Random();
            receiptNumber = "REC" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +  "-" + r.Next(1000, 9999).ToString() +"";

            return receiptNumber;
        }

        #endregion




        

        





    }
}
