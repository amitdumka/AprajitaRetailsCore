namespace AprajitaRetails.Models
{
    public class BaseT : BaseGT
    {
        public int StoreId { get; set; }
    }

    public class BaseGT
    {
        public string UserId { get; set; }
        public Status Status { get; set; }
        public bool IsReadOnly { get; set; }
    }
}