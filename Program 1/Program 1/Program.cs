//ID: R9223
//Due: 02/16/2021
//CIS 199-01
//Program 1
//This program is for estimating material and labor cost for a landscaping company

using System;
using static System.Console;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome the EZ Garden Calculator, \r\n" +
                "Where All Your Calculation Needs Will Be Met! \r\n");

            // These strings are inputs from the user answering width, length,
            //pric, and whether fertilizer is needed and is it first garden?
            string maxWidth, maxLength, pricePSY, fertGrPrep, firstGarden;
            
            //these constants desc
            const double SQYARDCONVERT = 9, //divides maxfeet * maxwidth to get square footage
                SOILWASTE = 1.1, // 10% extra included in soil calculation for waste
                SOILLABORPERYARD = 3.25, //soil labor is $3.25 per yard
                FERTPERSQUAREYARD = 4.25, // fertilizer per square yard is $4.25
                FIRSTGARDEN = 50,// extra $50 fee for first time garden
                NOFERT = 0;// if no fertilizer is being used, then time fertilizer cost by 0

            double maxW, maxL, priceP; //max width, max legth, price per square yard of soil
            int fertG, firstG;// yes no integers for 1 and 0

            Write(" Enter Maximum Width of The Garden:  "); //input widh
            maxWidth = ReadLine();
            maxW = Double.Parse(maxWidth);

            Write(" Enter Maximum Length of The Gardem:  "); //input length
            maxLength = ReadLine();
            maxL = Double.Parse(maxLength);

            Write("Enter Price Per Square Yard of Soil:  "); //input price per sq yard of soil
            pricePSY = ReadLine();
            priceP = double.Parse(pricePSY);

            Write("Will Fertilizer and Ground Preparation be needed?" +
                 "1 for Yes, 0 for No: "); // input 1 0r 0
            fertGrPrep = ReadLine();
            fertG = int.Parse(fertGrPrep);
                      

            Write("First Garden ordered by customer? " +
                "1 for Yes, 0 for No: "); //input 1 or 0
            firstGarden = ReadLine();
            firstG = int.Parse(firstGarden);

            double squareYards = (maxW * maxL) / SQYARDCONVERT; //squareyards formula
            double soilCost = (squareYards * priceP) * SOILWASTE;// soilcost formual
            double fertCost = (squareYards * FERTPERSQUAREYARD);//fertlizer cost formula
            double laborCost = (squareYards * SOILLABORPERYARD);// laborcost formula
            

            if (firstG == 1) // if labor cost is yes add $50
                laborCost = laborCost + FIRSTGARDEN;
            if (fertG == 0) // if fertilizer is no then * 0 to make 0
                fertCost = fertCost * NOFERT;
            
            double totalCost = (soilCost + fertCost + laborCost);// total cost formula list after 
            //if statement so FIRSTGARDEN cost can be added if necessary

            WriteLine();// for extra line space
            //all outputs with field widths of 10 characters to right align
            WriteLine($"Sq. Yards needed: {squareYards,10:F1}");//outputs to 1 decimal place
            //outputs using C to make it currency format
            WriteLine($"Soil Cost:        {soilCost,10:C}");
            WriteLine($"Fertilizer Cost:  {fertCost,10:C}");
            WriteLine($"Labor Cost:       {laborCost,10:C}");
            WriteLine($"Total Cost:       {totalCost,10:C}");
        }
    }
}
