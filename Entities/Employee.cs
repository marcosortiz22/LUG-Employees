namespace Entities;

public class Employee
{
    public string LastNameFirstName { get; set; }
    public string PersonalId { get; set; }
    public decimal GrossSalary { get; set; }

    public decimal CalculateNetSalary()
    {
        return GrossSalary * 0.83M; // Aplicando un 17% de impuestos
    }

    public bool IsValid(out string validationMessage)
    {
        validationMessage = string.Empty;

        if (LastNameFirstName.Length <= 5)
        {
            validationMessage = "El nombre y apellido deben tener más de 5 caracteres.";
            return false;
        }
        if (PersonalId.Length != 11)
        {
            validationMessage = "El DNI debe tener 11 caracteres.";
            return false;
        }
        if (GrossSalary < 100000)
        {
            validationMessage = "El sueldo bruto no puede ser menor al salario mínimo vital y móvil ($100.000).";
            return false;
        }
        return true;
    }
}
