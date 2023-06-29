using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoadQuotesSO", menuName = "QuotesSO")]
public class QuotesDataSO : ScriptableObject
{
    public bool win;
    public List<Quote> Quotes;
    
    public List<Quote> UsarQuotes()
    {
        if (win)
        {
            Quotes.Clear();
            Quote Quote1 = new Quote();
            Quote1.sentence = "Tus esfuerzos salvaron han saldavo miles de arboles hogar de multiples especies de animales.";
            Quotes.Add(Quote1);
            Quote Quote2 = new Quote();
            Quote2.sentence = "Has evitado que miles de toneladas de dioxido de carbono sean liberados al medio ambiente.";
            Quotes.Add(Quote2);
            Quote Quote3 = new Quote();
            Quote3.sentence = "Salvaste un bosque de eucalipto, alimento de miles de Koalas en peligro de extincion.";
            Quotes.Add(Quote3);
            Quote Quote4 = new Quote();
            Quote4.sentence = "Miles de Kanguros salvados al evitar la propagancion de los incendios.";
            Quotes.Add(Quote4);
            Quote Quote5 = new Quote();
            Quote5.sentence = "Apagaste un incendio que se aproximaba a una reserva de animales, salvando sus vidas.";
            Quotes.Add(Quote5);
            Quote Quote6 = new Quote();
            Quote6.sentence = "Evistaste que el fuego llegara a un acentamiento humano cercano.";
            Quotes.Add(Quote6);
            Quote Quote7 = new Quote();
            Quote7.sentence = "Evistaste que el fuego llegase a un deposito de petroleo, evitando la quema de este y la contaminacion del aire.";
            Quotes.Add(Quote7);
            Quote Quote8 = new Quote();
            Quote8.sentence = "Al apagar el incendio a tiempo evitaste que se quemasen importantes fuentes de alimentos para los residentes locales.";
            Quotes.Add(Quote8);
            return Quotes;
        }
        else
        {
            Quotes.Clear();
            Quote Quote1 = new Quote();
            Quote1.sentence = "Tus esfuerzos no fueron suficientes, con ese incendio murio el 15% de la poblacion de Koalas.";
            Quotes.Add(Quote1);
            Quote Quote2 = new Quote();
            Quote2.sentence = "Al no prevenir la quema de los bosques, miles de animales perdieron su hogar y fuente de alimento.";
            Quotes.Add(Quote2);
            Quote Quote3 = new Quote();
            Quote3.sentence = "Los Quoll del norte entran en peligro de extincion debido a las muertes por los incendios no resueltos.";
            Quotes.Add(Quote3);
            Quote Quote4 = new Quote();
            Quote4.sentence = "La cantidad de dioxido de carbono liberada es tres veces mayor a la del año pasado.";
            Quotes.Add(Quote4);
            Quote Quote5 = new Quote();
            Quote5.sentence = "Miles de arboles de Acacia perdidos en los incendios forestales, dificultando la producción de sus productos medicos.";
            Quotes.Add(Quote5);
            Quote Quote6 = new Quote();
            Quote6.sentence = "El fuego arrazo con los cultivos locales, dejando sin alimento a miles de animales y residentes.";
            Quotes.Add(Quote6);
            Quote Quote7 = new Quote();
            Quote7.sentence = "El dioxido de carbono producido por los incendios inducidos por el calentamiento global ayudan a empeorar esta misma causa.";
            Quotes.Add(Quote7);
            Quote Quote8 = new Quote();
            Quote8.sentence = "Miles de animales mueren sofocados por los gases toxicos, nada de esto hubiese pasado si el calentamiento globar producido por los humanos causara los incendios.";
            Quotes.Add(Quote8);
            return Quotes;
        }
    }
}
