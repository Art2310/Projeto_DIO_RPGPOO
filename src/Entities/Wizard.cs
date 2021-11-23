namespace DotnetPOORPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        
        }

        public string Attack(string TipoMagia, int Bonus){
            return this.Name + " Lançou uma magia de " + TipoMagia + 
        " efetiva, causando um dano adicional de " + Bonus;
        }
    }
}


