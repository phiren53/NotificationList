using NotificationList.Controllers.DAO;
using NotificationList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotificationList.Controllers
{
    public class OverGroupController : Controller
    {
        // GET: OverGroup
        public ActionResult OGSSN(string tabIdName, string databaseName,string IsUpdateReviewFlag,string cra_uniqueid)
        {
            List<OverGroup> overGroupSSN_List = new List<OverGroup>();
            List<Entity> overGroupEntity_List = new List<Entity>();
            ViewBag.DatabaseName = databaseName;
            string connectionstring = GetConnectionString(databaseName);
            string OGSSN_Query = string.Empty;
            OverGroupDAO ogdao = new OverGroupDAO();
            //GitTesting.
            if (IsUpdateReviewFlag == "Y")
            {
                string updateReviewFlagQuery = "update FULL_POPULATION set middlename = 'true' where CRA_UNIQUE_ID = " + cra_uniqueid;
                ogdao.UpdateReviewFlag(connectionstring, updateReviewFlagQuery);
            }

            switch (tabIdName)
            {
                case "tabSSN":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabDOB":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75319";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabFN":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75320";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabLN":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75321";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabFNLN":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75322";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabSubPopulation":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75323";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabFullPopulation":
                    OGSSN_Query = "SELECT TOP 10 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75324";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabEntity":
                    OGSSN_Query = OGSSN_Query + "SELECT cra_parent_record_id          AS [PARENT RECORD], " + "\n";
                    OGSSN_Query = OGSSN_Query + "       Replace([entity], 'The ', '') AS [ENT], " + "\n";
                    OGSSN_Query = OGSSN_Query + "       ssn, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       birthdate, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       ein, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       merged_address " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM   notification_population " + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE  entity <> '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "ORDER  BY ent";
                    overGroupEntity_List = ogdao.FetchEntity(connectionstring, OGSSN_Query);
                    return PartialView("EntityView", overGroupEntity_List);
                default:
                    OGSSN_Query = "SELECT TOP 5 relativityid,  CRA_UNIQUE_ID, CRA_PARENT_RECORD_ID , case when isnull(FIRSTNAME, '') <> '' then FIRSTNAME else '' end FIRSTNAME , case when isnull(MIDDLENAME, '') <> '' then MIDDLENAME else '' end MIDDLENAME ,case when isnull(LASTNAME, '') <> '' then LASTNAME else '' end LASTNAME ,case when isnull(SSN, '') <> '' then SSN else '' end SSN ,case when isnull(BIRtHDATE, '') <> '' then BIRtHDATE else '' end BIRtHDATE ,case when isnull(EIN, '') <> '' then EIN else '' end EIN ,case when isnull(CRA_MERGED_ADDRESS, '') <> '' then CRA_MERGED_ADDRESS else '' end CRA_MERGED_ADDRESS FROM FULL_POPULATION WHERE CRA_UNIQUE_ID = 75326";
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
            }





            //return PartialView("DataListView", overGroupSSN_List);
            if (tabIdName == null)
            {
                return View("OverGroup", overGroupSSN_List);
            }
            else
            {
                return PartialView("DataListView", overGroupSSN_List);
            }
        }

        private string GetConnectionString(string databasename)
        {
            var dbName = string.IsNullOrEmpty(databasename) ? "testrun_vc" : databasename;
            string connectionstring = "Server=DESKTOP-R7EJR1N;Database=" + dbName + ";Trusted_Connection=True;";
            return connectionstring;
        }

    }
}