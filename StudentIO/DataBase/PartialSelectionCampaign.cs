using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIO.DataBase
{
    public class PartialSelectionCampaign : SelectionCampaign
    {
        public int CampaignYear
        {
            get
            {
                return StartDate.Year;
            }
        }


    }
}
