using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationList.Queries
{
    public class OverGroupQueries
    {
        public string GetTabWiseQuery(string tabIdName)
        {
            string OGSSN_Query = string.Empty;

            switch (tabIdName)
            {
                case "tabSSN":
                    OGSSN_Query = OGSSN_Query + "SELECT relativityid as [Relativity ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_UNIQUE_ID AS [UNIQUE ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER (FIRSTNAME) FirstName " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", CRA_MERGED_ADDRESS AS [MERGED ADDRESS] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_UNIQUE_ID = Full_Population.CRA_UNIQUE_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "and Review.CRA_PARENT_RECORD_ID = Full_Population.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE FULL_POPULATION.CRA_PARENT_RECORD_ID in (SELECT CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE isnull(SSN, '') <> '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "GROUP BY CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_CLEAN_SSN) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by FULL_POPULATION.CRA_PARENT_RECORD_ID, SSN;";
                    break;
                case "tabDOB":
                    OGSSN_Query = OGSSN_Query + "SELECT relativityid as [Relativity ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_UNIQUE_ID AS [UNIQUE ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", CRA_MERGED_ADDRESS AS [MERGED ADDRESS] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_UNIQUE_ID = Full_Population.CRA_UNIQUE_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "and Review.CRA_PARENT_RECORD_ID = Full_Population.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE FULL_POPULATION.CRA_PARENT_RECORD_ID in (SELECT CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "GROUP BY CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_CLEAN_BIRTHDATE) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by FULL_POPULATION.CRA_PARENT_RECORD_ID;";
                    break;
                case "tabFN":
                    OGSSN_Query = OGSSN_Query + "SELECT relativityid as [Relativity ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_UNIQUE_ID AS [UNIQUE ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", CRA_MERGED_ADDRESS AS [MERGED ADDRESS] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_UNIQUE_ID = Full_Population.CRA_UNIQUE_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "and Review.CRA_PARENT_RECORD_ID = Full_Population.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE FULL_POPULATION.CRA_PARENT_RECORD_ID in (SELECT CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "GROUP BY CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_CLEAN_FIRSTNAME) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by FULL_POPULATION.CRA_PARENT_RECORD_ID;";
                    break;
                case "tabLN":
                    OGSSN_Query = OGSSN_Query + "SELECT relativityid as [Relativity ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_UNIQUE_ID AS [UNIQUE ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", CRA_MERGED_ADDRESS AS [MERGED ADDRESS] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_UNIQUE_ID = Full_Population.CRA_UNIQUE_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "and Review.CRA_PARENT_RECORD_ID = Full_Population.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE FULL_POPULATION.CRA_PARENT_RECORD_ID in (SELECT CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "GROUP BY CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_CLEAN_LASTNAME) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by FULL_POPULATION.CRA_PARENT_RECORD_ID, LASTNAME;";
                    break;
                case "tabFNLN":
                    OGSSN_Query = OGSSN_Query + "SELECT relativityid as [Relativity ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_UNIQUE_ID AS [UNIQUE ID] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", FULL_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", CRA_MERGED_ADDRESS AS [MERGED ADDRESS] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_UNIQUE_ID = Full_Population.CRA_UNIQUE_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "and Review.CRA_PARENT_RECORD_ID = Full_Population.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE FULL_POPULATION.CRA_PARENT_RECORD_ID in (SELECT CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM FULL_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "GROUP BY CRA_PARENT_RECORD_ID " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_CLEAN_LASTNAME) > 1 and " + "\n";
                    OGSSN_Query = OGSSN_Query + "count(distinct CRA_CLEAN_FIRSTNAME) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by FULL_POPULATION.CRA_PARENT_RECORD_ID, LASTNAME, FIRSTNAME;";
                    break;
                case "tabSubPopulation":
                    OGSSN_Query = OGSSN_Query + "SELECT distinct NOTIFICATION_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", Suffix " + "\n";
                    OGSSN_Query = OGSSN_Query + ", ENTITY " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRTHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", MERGED_ADDRESS " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "from NOTIFICATION_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_PARENT_RECORD_ID = NOTIFICATION_POPULATION.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "where entity = '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "and left(FIRSTNAME, 1) + LASTNAME in (SELECT left(FIRSTNAME, 1) + LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM NOTIFICATION_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "where entity = '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "group by left(FIRSTNAME, 1) + LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + "having count(distinct CRA_PARENT_RECORD_ID) > 1) " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by LASTNAME, FIRSTNAME, birthdate";
                    break;
                case "tabFullPopulation":
                    OGSSN_Query = OGSSN_Query + "SELECT distinct NOTIFICATION_POPULATION.CRA_PARENT_RECORD_ID AS [PARENT RECORD] " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(FIRSTNAME) FIRSTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(MIDDLENAME) MIDDLENAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", UPPER(LASTNAME) LASTNAME " + "\n";
                    OGSSN_Query = OGSSN_Query + ", Suffix " + "\n";
                    OGSSN_Query = OGSSN_Query + ", ENTITY " + "\n";
                    OGSSN_Query = OGSSN_Query + ", SSN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", BIRtHDATE " + "\n";
                    OGSSN_Query = OGSSN_Query + ", EIN " + "\n";
                    OGSSN_Query = OGSSN_Query + ", MERGED_ADDRESs " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "from NOTIFICATION_POPULATION " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_PARENT_RECORD_ID = NOTIFICATION_POPULATION.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "where isnull(entity,'')  = '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "order by lastname, firstname, entity";
                    break;
                case "tabEntity":
                    OGSSN_Query = OGSSN_Query + "SELECT distinct notification_population.cra_parent_record_id          AS [PARENT RECORD], " + "\n";
                    OGSSN_Query = OGSSN_Query + "       Replace([entity], 'The ', '') AS [ENT], " + "\n";
                    OGSSN_Query = OGSSN_Query + "       ssn, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       birthdate, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       ein, " + "\n";
                    OGSSN_Query = OGSSN_Query + "       merged_address " + "\n";
                    OGSSN_Query = OGSSN_Query + ", case when Review.review_flg = 1 then 'Flagged' else 'Review Flag' end AS Review_flg" + "\n";
                    OGSSN_Query = OGSSN_Query + "FROM   notification_population " + "\n";
                    OGSSN_Query = OGSSN_Query + "Inner join Review on Review.CRA_PARENT_RECORD_ID = NOTIFICATION_POPULATION.CRA_PARENT_RECORD_ID" + "\n";
                    OGSSN_Query = OGSSN_Query + "WHERE  entity <> '' " + "\n";
                    OGSSN_Query = OGSSN_Query + "ORDER  BY ent";
                    break;
            }


            return OGSSN_Query;
        }

        public string UpdateReviewFlagQuery(string cra_uniqueid,string cra_parentrecordid)
        {
            string updateReviewFlagQuery = "update Review set review_flg = case when review_flg = 'true' then 'false' else 'true' end where ";
            if (!string.IsNullOrEmpty(cra_uniqueid) && !string.IsNullOrEmpty(cra_parentrecordid))
            {
                updateReviewFlagQuery += " CRA_UNIQUE_ID = " + cra_uniqueid;
                updateReviewFlagQuery += " AND CRA_PARENT_RECORD_ID = " + cra_parentrecordid;
            }
            else if (!string.IsNullOrEmpty(cra_uniqueid))
            {
                updateReviewFlagQuery += " CRA_UNIQUE_ID = " + cra_uniqueid;
            }
            else if (!string.IsNullOrEmpty(cra_parentrecordid))
            {
                updateReviewFlagQuery += " CRA_PARENT_RECORD_ID = " + cra_parentrecordid;
            }
            return updateReviewFlagQuery;
        }
    }
}