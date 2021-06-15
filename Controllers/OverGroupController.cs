using NotificationList.Controllers.DAO;
using NotificationList.Models;
using NotificationList.Queries;
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
        public ActionResult OGSSN(string tabIdName, string databaseName, string IsUpdateReviewFlag,string cra_parentrecordid, string cra_uniqueid)
        {


            List<OverGroup> overGroupSSN_List = new List<OverGroup>();
            List<Entity> overGroupEntity_List = new List<Entity>();
            List<NotificationPopulation> notificationPopulations = new List<NotificationPopulation>();
            ViewBag.DatabaseName = databaseName;
            string connectionstring = GetConnectionString(databaseName);
            string OGSSN_Query = string.Empty;
            OverGroupDAO ogdao = new OverGroupDAO();

            if (string.IsNullOrEmpty(databaseName))
            {
                return View("OverGroup", overGroupSSN_List);
            }


            OverGroupQueries overGroupQueries = new OverGroupQueries();
            if (IsUpdateReviewFlag == "Y")
            {
                string updateReviewFlagQuery = overGroupQueries.UpdateReviewFlagQuery(cra_uniqueid, cra_parentrecordid);
                ogdao.UpdateReviewFlag(connectionstring, updateReviewFlagQuery);
            }

            OGSSN_Query = overGroupQueries.GetTabWiseQuery(tabIdName);

            switch (tabIdName)
            {
                case "tabSSN":
                case "tabDOB":
                case "tabFN":
                case "tabLN":
                case "tabFNLN":
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
                case "tabSubPopulation":
                case "tabFullPopulation":
                    notificationPopulations = ogdao.FetchNotificationPopulation(connectionstring, OGSSN_Query);
                    return PartialView("NotificationPopulationView", notificationPopulations);
                case "tabEntity":
                    overGroupEntity_List = ogdao.FetchEntity(connectionstring, OGSSN_Query);
                    return PartialView("EntityView", overGroupEntity_List);
                default:
                    overGroupSSN_List = ogdao.FetchDataFullPopulation(connectionstring, OGSSN_Query);
                    break;
            }

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