using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW2ProfitCalc
{
    public partial class GWProfitCalc : Form
    {
        public GWProfitCalc()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int intBuyGold = 0;
            int intBuySilver = 0;
            int intBuyCopper = 0;
            int intSellGold = 0;
            int intSellSilver = 0;
            int intSellCopper = 0;
            int buyInt = 0;
            int sellInt = 0;
            int listInt = 0;
            int exchInt = 0;
            int profitInt = 0;
            int totalSellInt = 0;
            int totalBuyInt = 0;
            int profitPercent = 0;
            string totalBuyString = "";
            string totalSellString = "";
            string totalBuyS = "";
            string totalBuyC = "";
            string totalSellS = "";
            string totalSellC = "";
            string profitS = "";
            string profitC = "";
            string listS = "";
            string listC = "";
            string exchS = "";
            string exchC = "";
            string listString = "";
            string exchString = "";
            string profitString = "";
            string buyString = "";
            string sellString = "";

            if (buyGold.Value > 0) intBuyGold = (int)buyGold.Value;
            if (buySilver.Value > 0) intBuySilver = (int)buySilver.Value;
            if (buyCopper.Value > 0) intBuyCopper = (int)buyCopper.Value;
            if (intBuyGold > 0)
            {
                buyString = buyString + intBuyGold.ToString();
            }
            if (intBuySilver > 0)
            {
                if (intBuySilver < 10)
                {
                    buyString = buyString + "0" + intBuySilver.ToString();
                }
                else buyString = buyString + intBuySilver.ToString();
            }
            else
                buyString = buyString + "00";
            if (intBuyCopper > 0)
            {
                if (intBuyCopper < 10)
                {
                    buyString = buyString + "0" + intBuyCopper.ToString();
                }
                else buyString = buyString + intBuyCopper.ToString();
            }
            else buyString = buyString + "00";
            int.TryParse(buyString, out buyInt);
            buyInt = buyInt * (int)quantity.Value;
            totalBuyInt = buyInt;
            totalBuyString = buyInt.ToString();

            if (sellGold.Value > 0) intSellGold = (int)sellGold.Value;
            if (sellSilver.Value > 0) intSellSilver = (int)sellSilver.Value;
            if (sellCopper.Value > 0) intSellCopper = (int)sellCopper.Value;
            if (intSellGold > 0)
            {
                sellString = sellString + intSellGold.ToString();
            }
            if (intSellSilver > 0)
            {
                if (intSellSilver < 10)
                {
                    sellString = sellString + "0" + intSellSilver.ToString();
                }
                else sellString = sellString + intSellSilver.ToString();
            }
            else
                sellString = sellString + "00";
            if (intSellCopper > 0)
            {
                if (intSellCopper < 10)
                {
                    sellString = sellString + "0" + intSellCopper.ToString();
                }
                else sellString = sellString + intSellCopper.ToString();
            }
            else sellString = sellString + "00";
            int.TryParse(sellString, out sellInt);

            listInt = (int)(sellInt * 0.05) * (int)quantity.Value;
            exchInt = (int)(sellInt * 0.10) * (int)quantity.Value;
            sellInt = sellInt * (int)quantity.Value;
            totalSellInt = sellInt;
            totalSellString = sellInt.ToString();
            listString = listInt.ToString();
            exchString = exchInt.ToString();

            if (listString.Length <= 2)
            {
                if (listString.Length == 1)
                {
                    listC = listString;
                }
                else
                {
                    listC = listString.Substring(listString.Length - 1);
                }
                if (listC.Substring(0, 1) == "0") listC = listC.Substring(1);
                listingFee.Text = listC + "c";
            }
            else
            {
                if (listString.Length > 4)
                {
                    listC = listString.Substring(listString.Length - 2);
                    listString = listString.Substring(0, listString.Length - 2);
                    if (listString.Substring(listString.Length - 1, 1) == "0")
                    {
                        listS = listString.Substring(listString.Length - 1);
                    }
                    else profitS = listString.Substring(listString.Length - 2);
                    listString = listString.Substring(0, listString.Length - 2);
                    if (listC.Substring(0, 1) == "0") listC = listC.Substring(1);
                    listingFee.Text = listString + "g " + listS + "s " + listC + "c";
                }
                else
                {
                    if (listString.Length == 4 | listString.Length == 3)
                    {
                        listC = listString.Substring(listString.Length - 2);
                        listString = listString.Substring(0, listString.Length - 2);
                        if (listString.Length == 2)
                        {
                            listS = listString.Substring(0);
                        }
                        else
                        {
                            listS = listString.Substring(listString.Length - 1, 1);
                        }
                        if (listC.Substring(0, 1) == "0") listC = listC.Substring(1);
                        listingFee.Text = listS + "s " + listC + "c";
                    }
                }
            }

            if (exchString.Length <= 2)
            {
                if (exchString.Length == 1)
                {
                    exchC = exchString;
                }
                else
                {
                    exchC = exchString.Substring(exchString.Length - 1);
                }
                if (exchC.Substring(0, 1) == "0") exchC = exchC.Substring(1);
                exchangeFee.Text = exchC + "c";
            }
            else
            {
                if (exchString.Length > 4)
                {
                    exchC = exchString.Substring(exchString.Length - 2);
                    exchString = exchString.Substring(0, exchString.Length - 2);
                    if (exchString.Substring(exchString.Length - 1, 1) == "0")
                    {
                        exchS = exchString.Substring(exchString.Length - 1);
                    }
                    else exchS = exchString.Substring(exchString.Length - 2);
                    exchString = exchString.Substring(0, exchString.Length - 2);
                    if (exchC.Substring(0, 1) == "0") exchC = exchC.Substring(1);
                    exchangeFee.Text = exchString + "g " + exchS + "s " + exchC + "c";
                }
                else
                {
                    if (exchString.Length == 4 | exchString.Length == 3)
                    {
                        exchC = exchString.Substring(exchString.Length - 2);
                        exchString = exchString.Substring(0, exchString.Length - 2);
                        if (exchString.Length == 2)
                        {
                            exchS = exchString.Substring(0);
                        }
                        else
                        {
                            exchS = exchString.Substring(exchString.Length - 1, 1);
                        }
                        if (exchC.Substring(0, 1) == "0") exchC = exchC.Substring(1);
                        exchangeFee.Text = exchS + "s " + exchC + "c";
                    }
                }
            }
            profitInt = sellInt - (buyInt + exchInt + listInt);
            profitString = profitInt.ToString();

            if (profitString.Length <= 2 && profitInt > 0)
            {
                if (profitString.Length == 1)
                {
                    profitC = profitString;
                }
                else
                {
                    profitC = profitString.Substring(profitString.Length - 1);
                }
                if (profitC.Substring(0, 1) == "0") profitC = profitC.Substring(1);
                profit.Text = profitC + "c";
            }
            else
            {
                if (profitString.Length > 4 && profitInt > 0)
                {
                    profitC = profitString.Substring(profitString.Length - 2);
                    profitString = profitString.Substring(0, profitString.Length - 2);
                    if (profitString.Substring(profitString.Length - 1, 1) == "0")
                    {
                        profitS = profitString.Substring(profitString.Length - 1);
                    }
                    else profitS = profitString.Substring(profitString.Length - 2);
                    profitString = profitString.Substring(0, profitString.Length - 2);
                    if (profitC.Substring(0, 1) == "0") profitC = profitC.Substring(1);
                    profit.Text = profitString + "g " + profitS + "s " + profitC + "c";
                }
                else
                {
                    if (profitString.Length == 4 && profitInt > 0 | profitString.Length == 3 && profitInt > 0)
                    {
                        profitC = profitString.Substring(profitString.Length - 2);
                        profitString = profitString.Substring(0, profitString.Length - 2);
                        if (profitString.Length == 2)
                        {
                            profitS = profitString.Substring(0);
                        }
                        else
                        {
                            profitS = profitString.Substring(profitString.Length - 1, 1);
                        }
                        if (profitC.Substring(0, 1) == "0") profitC = profitC.Substring(1);
                        profit.Text = profitS + "s " + profitC + "c";
                    }
                }
                if (profitInt < 0) profit.Text = "Net Loss";
                profitPercent = (int)Math.Round((double)(100 * profitInt) / buyInt);
                profit.Text = profit.Text + " (" + profitPercent + "%)";
            }

            if (totalBuyString.Length <= 2)
            {
                if (totalBuyString.Length == 1)
                {
                    totalBuyC = totalBuyString;
                }
                else
                {
                    totalBuyC = totalBuyString.Substring(totalBuyString.Length - 1);
                }
                if (totalBuyC.Substring(0, 1) == "0") totalBuyC = totalBuyC.Substring(1);
                totalBuy.Text = totalBuyC + "c";
            }
            else
            {
                if (totalBuyString.Length > 4)
                {
                    totalBuyC = totalBuyString.Substring(totalBuyString.Length - 2);
                    totalBuyString = totalBuyString.Substring(0, totalBuyString.Length - 2);
                    if (totalBuyString.Substring(totalBuyString.Length - 1, 1) == "0")
                    {
                        totalBuyS = totalBuyString.Substring(totalBuyString.Length - 1);
                    }
                    else totalBuyS = totalBuyString.Substring(totalBuyString.Length - 2);
                    totalBuyString = totalBuyString.Substring(0, totalBuyString.Length - 2);
                    if (totalBuyC.Substring(0, 1) == "0") totalBuyC = totalBuyC.Substring(1);
                    totalBuy.Text = totalBuyString + "g " + totalBuyS + "s " + totalBuyC + "c";
                }
                else
                {
                    if (totalBuyString.Length == 4 | totalBuyString.Length == 3)
                    {
                        totalBuyC = totalBuyString.Substring(totalBuyString.Length - 2);
                        totalBuyString = totalBuyString.Substring(0, totalBuyString.Length - 2);
                        if (totalBuyString.Length == 2)
                        {
                            totalBuyS = totalBuyString.Substring(0);
                        }
                        else
                        {
                            totalBuyS = totalBuyString.Substring(totalBuyString.Length - 1, 1);
                        }
                        if (totalBuyC.Substring(0, 1) == "0") totalBuyC = totalBuyC.Substring(1);
                        totalBuy.Text = totalBuyS + "s " + totalBuyC + "c";
                    }
                }
            }

            if (totalSellString.Length <= 2)
            {
                if (totalSellString.Length == 1)
                {
                    totalSellC = totalSellString;
                }
                else
                {
                    totalSellC = totalSellString.Substring(totalSellString.Length - 1);
                }
                if (totalSellC.Substring(0, 1) == "0") totalSellC = totalSellC.Substring(1);
                totalSell.Text = totalSellC + "c";
            }
            else
            {
                if (totalSellString.Length > 4)
                {
                    totalSellC = totalSellString.Substring(totalSellString.Length - 2);
                    totalSellString = totalSellString.Substring(0, totalSellString.Length - 2);
                    if (totalSellString.Substring(totalSellString.Length - 1, 1) == "0")
                    {
                        totalSellS = totalSellString.Substring(totalSellString.Length - 1);
                    }
                    else totalSellS = totalSellString.Substring(totalSellString.Length - 2);
                    totalSellString = totalSellString.Substring(0, totalSellString.Length - 2);
                    if (totalSellC.Substring(0, 1) == "0") totalSellC = totalSellC.Substring(1);
                    totalSell.Text = totalSellString + "g " + totalSellS + "s " + totalSellC + "c";
                }
                else
                {
                    if (totalSellString.Length == 4 | totalSellString.Length == 3)
                    {
                        totalSellC = totalSellString.Substring(totalSellString.Length - 2);
                        totalSellString = totalSellString.Substring(0, totalSellString.Length - 2);
                        if (totalSellString.Length == 2)
                        {
                            totalSellS = totalSellString.Substring(0);
                        }
                        else
                        {
                            totalSellS = totalSellString.Substring(totalSellString.Length - 1, 1);
                        }
                        if (totalSellC.Substring(0, 1) == "0") totalSellC = totalSellC.Substring(1);
                        totalSell.Text = totalSellS + "s " + totalSellC + "c";
                    }
                }
            }
        }
    }
}
