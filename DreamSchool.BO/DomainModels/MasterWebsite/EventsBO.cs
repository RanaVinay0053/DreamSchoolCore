namespace DreamSchool.BO.DomainModels.MasterWebsite
{
    public class EventsBO
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventDate { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string EventImage { get; set; }
        public string EventVenue { get; set; }
    }
}
