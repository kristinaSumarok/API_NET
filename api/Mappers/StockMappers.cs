using api.Dtos.Stock;
using api.Models;
namespace api.Mappers;
public static class StockMappers{
    public static StockDto ToStockDto(this Stock stockModel){
        return new StockDto{
            Id = stockModel.Id,
            Symbol = stockModel.Symbol,
            CompanyName = stockModel.CompanyName,
            Industry = stockModel.Industry,
            MarcetCap = stockModel.MarcetCap
        };
    }
    public static Stock ToStockFromCreateDto(this CreateStockRequestDto stockDto){
        return new Stock{
            Symbol = stockDto.Symbol,
            CompanyName = stockDto.CompanyName,
            Purchase = stockDto.Purchase,
            LastDiv = stockDto.LastDiv,
            Industry = stockDto.Industry,
            MarcetCap = stockDto.MarcetCap
        };
    }
}
