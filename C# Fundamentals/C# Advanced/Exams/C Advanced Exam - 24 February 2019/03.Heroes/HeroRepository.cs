﻿namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            this.heroes = new List<Hero>();
        }

        public int Count
        {
            get => this.heroes.Count;
        }

        public void Add(Hero hero)
        {
            this.heroes.Add(hero);
        }

        public void Remove(string name)
        {
            var targetHero = this.heroes.FirstOrDefault(x => x.Name == name);
            this.heroes.Remove(targetHero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var heroWithHighestStrenght = this.heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return heroWithHighestStrenght;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var heroWithHighesAbility = this.heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return heroWithHighesAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var heroWithHighesIntelligence = this.heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return heroWithHighesIntelligence;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var hero in this.heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}