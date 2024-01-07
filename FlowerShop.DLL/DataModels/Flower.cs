namespace FlowerShop.DLL.DataModels
{
    public partial class Flower
    {
        public int Id { get; set; }
        public string FlowerName { get; set; } = null!;
        public int? Price { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
