using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIO.DataBase
{
    public partial class SelectionCampaign
    {
        public int CampaignYear
        {
            get
            {
                return StartDate.Year;
            }
        }

        public bool IsOver
        {
            get
            {
                return StudentIOEntities2.GetContext().OrderOfAdmission.
                    FirstOrDefault(u => u.SelectionCampaignId == IdSelectionCampaign) != null;
            }
        }
    }
}
