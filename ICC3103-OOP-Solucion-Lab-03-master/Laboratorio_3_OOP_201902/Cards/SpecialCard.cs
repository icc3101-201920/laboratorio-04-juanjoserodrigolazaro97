﻿using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_3_OOP_201902.Enums;

namespace Laboratorio_3_OOP_201902.Cards
{
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;

        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
        //Constructor
        public SpecialCard(string name, EnumType type, string effect)
        {
            Name = name;
            Type = type;
            Effect = effect;
            BuffType = null;
        }


    }
}
