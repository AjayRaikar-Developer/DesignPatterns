namespace DesignPatterns.Behavioral_Patterns.State.VendingState
{
    public class HasMoneyState : IState
    {
        public HasMoneyState()
        {
            Console.WriteLine("Currently Vending machine is in HasMoneyState");
        }

        public void clickOnInsertCoinButton(VendingMachine machine)
        {
            return;
        }


        public void clickOnStartProductSelectionButton(VendingMachine machine)
        {
            machine.setVendingMachineState(new SelectionState());
        }


        public void insertCoin(VendingMachine machine, Coin coin)
        {
            Console.WriteLine("Accepted the coin");
            machine.getCoinList().Add(coin);
        }


        public void chooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("you need to click on start product selection button first");
        }


        public int getChange(int returnChangeMoney)
        {
            throw new Exception("you can not get change in hasMoney state");
        }


        public Item dispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("product can not be dispensed in hasMoney state");
        }


        public List<Coin> refundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.setVendingMachineState(new IdleState(machine));
            return machine.getCoinList();
        }


        public void updateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("you can not update inventory in hasMoney  state");
        }
    }
}
