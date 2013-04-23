using CarForRent.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarForRent.Helpers
{
    public class SelectedListBuilder
    {
        private const String DefaultMessage = "Select pleace";

        private DataBaseContext db = new DataBaseContext();

        public List<SelectListItem> EngineTypeListItems()
        {
            List<SelectListItem> engineTypeItems = new List<SelectListItem>();
            engineTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            foreach (var engineType in db.EngineTypes)
            {
                engineTypeItems.Add(new SelectListItem() { Value = engineType.EngineTypeId.ToString(), Text = engineType.EngineTypeTitle });
            }

            return engineTypeItems;
        }

        public List<SelectListItem> GearboxTypeListItems()
        {
            List<SelectListItem> gearboxTypeItems = new List<SelectListItem>();
            gearboxTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            foreach (var gearboxType in db.GearboxTypes)
            {
                gearboxTypeItems.Add(new SelectListItem() { Value = gearboxType.GearboxTypeId.ToString(), Text = gearboxType.GearboxTypeTitle });
            }

            return gearboxTypeItems;
        }

        public List<SelectListItem> FuelTypeListItems()
        {
            List<SelectListItem> fuelTypeItems = new List<SelectListItem>();
            fuelTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            foreach (var fuelType in db.FuelTypes)
            {
                fuelTypeItems.Add(new SelectListItem() { Value = fuelType.FuelTypeId.ToString(), Text = fuelType.FuelTypeTitle });
            }

            return fuelTypeItems;
        }
    }
}