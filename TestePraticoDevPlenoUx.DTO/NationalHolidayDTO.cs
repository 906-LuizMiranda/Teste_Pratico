using TestePraticoDevPlenoUx.CrossCutting.Enum;

namespace TestePraticoDevPlenoUx.DTO
{
    public class NationalHolidayDTO
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Legislation { get; set; }
        public HolidayType Type { get; set; }
        public object StartTime { get; set; }
        public object EndTime { get; set; }
        public dynamic VariableDates { get; set; }
    }
}
