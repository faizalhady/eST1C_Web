using Microsoft.EntityFrameworkCore;

//
public class MasterDbContext : DbContext
{

    public DbSet <MasterData> MasterData {get; set;}
    public DbSet <LogData> LogData {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace with your actual SQL Server connection string
        optionsBuilder.UseSqlServer(@"Server=mypenm0iesvr01;Database=Testing;Trusted_Connection=True;TrustServerCertificate=True;");

    }
}

public class MasterData
{

    public int? Id { get; set; }
    public DateTime? Date { get; set; }
    public int? Quantity { get; set; }
    public string? Brand { get; set; }
    public string? ItemDescription { get; set; }
    public string? Model { get; set; }
    public string? DriverSerialNo { get; set; }
    public string? Specification { get; set; }
    public string? ControllerSerialNo { get; set; }
    public string? Supplier { get; set; }
    public string? JabilIDNo { get; set; }
    public string? NREorJabilOwn { get; set; }
    public string? Plant { get; set; }
    public string? IEME { get; set; }
    public string? Workcell { get; set; }
    public string? PIC { get; set; }
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
