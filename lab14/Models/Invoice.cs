namespace lab14.Models
{
    public class Invoice
    {
        //Parametros de la tabla
        public int InvoiceID { get; set; }
        public DateTime Date { get; set; }
        public String? InvoiceNumber { get; set; }
        public float Total { get; set; }

        //LLave foranea
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
