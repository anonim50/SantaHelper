using System;
using System.Text;

namespace SantaHelper
{
    public class SantaGifts
    {
        public string[] Distribute(string[] gifts, int numberOfKids)
        {
            Kid[] kids = new Kid[numberOfKids];

            for (var i = 0; i < numberOfKids; i++)
            {
                kids[i] = new Kid();
            }

            var currentKid = 0;

            foreach (var gift in gifts)
            {
                if (kids[currentKid].NeedMoreGifts())
                {
                    kids[currentKid++].AddGift(gift);
                    currentKid %= numberOfKids;
                }
                else
                {
                    break;
                }
            }

            return GetGiftsFromKids(kids);
        }

        private string[] GetGiftsFromKids(Kid[] kids)
        {
            string[] gifts = new string[kids.Length];
            for (var i = 0; i < kids.Length; i++)
            {
                gifts[i] = kids[i].GiftsReceived.ToString();
            }
            return gifts;
        }
    }
}