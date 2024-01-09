﻿namespace ICTreatsSystem
{
    class PointCard
    {
        public int Points { get; set; } = 0;
        public int PunchCard { get; set; } = 0;
        public string Tier { get; set; } = "Ordinary";

        public PointCard() { }

        public PointCard(int input_points, int input_punchCard)
        {
            Points = input_points;
            PunchCard = input_punchCard;
        }

        void AddPoints(int add_points)
        {
            Points += add_points;
            if (Tier == "Ordinary")
            {
                if (Points >= 150) Tier = "Gold";
                else if (Points >= 50) Tier = "Silver";
            }
            else if (Tier == "Silver")
            {
                if (Points >= 100) Tier = "Gold";
            }
        }

        void RedeemPoints(int use_points)//Not Done
        {
            if (Points - use_points >= 0 && (Tier == "Silver" || Tier == "Gold"))
            {
                double cost_offset = use_points * 0.02;
                if (Tier == "Gold")
                {

                }
            }
        }

        void punch()//Not Done
        {
            PunchCard++;
            if (PunchCard == 10)
            {
                PunchCard = 0;
            }
        }

        public override string ToString()
        {
            return $"Points: {Points} PunchCard: {PunchCard} Tier: {Tier}";
        }
    }
}
