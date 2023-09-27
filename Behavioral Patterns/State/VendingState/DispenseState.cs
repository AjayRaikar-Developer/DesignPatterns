namespace DesignPatterns.Behavioral_Patterns.State.VendingState
{
    public class DispenseState : IState
    {
        public DispenseState(VendingMachine machine, int codeNumber)
        {

            Console.WriteLine("Currently Vending machine is in DispenseState");
            dispenseProduct(machine, codeNumber);
        }


        public void clickOnInsertCoinButton(VendingMachine machine)
        {
            throw new Exception("insert coin button can not clicked on Dispense state");
        }


        public void clickOnStartProductSelectionButton(VendingMachine machine)
        {
            throw new Exception("product selection buttion can not be clicked in Dispense state");

        }


        public void insertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("coin can not be inserted in Dispense state");
        }


        public void chooseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("product can not be choosen in Dispense state");
        }


        public int getChange(int returnChangeMoney)
        {
            throw new Exception("change can not returned in Dispense state");
        }


        public List<Coin> refundFullMoney(VendingMachine machine)
        {
            throw new Exception("refund can not be happen in Dispense state");
        }


        public Item dispenseProduct(VendingMachine machine, int codeNumber)
        {
            Console.WriteLine("Product has been dispensed");
            Item item = machine.getInventory().getItem(codeNumber);
            machine.getInventory().updateSoldOutItem(codeNumber);
            machine.setVendingMachineState(new IdleState(machine));
            return item;
        }


        public void updateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("inventory can not be updated in Dispense state");
        }
    }
}
