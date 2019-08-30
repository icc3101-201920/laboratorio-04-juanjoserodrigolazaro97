using Laboratorio_3_OOP_201902.Cards;
using Laboratorio_3_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laboratorio_3_OOP_201902
{
    public class Game
    {

        
        public void leer() {

            StreamReader reader = new StreamReader("Decks.txt");
            StreamReader reader2 = new StreamReader("Captains.txt");
            int i = 0;
            while (!reader.EndOfStream) {
                
                string line = reader.ReadLine();

                if (line == "START" || line == "END") {
                    if (line == "START") {
                        i++;
                    }
                } else {
                    if (line.Contains("Combat"))
                    {
                        var a = line.Split(',');


                        EnumType enumTipo = (EnumType)Enum.Parse(typeof(EnumType), a[2]);

                        CombatCard carta = new CombatCard(a[1], enumTipo, a[3], int.Parse(a[4]), bool.Parse(a[5]));
                        if (i == 1)
                        {
                            mazo1.Add(carta);
                        }
                        else
                        {
                            mazo2.Add(carta);
                        }
                    }
                    else if (line.Contains("Special")) {
                        var a = line.Split(',');
                        EnumType enumTipo = (EnumType)Enum.Parse(typeof(EnumType), a[2]);
                        SpecialCard carta = new SpecialCard(a[1], enumTipo, a[3]);
                        if (i == 1) {
                            mazo1.Add(carta);
                        } else
                        {
                            mazo2.Add(carta);
                        }
                    }
                  

                }
            }

            decks[0].Cards = mazo1;
            decks[1].Cards = mazo2;



            while (!reader2.EndOfStream) {

                string line = reader2.ReadLine();
                var a = line.Split(',');
                if (line.Contains("Special"))
                {
                    EnumType enumTipo = (EnumType)Enum.Parse(typeof(EnumType), a[2]);
                    SpecialCard carta = new SpecialCard(a[1], enumTipo, a[3]);
                    capitanes.Add(carta);

                }
            }


            //agregar los mazos al deck

           


            reader.Close();

        }


        //Atributos
        private Player[] players;
        private Player activePlayer;
        private List<Deck> decks;
        private Board boardGame;
        private bool endGame;

        public List<Card> mazo1;
        public List<Card> mazo2;
        public List<Card> capitanes;
        //Constructor
        public Game()
        {
            decks = new List<Deck>();
            mazo1 = new List<Card>();
            mazo2 = new List<Card>();
            capitanes = new List<Card>();
        }

        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public List<Deck> Decks
        {
            get
            {
                return this.decks;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetWinner()
        {
            if (players[0].LifePoints == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
