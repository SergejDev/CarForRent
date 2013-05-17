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
        private DataBaseContext db = new DataBaseContext();

        public SelectList AutoClassListItems()
        {
            SelectList autoClassItems = new SelectList(db.AutoClasses, "AutoClassId", "ClassTitle");
            return autoClassItems;
        }
        
        public SelectList EngineTypeListItems()
        {
            SelectList engineTypeItems = new SelectList(db.EngineTypes, "EngineTypeId", "EngineTypeTitle");
            return engineTypeItems;
        }

        public SelectList GearboxTypeListItems()
        {
            SelectList gearboxTypeItems = new SelectList(db.GearboxTypes, "GearboxTypeId", "GearboxTypeTitle");
            return gearboxTypeItems;
        }

        public SelectList FuelTypeListItems()
        {
            SelectList fuelTypeItems = new SelectList(db.FuelTypes, "FuelTypeId", "FuelTypeTitle");
            return fuelTypeItems;
        }

        public SelectList AutoListItems()
        {
            SelectList autoItems = new SelectList(db.Autos.Select(e => new { e.Mark }).Distinct(), "Mark", "Mark");
            return autoItems;
        }
    }
}