using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationList.Models
{
    public class OverGroup
    {
        public string relativityid { get; set; }
        public string CRA_UNIQUE_ID { get; set; }
        public string CRA_PARENT_RECORD_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string LASTNAME { get; set; }
        public string SSN { get; set; }
        public string BIRtHDATE { get; set; }
        public string EIN { get; set; }
        public string CRA_MERGED_ADDRESS { get; set; }

        public OverGroup()
        {
            relativityid = "NA";
            CRA_UNIQUE_ID = "NA";
            CRA_PARENT_RECORD_ID = "NA";
            FIRSTNAME = "NA";
            MIDDLENAME = "NA";
            LASTNAME = "NA";
            SSN = "NA";
            BIRtHDATE = "NA";
            EIN = "NA";
            CRA_MERGED_ADDRESS = "NA";
        }

    }

    public class Entity
    {
        public string PARENT_RECORD { get; set; }
        public string ENT { get; set; }
        public string SSN { get; set; }
        public string BIRTHDATE { get; set; }
        public string EIN { get; set; }
        public string MERGED_ADDRESS { get; set; }

        public Entity()
        {
            PARENT_RECORD = "";
            ENT = "";
            SSN = "";
            BIRTHDATE = "";
            EIN = "";
            MERGED_ADDRESS = "";
        }
    }

    public class NotificationPopulation
    {

        public string CRA_PARENT_RECORD_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string LASTNAME { get; set; }
        public string SSN { get; set; }
        public string BIRtHDATE { get; set; }
        public string EIN { get; set; }
        public string CRA_MERGED_ADDRESS { get; set; }
        public string Suffix { get; set; }
        public string Entity { get; set; }

        public NotificationPopulation()
        {
            CRA_PARENT_RECORD_ID = "NA";
            FIRSTNAME = "NA";
            MIDDLENAME = "NA";
            LASTNAME = "NA";
            Suffix = "NA";
            Entity = "NA";
            SSN = "NA";
            BIRtHDATE = "NA";
            EIN = "NA";
            CRA_MERGED_ADDRESS = "NA";
        }
    }

}