using System;

namespace API.Entities
{
    public class MyNote
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string NoteDetail {get; set;}
        public DateTime CreatedOn {get; set;}
        public DateTime EditedOn {get; set;}
        public bool isAchieved {get; set;}
    }
}