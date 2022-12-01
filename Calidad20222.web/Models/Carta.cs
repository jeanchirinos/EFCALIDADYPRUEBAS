namespace Calidad20222.web.Models;

public class Carta
{
    public int Numero { get; set;  }
    public String Palo { get; set;  }
    
    public static List<Carta> Todas()
    {
        return new List<Carta>
        {
            new Carta { Numero = 1, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 2, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 3, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 4, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 5, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 6, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 7, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 8, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 9, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 10, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 11, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 12, Palo = Models.Palo.CORAZON },
            new Carta { Numero = 13, Palo = Models.Palo.CORAZON },
            
            new Carta { Numero = 1, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 2, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 3, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 4, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 5, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 6, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 7, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 8, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 9, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 10, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 11, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 12, Palo = Models.Palo.TREBOL },
            new Carta { Numero = 13, Palo = Models.Palo.TREBOL },
            
            new Carta { Numero = 1, Palo = Models.Palo.COCO },
            new Carta { Numero = 2, Palo = Models.Palo.COCO },
            new Carta { Numero = 3, Palo = Models.Palo.COCO },
            new Carta { Numero = 4, Palo = Models.Palo.COCO },
            new Carta { Numero = 5, Palo = Models.Palo.COCO },
            new Carta { Numero = 6, Palo = Models.Palo.COCO },
            new Carta { Numero = 7, Palo = Models.Palo.COCO },
            new Carta { Numero = 8, Palo = Models.Palo.COCO },
            new Carta { Numero = 9, Palo = Models.Palo.COCO },
            new Carta { Numero = 10, Palo = Models.Palo.COCO },
            new Carta { Numero = 11, Palo = Models.Palo.COCO },
            new Carta { Numero = 12, Palo = Models.Palo.COCO },
            new Carta { Numero = 13, Palo = Models.Palo.COCO },
            
            new Carta { Numero = 1, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 2, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 3, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 4, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 5, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 6, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 7, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 8, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 9, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 10, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 11, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 12, Palo = Models.Palo.ESPADA },
            new Carta { Numero = 13, Palo = Models.Palo.ESPADA },
        };
    }
}