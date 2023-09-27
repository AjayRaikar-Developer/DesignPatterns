namespace DesignPatterns.Behavioral_Patterns.State.VendingState
{
    public class IdleState : IState
    {
        public IdleState()
        {
            Console.WriteLine("Currently Vending machine is in IdleState");
        }

        public IdleState(VendingMachine machine)
        {
            Console.WriteLine("Currently Vending machine is in IdleState");
            machine.setCoinList(new List<Coin>());
        }


        public void clickOnInsertCoinButton(VendingMachine machine)
        {
            machine.setVendingMachineState(new HasMoneyState());
        }


        public void clickOnStartProductSelectionButton(VendingMachine machine)
        {
            throw new Exception("first you need to click on insert coin button");

        }


        public void insertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("you can not insert Coin in idle state");
        }


        public void chooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("you can not choose Product in idle state");
        }


        public int getChange(int returnChangeMoney)
        {
            throw new Exception("you can not get change in idle state");
        }


        public List<Coin> refundFullMoney(VendingMachine machine)
        {
            throw new Exception("you can not get refunded in idle state");
        }


        public Item dispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("proeduct can not be dispensed idle state");
        }


        public void updateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            machine.getInventory().addItem(item, codeNumber);
        }
    }
}
