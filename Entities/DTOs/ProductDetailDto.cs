using Core.Entities;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        //IEntity'den inheritance edilmiyor cunku burasi bir db tablosu degil
        //Birden fazla tablonun join'i olabilir

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
