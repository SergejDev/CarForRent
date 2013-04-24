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
        //private const String DefaultMessage = "Select pleace";

        private DataBaseContext db = new DataBaseContext();

        public SelectList AutoClassListItems()
        {
            SelectList autoClassItems = new SelectList(db.AutoClasses, "AutoClassId", "ClassTitle");
            //gearboxTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            //foreach (var gearboxType in db.GearboxTypes)
            //{
            //    gearboxTypeItems.Add(new SelectListItem() { Value = gearboxType.GearboxTypeId.ToString(), Text = gearboxType.GearboxTypeTitle });
            //}

            return autoClassItems;
        }
        
        public SelectList EngineTypeListItems()
        {
            SelectList engineTypeItems = new SelectList(db.EngineTypes, "EngineTypeId", "EngineTypeTitle");
            //engineTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            //foreach (var engineType in db.EngineTypes)
            //{
            //    engineTypeItems.Add(new SelectListItem() { Value = engineType.EngineTypeId.ToString(), Text = engineType.EngineTypeTitle });
            //}

            return engineTypeItems;
        }

        public SelectList GearboxTypeListItems()
        {
            SelectList gearboxTypeItems = new SelectList(db.GearboxTypes, "GearboxTypeId", "GearboxTypeTitle");
            //gearboxTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            //foreach (var gearboxType in db.GearboxTypes)
            //{
            //    gearboxTypeItems.Add(new SelectListItem() { Value = gearboxType.GearboxTypeId.ToString(), Text = gearboxType.GearboxTypeTitle });
            //}

            return gearboxTypeItems;
        }

        public SelectList FuelTypeListItems()
        {
            SelectList fuelTypeItems = new SelectList(db.FuelTypes, "FuelTypeId", "FuelTypeTitle");
            //fuelTypeItems.Add(new SelectListItem() { Text = DefaultMessage });
            //foreach (var fuelType in db.FuelTypes)
            //{
            //    fuelTypeItems.Add(new SelectListItem() { Value = fuelType.FuelTypeId.ToString(), Text = fuelType.FuelTypeTitle });
            //}

            return fuelTypeItems;
        }
    }
}