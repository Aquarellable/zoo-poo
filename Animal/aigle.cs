public class Aigle : Animal
{
    public Aigle(string nom, Sexe sexe, int age) : base(nom, sexe, age)
    {
        if (age <= 6)
        {
            PrixAchat = prixAigle["6_months"].Buy;
            PrixVente = prixAigle["6_months"].Sell;
        }
        else if (age <= 48)
        {
            PrixAchat = prixAigle["48_months"].Buy;
            PrixVente = prixAigle["48_months"].Sell;
        }
        else
        {
            PrixAchat = prixAigle["168_months"].Buy;
            PrixVente = prixAigle["168_months"].Sell;
        }
        
        TypeNourriture = Nourriture.Viande;
        NourritureParJour = 0.5;
        JoursAvantFaim = 3;
    }
}