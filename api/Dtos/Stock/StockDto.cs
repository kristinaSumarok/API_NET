namespace api.Dtos.Stock;

public class StockDto{
public int Id { get; set; }
public string Symbol { get; set; } = string.Empty;
public string CompanyName { get; set; } = string.Empty;
public string Industry { get; set; } = string.Empty;
public long MarcetCap { get; set; }
}

