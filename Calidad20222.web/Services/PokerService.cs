using Calidad20222.web.Models;

namespace Calidad20222.web.Services;

public class PokerService
{   
    public const String ESCALERA_REAL = "ESCALERA REAL";
    public const String ESCALERA_DE_COLOR = "ESCALERA DE COLOR";
    public const String POKER = "POKER";
    public const String FULL = "FULL";
    public const String COLOR = "COLOR";
    public const String ESCALERA = "ESCALERA";
    public const String TRIO = "TRIO";
    public const String DOBLE_PAREJA = "DOBLE PAREJA";
    public const String PAREJA = "PAREJA";
    public const String CARTA_ALTA = "CARTA ALTA";
    public const String SIN_DEFINIR = "SIN DEFINIR";
    
    public String GetJugada(List<Carta> cartas)
    {
        if (EsEscaleraReal(cartas))
            return ESCALERA_REAL;
        if (EsEscaleraDeColor(cartas))
            return ESCALERA_DE_COLOR;
        if (EsPoker(cartas))
            return POKER;
        if (EsFull(cartas))
            return FULL;
        if (EsColor(cartas))
            return COLOR;
        if (EsEscalera(cartas))
            return ESCALERA;
        if (EsTrio(cartas))
            return TRIO;
        if (EsDoblePareja(cartas))
            return DOBLE_PAREJA;
        if (EsPareja(cartas))
            return PAREJA;
        if (EsCartaAlta(cartas))
            return CARTA_ALTA;
        
        return SIN_DEFINIR;
    }
    
    //1. OK -> 1 grupo de 4 cartas
    private bool EsEscaleraReal(List<Carta> cartas)
    {
        if (cartas[0].Numero == 1 && cartas[1].Numero == 13 && cartas[2].Numero == 12 && cartas[3].Numero == 11 && cartas[4].Numero == 10) return true;

        return false;
    }
    
    //2. OK -> Se considera el palo como color
    private bool EsEscaleraDeColor(List<Carta> cartas)
    {
        if(EsEscalera(cartas) && EsColor(cartas)) return true;
        return false;
    }
    
    //3. OK -> 1 grupo de 4 cartas
    private bool EsPoker(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        // Corección de > 3 a == 4
        return grouping.Any(g => g.Count() == 4);
    }
    
    //4. OK -> 1 grupo de 3 cartas y 1 grupo de 2 cartas
    private bool EsFull(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 2;
    }
    
    //5. OK -> Se considera el palo como color
    private bool EsColor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        return grouping.Count() == 1;
    }
    
    //6. OK -> 5 cartas consecutivas
    private bool EsEscalera(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        // Corección a i < 5
        for (var i = 0; i < 5; i++)
        {
            if(i + 1 == 5)
            {
                continue;
            }
            
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                return false;
        } 

        return true;
    }
    
    //7. OK -> 1 grupo de 3 cartas
    private bool EsTrio(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        // Corección de > 2 a == 3
        return grouping.Any(g => g.Count() == 3);
    }
    
    //8. OK -> 1 grupo de 2 cartas , 1 grupo de 2 cartas y 1 grupo de 1 carta
    private bool EsDoblePareja(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 3;
    }
    
    //9. OK -> 1 grupo de 2 cartas
    private bool EsPareja(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        // Corección de > 1 a == 2
        return grouping.Any(g => g.Count() == 2);
    }
    
    //10. OK -> Carta A = 13
    private bool EsCartaAlta(List<Carta> cartas)
    {
        var carta = cartas.Find(o => o.Numero == 13);
        return carta != null;
    }
    
    
}