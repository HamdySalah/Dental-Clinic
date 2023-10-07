namespace dental_clinic.Models
{
    public class payment
    {
        public int ID { get; set; }
        public string cardNumber  { get; set; }
        public string card_Ownername { get; set; }
        public string  type{ get; set; }
        public string cvv { get; set; }
        public string validation_data { get; set; }
        public string county { get; set; }
    }
}
