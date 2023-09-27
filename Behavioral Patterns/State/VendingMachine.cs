using DesignPatterns.Behavioral_Patterns.State.VendingState;

namespace DesignPatterns.Behavioral_Patterns.State
{
    public class VendingMachine
    {
        private IState vendingMachineState;
        private Inventory inventory;
        private List<Coin> coinList;

        public VendingMachine()
        {
            vendingMachineState = new IdleState();
            inventory = new Inventory(10);
            coinList = new List<Coin>();
        }

        public IState getVendingMachineState()
        {
            return vendingMachineState;
        }

        public void setVendingMachineState(IState vendingMachineState)
        {
            this.vendingMachineState = vendingMachineState;
        }

        public Inventory getInventory()
        {
            return inventory;
        }

        public void setInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public List<Coin> getCoinList()
        {
            return coinList;
        }

        public void setCoinList(List<Coin> coinList)
        {
            this.coinList = coinList;
        }
    }
}
