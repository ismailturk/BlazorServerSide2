namespace DataAccessLibrary.Models
{
    public class ClubModelSignalR
    {
        public List<ClubModel>? Clubs { get; set; }
    }
    public class ClubModel
    {
        public string? ClubName { get; set; }
        public int FoundationDate { get; set; }
       
    }
}
