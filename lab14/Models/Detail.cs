namespace lab14.Models
{
    public class Detail
    {
        //Parametros de la tabla
        public int DetailID { get; set; }
        public int Amount { get; set; } 
        public float Price { get; set; }
        public float SubTotal { get; set; }

        //LLave foranea
        public Product Product { get; set; }
        public int ProductID { get; set; }    

    }
}
