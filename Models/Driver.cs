namespace HELMo_bilite.Models
{
    public class Driver : User
    {
        /// <summary>
        /// TODO peut être une enum, ou une classe a part entière
        /// </summary>
        public List<string> Licenses { get; set; }
    }
}
