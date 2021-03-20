namespace ContosoMovies.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Status { get; set; }

        //Request | Responce
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
