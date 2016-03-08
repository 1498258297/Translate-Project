namespace FeederBuddy
{
    using EloBuddy.SDK.Menu;
    using EloBuddy.SDK.Menu.Values;

    public class InitializeMenu
    {
        #region Static Fields

        private static Menu fMenu, feMenu, miscMenu;

        #endregion

        #region Public Methods and Operators

        public static void Load()
        {
            fMenu = MainMenu.AddMenu("抵制贩卖挂机脚本", "feederbuddy");

            fMenu.AddGroupLabel("卖脚本死全家");
            fMenu.AddLabel("卖挂机死全家");
            fMenu.AddSeparator();
            fMenu.Add("FeedingActivated", new CheckBox("抵制兜兜"));

            fMenu.Add("FeedingMode", new Slider("让你卖: 让你卖", 0, 0, 3));

            feMenu = fMenu.AddSubMenu("让你卖", "feedingmenu");
            feMenu.AddLabel("让你卖");
            feMenu.Add("SpellsActivated", new CheckBox("呵呵呵"));
            feMenu.Add("MessagesActivated", new CheckBox("呵呵呵"));
            feMenu.Add("LaughActivated", new CheckBox("让你卖"));
            feMenu.Add("ItemsActivated", new CheckBox("让你卖"));
            feMenu.Add("AttacksDisabled", new CheckBox("让你卖"));

            miscMenu = fMenu.AddSubMenu("让你卖", "让你卖");
            miscMenu.AddLabel("让你卖");
            miscMenu.Add("SurrenderActivated", new CheckBox("让你卖"));

            Entry.Menu = fMenu;
            Entry.FeedMenu = feMenu;
            Entry.MiscMenu = miscMenu;
        }

        #endregion
    }
}