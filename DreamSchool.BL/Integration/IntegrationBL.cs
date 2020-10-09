using DreamSchool.BO.Integration;
using DreamSchool.DA.Integration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DreamSchool.BL.Integration
{
    public class IntegrationBL
    {
        public DataTable Login(IntegrationBO obj)
        {
            return new IntegrationDA().Login(obj);
        }
    }
}
