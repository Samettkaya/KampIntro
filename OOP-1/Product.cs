namespace OOP_1
{
    internal class Product // ürün 
    {
        public int Id { get; internal set; }  // kategori id
        public int CategoryId { get; internal set; } // ürünün kategorisi
        public string ProductName { get; internal set; } // ürün ismi 
        public int UnitPrice { get; internal set; } // ürün fiyatı
        public int UnitInStock { get; internal set; } // stok adedi
    }
}