
public class Api {

        public int id {get; set;}
        public string title {get ; set;} =string.Empty;
        public string descrption {get ; set;} =string.Empty;
        public bool   AsComplete {get ; set;}
        public DateTime CreateDat {get ; set;} = DateTime.UtcNow;
}
