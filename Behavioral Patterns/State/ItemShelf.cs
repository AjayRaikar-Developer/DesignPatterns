namespace DesignPatterns.Behavioral_Patterns.State
{
    public class ItemShelf
    {
        public int code;
        public Item item;
        public bool soldOut;

        public int getCode()
        {
            return code;
        }

        public void setCode(int code)
        {
            this.code = code;
        }

        public Item getItem()
        {
            return item;
        }

        public void setItem(Item item)
        {
            this.item = item;
        }

        public bool isSoldOut()
        {
            return soldOut;
        }

        public void setSoldOut(bool soldOut)
        {
            this.soldOut = soldOut;
        }
    }
}
