using System.Text;

namespace SantaHelper
{
    public class Kid
    {
        const int MaxNumberOfGifts = 4;
        private int _numberOfGiftsReceived;
        public StringBuilder GiftsReceived { get; }

        public Kid()
        {
            _numberOfGiftsReceived = 0;
            GiftsReceived = new StringBuilder();
        }

        public void AddGift(string gift)
        {
            GiftsReceived.Append(GiftsReceived.Length == 0 ? gift : $" {gift}");
            ++_numberOfGiftsReceived;
        }

        public bool NeedMoreGifts()
        {
            return _numberOfGiftsReceived < MaxNumberOfGifts;
        }
    }
}