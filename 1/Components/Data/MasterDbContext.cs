using Microsoft.EntityFrameworkCore;

//
public class MasterDbContext : DbContext
{

    public DbSet <MasterInventory> MasterInventory {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace with your actual SQL Server connection string
        optionsBuilder.UseSqlServer(@"Server=mypenm0iesvr01;Database=Testing;Trusted_Connection=True;TrustServerCertificate=True;");

    }
}

public class MasterInventory
{
    public int Id { get; set; }
    public string? Asset { get; set; }
    public string Description { get; set; } = string.Empty;
    public string? TorqueSerialNumber { get; set; }
    public string? TorqueModel { get; set; }
    public string? TorqueRange { get; set; }
    public string? ControllerSerialNumber { get; set; }
    public string? Brand { get; set; }
    public string? Manufacturer { get; set; }
    public string? Supplier { get; set; }
    public string? EquipmentID { get; set; }
    public string? RegisterSAPEAM { get; set; }
    public string? FunctionalGroup { get; set; }
    public string? AssemblyGroup { get; set; }
    public string? Sector { get; set; }
    public string? Plant { get; set; }
    public string? Workcell { get; set; }
    public string? CostCenter { get; set; }
    public string? NetBookValue { get; set; }
    public string? UserStatus { get; set; }
    public DateTime? KeyInDate { get; set; }
    public string? Owner { get; set; }
    public string? Comment { get; set; }
    public string RegistrationStatus => string.IsNullOrWhiteSpace(RegisterSAPEAM) ? "Not Registered" : "Registered";

}


public class LogData
{
    public string Model { get; set; }
    public string SerialNo { get; set; }
    public string Process { get; set; }
    public DateTime Timestamp { get; set; }
    public string SoftwareVersion { get; set; }
    public string Status { get; set; }
    public string PCName { get; set; }
    public string IPAddress { get; set; }
    public string WorkcellName { get; set; }
    public string TorqueModel1 { get; set; }
    public string TorqueSerialNumber1 { get; set; }
    public string TorqueRange1 { get; set; }
    public string TorqueModel2 { get; set; }
    public string TorqueSerialNumber2 { get; set; }
    public string TorqueRange2 { get; set; }
}
