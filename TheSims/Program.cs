using System;

namespace TheSims
{   /*The Sims

            Du har 3 modus i spillet: FamilieModus, ByggModus, SpillModus
            Brukeren skal kunne opprette et eller flere familiemedlemmer i spillet.
            Familiemedlemmer kan være voksne eller barn. 
           

            Disse gjenstandene har tilknyttede handlinger ex:
            Kjøleskap - Hent mat
            Seng - Wohoo, Sov

            Når du er ferdig å bygge huset og familien, kan du gå over i spillmodus.
            Da skal du kunne gå inn i de forskjellige rommene i huset, 
            der det listes opp hva som er innholdet til de forskjellige rommene - feks:

            You are on the first floor - in the livingroom. Cindy is also in the room. 
            Available furniture is:
            A couch
            A lamp
            A table
            A tv

            What do you want to do?
            Enter another room
            Interact with item
            Interact with Cindy
            Exit play mode

            Dersom et av de andre familiemedlemmene befinner seg i samme rom kan du interacte med dem 
            - da øker tilknytningen dersom man gjør hyggelige ting, mens man blir uvenner dersom man gjør slemme ting.
*/
    class Program
    {
        static void Main(string[] args)
        {
            var gameHandler = new Gamehandler();
        }
    }
}
