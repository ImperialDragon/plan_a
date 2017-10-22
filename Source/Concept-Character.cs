    class Armor
    {
        private string itemName;
        private string itemSlot;
        private int itemDefence;
        private int itemMoveSpeed;
        private int itemRunningSpeed;
        private int itemFlySpeed;
        private int itemWeight;
        public Armor(string inItemName, string inItemSlot, int inItemDefence, int inItemMoveSpeed, int inItemRunningSpeed, int inItemFlySpeed, int inItemWeight)
        {
            this.itemName = inItemName;
            this.itemSlot = inItemSlot;
            this.itemDefence = inItemDefence;
            this.itemMoveSpeed = inItemMoveSpeed;
            this.itemRunningSpeed = inItemRunningSpeed;
            this.itemFlySpeed = inItemFlySpeed;
            this.itemWeight = inItemWeight;
        }
    }
    class Weapons
    {
        private string itemName;
        private string itemSlot;
        private int itemDamage;
        private int itemAttackSpeed;
        private int itemNeedSlots;
        private int itemMoveSpeed;
        private int itemRunningSpeed;
        private int itemFlySpeed;
        private int itemWeight;
        public Weapons(string inItemName, string inItemSlot, int inItemDamage, int inItemAttackSpeed, int inItemNeedSlots, int inItemMoveSpeed, int inItemRunningSpeed, int inItemFlySpeed, int inItemWeight)
        {
            this.itemName = inItemName;
            this.itemSlot = inItemSlot;
            this.itemDamage = inItemDamage;
            this.itemAttackSpeed = inItemAttackSpeed;
            this.itemNeedSlots = inItemNeedSlots;
            this.itemMoveSpeed = inItemMoveSpeed;
            this.itemRunningSpeed = inItemRunningSpeed;
            this.itemFlySpeed = inItemFlySpeed;
            this.itemWeight = inItemWeight;
        }
    }
    class RangeWeapons : Weapons
    {
        private int itemAttackRange;
        public RangeWeapons(string inItemName, string inItemSlot, int inItemDamage, int inItemAttackSpeed, int inItemNeedSlots, int inItemMoveSpeed, int inItemRunningSpeed, int inItemFlySpeed, int inItemWeight, int inItemAttackRange)
            : base(inItemName, inItemSlot, inItemDamage, inItemAttackSpeed, inItemNeedSlots, inItemMoveSpeed, inItemRunningSpeed, inItemFlySpeed, inItemWeight)
        {
            this.itemAttackRange = inItemAttackRange;
        }
    }
    class Eat
    {
        private string itemName;
        private string itemHealHp;
        private string itemHealSp;
    }
    public class Items
    {
        
    }
    public class Inventory
    {
        Items headSlot = new Items();
        Items bodySlot = new Items();
        Items downSlot = new Items();
        Items bootsSlot = new Items();
        Items lefthandSlot = new Items();
        Items righthandSlot = new Items();
        Items flySlot = new Items();
        Items[] invetorySlots = new Items[100];
    }
    public static class Character
    {
        static public int hp = 50;
        static public int sp = 50;
        static public int damage = 2;
        static public int attackSpeed = 5;
        static public int defence = 0;
        static public int moveSpeed = 10;
        static public int runningSpeed = 25;
        static public Inventory inventory;
    }