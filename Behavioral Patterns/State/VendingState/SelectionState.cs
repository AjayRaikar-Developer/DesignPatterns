namespace DesignPatterns.Behavioral_Patterns.State.VendingState
{
    public class SelectionState : IState
    {
        public SelectionState()
        {
            Console.WriteLine("Currently Vending machine is in SelectionState");
        }


        public void clickOnInsertCoinButton(VendingMachine machine)
        {
            throw new Exception("you can not click on insert coin button in Selection state");
        }

        public void clickOnStartProductSelectionButton(VendingMachine machine)
        {
            return;
        }


        public void insertCoin(VendingMachine machine, Coin coin)
        {
            throw new Exception("you can not insert Coin in selection state");
        }


        public void chooseProduct(VendingMachine machine, int codeNumber)
        {

            //1. get item of this codeNumber
            Item item = machine.getInventory().getItem(codeNumber);

            //2. total amount paid by User
            int paidByUser = 0;
            foreach (Coin coin in machine.getCoinList())
            {
                paidByUser = paidByUser + (int)coin;
            }

            //3. compare product price and amount paid by user
            if (paidByUser < item.getPrice())
            {
                Console.WriteLine("Insufficient Amount, Product you selected is for price: " + item.getPrice() + " and you paid: " + paidByUser);
                refundFullMoney(machine);
                throw new Exception("insufficient amount");
            }
            else if (paidByUser >= item.getPrice())
            {

                if (paidByUser > item.getPrice())
                {
                    getChange(paidByUser - item.getPrice());
                }
                machine.setVendingMachineState(new DispenseState(machine, codeNumber));
            }
        }


        public int getChange(int returnExtraMoney)
        {
            //actual logic should be to return COINs in the dispense tray, but for simplicity i am just returning the amount to be refunded
            Console.WriteLine("Returned the change in the Coin Dispense Tray: " + returnExtraMoney);
            return returnExtraMoney;
        }


        public List<Coin> refundFullMoney(VendingMachine machine)
        {
            Console.WriteLine("Returned the full amount back in the Coin Dispense Tray");
            machine.setVendingMachineState(new IdleState(machine));
            return machine.getCoinList();
        }


        public Item dispenseProduct(VendingMachine machine, int codeNumber)
        {
            throw new Exception("product can not be dispensed Selection state");
        }


        public void updateInventory(VendingMachine machine, Item item, int codeNumber)
        {
            throw new Exception("Inventory can not be updated in Selection state");
        }

    }
}
