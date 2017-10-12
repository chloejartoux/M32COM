using M32COM.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M32COM.Models.AircraftModels
{
    public abstract class Aircraft
    {
        #region Attributes
        private string registration_id; // 3 digits and 3 letters
        private double total_flying_hours;
        private List<Ground_crew> ground_crew_list; // 5 after 200 flying hours for a 24 hours period of maintenance
        #endregion
        #region Constructors
        #endregion
        #region Methods
        #endregion
        #region Accessors
        #endregion

    }
}
