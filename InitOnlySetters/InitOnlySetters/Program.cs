using System;

    var instance = new Program()
    {
        MyProp="primo"
    };
    //instance.MyProp="secondo";
    instance.Show();
    partial class Program
    {
        /*--SE VOGLIAMO CHE MYPROP SIA IN SOLA LETTURA POSSIAMO ELIMINARE IL SET
        DALLA PROPRIETA'. TUTTAVIA A VOLTE C'E' L'ESIGENZA DI RENDERE UNA PROPRIETA'
        IN SOLA LETTURA MA INIZIALIZZATA AD UN VALORE. PER FARE CIO' BASTA AGGIUNGERE
        LA PAROLA CHIAVE INIT NEL SETTER. LA PROPRIETA' E' CHIAMATA IMMUTABILE IN QUANTO
        PUO' ESSERE INIZIALIZZATA SOLO UNA VOLTA.*/
        public string MyProp {get;init;}

    public void Show()
    {
        Console.WriteLine($"MyProp = {MyProp}");
    }

}