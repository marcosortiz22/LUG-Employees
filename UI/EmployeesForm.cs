using BLL;
using Entities;

namespace UI
{
    public partial class EmployeesForm : Form
    {
        private IEmployeeBusiness _employeeBusiness;
        private readonly List<Employee> _employeeList = new();

        public EmployeesForm(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
            InitializeComponent();
        }      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validación de entrada
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || txtFullName.Text.Length <= 5)
            {
                MessageBox.Show("El Apellido y Nombre debe tener más de 5 caracteres.");
                return;
            }

            if (txtPersonalId.Text.Length != 11)
            {
                MessageBox.Show("El DNI debe ser un número de 11 dígitos.");
                return;
            }

            if (!decimal.TryParse(txtGrossSalary.Text, out var grossSalary) || grossSalary < 100000)
            {
                MessageBox.Show("El Sueldo Bruto debe ser mayor o igual a $100.000.");
                return;
            }

            // Crear y agregar el empleado a la lista en memoria
            var employee = new Employee
            {
                LastNameFirstName = txtFullName.Text,
                PersonalId = txtPersonalId.Text,
                GrossSalary = grossSalary
            };

            _employeeList.Add(employee);
            MessageBox.Show("Empleado agregado a la lista en memoria.");
            ClearInputFields();
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            if (_employeeList.Count == 0)
            {
                MessageBox.Show("No hay empleados para confirmar.");
                return;
            }

            try
            {
                _employeeBusiness.SaveEmployees(_employeeList);
                MessageBox.Show("Empleados confirmados y guardados en la base de datos.");
                _employeeList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los empleados: {ex.Message}");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var employees = _employeeBusiness.GetAllEmployees();
            dgvEmployees.DataSource = employees;
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtPersonalId.Clear();
            txtGrossSalary.Clear();
        }
    }
}
