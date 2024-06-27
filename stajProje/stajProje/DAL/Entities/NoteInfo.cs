
namespace stajProje.DAL.Entities
{
    public class NoteInfo
    {
        public int NoteID { get; set; }
        public string NoteName { get; set; }
        public string NoteType { get; set; } // günlük-haftalık-aylık
        public string NoteImgUrl { get; set; }
        public string Note { get; set; }
    }
}
