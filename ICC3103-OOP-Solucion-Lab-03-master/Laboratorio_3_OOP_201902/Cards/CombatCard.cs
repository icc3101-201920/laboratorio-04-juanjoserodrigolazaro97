﻿using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_3_OOP_201902.Enums;

namespace Laboratorio_3_OOP_201902.Cards
{
    public class CombatCard : Card
    {
        //Atributos
        private int attackPoints;
        private bool hero;

        //Constructor
        public CombatCard(string name, EnumType type, string effect, int attackPoints, bool hero)
        {
            Name = name;
            Type = type;
            Effect = effect;
            AttackPoints = attackPoints;
            Hero = hero;
        }

        //Propiedades
        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }
        public bool Hero
        { get
            {
                return this.hero;
            }
            set
            {
                this.hero = value;
            }
        }


    }
}
