namespace lab14.Models
{
    public class Customer
    {
        //Parametros de la tabla
        public int CustomerID { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? DocumentNumber { get; set; }
        public bool Active { get; set; }
    }
}
