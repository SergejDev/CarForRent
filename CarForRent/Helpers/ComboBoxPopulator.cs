using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarForRent.Helpers
{
    public static class ComboBoxPopulator
    {
        public static void PopulateAutoComboBoxes(dynamic viewBag)
        {
            SelectedListBuilder listBuilder = new SelectedListBuilder();
            viewBag.AutoClassItems = listBuilder.AutoClassListItems();
            viewBag.EngineTypeItems = listBuilder.EngineTypeListItems();
            viewBag.GearboxTypeItems = listBuilder.GearboxTypeListItems();
            viewBag.FuelTypeItems = listBuilder.FuelTypeListItems();
        }

    }
}