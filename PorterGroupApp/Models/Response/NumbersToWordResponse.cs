namespace PorterGroupApp.Models.Response
{
    public class NumbersToWordResponse
    {
        public NumbersToWordResponse() { }
        public string WordNumber { get; set; }

        public NumbersToWordResponse(string wordNumber) { WordNumber = wordNumber; }
    }
}
