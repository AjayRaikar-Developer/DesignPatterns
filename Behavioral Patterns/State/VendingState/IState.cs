namespace DesignPatterns.Behavioral_Patterns.State.VendingState
{
    public interface IState
    {
        public void clickOnInsertCoinButton(VendingMachine machine);

        public void clickOnStartProductSelectionButton(VendingMachine machine);

        public void insertCoin(VendingMachine machine, Coin coin);

        public void chooseProduct(VendingMachine machine, int codeNumber);

        public int getChange(int returnChangeMoney);

        public Item dispenseProduct(VendingMachine machine, int codeNumber);

        public List<Coin> refundFullMoney(VendingMachine machine);

        public void updateInventory(VendingMachine machine, Item item, int codeNumber);
    }
}
